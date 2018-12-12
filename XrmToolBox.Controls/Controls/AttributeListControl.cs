using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Xrm.Sdk.Metadata;
using System.Reflection;

namespace XrmToolBox.Controls
{
    /// <summary>
    /// Control that displays a list of Attributes for an Entity
    /// </summary>
    public partial class AttributeListControl : FilteredListViewBaseControl
    {
        private EntityMetadata _parentEntity;

        /// <summary>
        /// Reference to the Parent Entity for the attributes
        /// </summary>
        [Category("XrmToolBox")]
        [Description("Reference to the Parent Entity from which the Attributes will be loaded")]
        [Browsable(false)]
        public EntityMetadata ParentEntity { get => _parentEntity; set => SetParentEntity(value); }

        /// <summary>
        /// The Entity Logical Name for the Parent Entity
        /// </summary>
        [Category("XrmToolBox")]
        [Description("Parent Entity LogicalName from which the Attributes will be loaded")]
        [Browsable(false)]
        public string ParentEntityLogicalName { get => _parentEntity?.LogicalName; set => SetParentEntity(value); }

        /// <summary>
        /// Reference to the currently selected Attribute
        /// </summary>
        [Category("XrmToolBox")]
        [Description("Reference to the Selected AttributeMetadata item in the ListView")]
        [Browsable(false)]
        public AttributeMetadata SelectedAttribute { get => SelectedItem as AttributeMetadata; }

        /// <summary>
        /// Reference to the currently selected Attribute
        /// </summary>
        [Category("XrmToolBox")]
        [Description("Reference to the Checked AttributeMetadata items in the ListView")]
        [Browsable(false)]
        public List<AttributeMetadata> CheckedAttributes { get => CheckedItems?.Select(i=> i as AttributeMetadata).ToList<AttributeMetadata>(); }

        /// <summary>
        /// Reference to the currently selected Attribute
        /// </summary>
        [Category("XrmToolBox")]
        [Description("Reference to all Attributes in the list")]
        [Browsable(false)]
        public List<AttributeMetadata> AllAttributes { get => ParentEntity?.Attributes?.ToList(); }

        /// <summary>
        /// Reference to all Attributes as a bindable list
        /// </summary>
        [Category("XrmToolBox")]
        [Description("Reference to all Attributes as a bindable list")]
        [Browsable(false)]
        public List<ListDisplayItem> AllAttributesBindable
        {
            get {
                var allAttr = new List<ListDisplayItem>();
                if (AllAttributes != null)
                {
                    allAttr = AllAttributes
                        .Select(attr => new ListDisplayItem(attr.SchemaName,
                                       CrmActions.GetLocalizedLabel(attr.DisplayName, attr.SchemaName, LanguageCode),
                                       CrmActions.GetLocalizedLabel(attr.Description, null, LanguageCode),
                                       attr))
                        .ToList();
                }
                return allAttr;
            }
        }

        /// <summary>
        /// Set up the ListViewColumnDef defaults
        /// </summary>
        protected override void ResetListViewColDefs()
        {
            // default the col defs for the 
            ListViewColDefs = new ListViewColumnDef[] {
                new ListViewColumnDef( "SchemaName", 0, "Schema Name"){ Width = 150 },
                new ListViewColumnDef("DisplayName", 1, "Display Name"),
                new ListViewColumnDef("AttributeTypeName", 2,"Attribute Type") { IsGroupColumn = true },
                new ListViewColumnDef("Description", 3){ Width = 250 },
                new ListViewColumnDef( "IsPrimaryId", 4, "Is Primary Id"),
                new ListViewColumnDef("IsPrimaryName", 5, "Is Primary Name"),
                new ListViewColumnDef("IsManaged", 6, "Is Managed")
            };
        }
        
        /// <summary>
        /// Constructor!
        /// </summary>
        public AttributeListControl(): base()
        {
            InitializeComponent();

            // init the col defs items
            ResetListViewColDefs();
        }

        /// <summary>
        /// Clear out the parent entity and the related attributes
        /// </summary>
        public override void ClearData()
        {
            _parentEntity = null;
            base.ClearData();
        }

        /// <summary>
        /// Set a reference to the parent entity for the attributes
        /// </summary>
        /// <param name="entity"></param>
        private void SetParentEntity(EntityMetadata entity)
        {
            // already cleared or never initialized, nothing to do 
            if (_parentEntity == null && entity == null) {
                return;
            }
            // if this is a reference to the same entity, then do not reload.
            else if (_parentEntity?.LogicalName.ToLower() == entity?.LogicalName.ToLower()) {
                return;
            }

            // now update the parent entity reference
            _parentEntity = entity;

            // if the parent entity is null
            if (ParentEntity == null)
            {
                ClearData();

                ToggleMainControlsEnabled(false);
            }
            else
            {
                // see if the Attributes collection has been loaded on the entity
                if (ParentEntity.Attributes == null)
                {
                    // load the attributes for the entity
                    LoadData(false);
                }
            }
        }

        /// <summary>
        /// Set the Logical Name of the Parent Entity so that we can load its attributes
        /// </summary>
        /// <param name="entityLogicalName"></param>
        private void SetParentEntity(string entityLogicalName)
        {
            // already cleared or never initialized, nothing to do 
            if ((_parentEntity == null) && (entityLogicalName == null))
            {
                return;
            }
            // setting existing to null, clear and disable
            else if ((_parentEntity != null) && (entityLogicalName == null))
            {
                ClearData();
                ToggleMainControlsEnabled(false);
            }
            else
            {
                // set up new.. 
                _parentEntity = new EntityMetadata() {
                    LogicalName = entityLogicalName
                };

                // set up the entity and then load
                LoadData(false);
            }
        }

        /// <summary>
        /// Load the Attributes using the current IOrganizationService.
        /// The call is asynchronous and will leverage the WorkAsync object on the parent XrmToolBox control
        /// </summary>
        public override void LoadData()
        {
            // this is for developers!  If LoadData is called from within WorkAsync, the controls will be 
            // inaccessible because of the worker thread
            if (this.InvokeRequired)
                throw new InvalidOperationException("This method cannot be invoked from WorkAsync");

            LoadData(true);
        }

        /// <summary>
        /// Private method that will rethrow an Exception if specified in the parameter.
        /// This is meant to allow for external programmatic calls to load vs those from the built in controls
        /// </summary>
        /// <param name="throwException">Flag indicating whether to rethrow a captured exception</param>
        protected override void LoadData(bool throwException)
        {
            OnBeginLoadData();

            if (Service == null || ParentEntityLogicalName == null)
            {
                var ex = new InvalidOperationException("The Service reference and Parent Entity must be set before loading the Entities list");

                // raise the error event and if set, throw error
                OnNotificationMessage(ex.Message, MessageLevel.Exception, ex);

                if (throwException)
                {
                    throw ex;
                }
                return;
            }

            try
            {
                OnProgressChanged(0, "Begin loading Entity Attributes from CRM");

                OnBeginLoadData();
                ToggleMainControlsEnabled(false);

                // load the entity metadata for the current entity logical name
                var worker = new BackgroundWorker();

                worker.DoWork += (w, e) =>
                {
                    var parentEntity = CrmActions.RetrieveEntity(Service, ParentEntityLogicalName, true, new List<EntityFilters> { EntityFilters.Attributes });
                    e.Result = parentEntity;
                };

                worker.RunWorkerCompleted += (s, e) =>
                {
                    // set the parent entity reference with the loaded attributes
                    _parentEntity = e.Result as EntityMetadata;

                    // set the base control list of all items to populate the list view
                    SetAllItems<AttributeMetadata>(ParentEntity.Attributes.ToList<AttributeMetadata>());
                    ToggleMainControlsEnabled(AllAttributes.Count > 0);

                    OnProgressChanged(100, "Loading Entity Attributes from CRM complete!");

                    base.LoadData();
                };

                // kick off the worker thread!
                worker.RunWorkerAsync();
            }
            catch (System.ServiceModel.FaultException ex)
            {
                OnNotificationMessage($"An error occured attetmpting to load the list of Entity Attributes", MessageLevel.Exception, ex);

                if (throwException) {
                    throw ex;
                }
            }
        }
    }
}
