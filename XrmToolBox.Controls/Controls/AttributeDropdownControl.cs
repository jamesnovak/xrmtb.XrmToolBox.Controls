using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;

using Microsoft.Xrm.Sdk.Metadata;

namespace XrmToolBox.Controls
{
    public partial class AttributeDropdownControl : XrmToolBoxControlBase
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public AttributeDropdownControl()
        {
            InitializeComponent();

            ToggleMainControlsEnabled(false);
        }

        #region Event definitions
        /// <summary>
        /// Event that fires when the Selected Item changes
        /// </summary>
        [Category("XrmToolBox")]
        [Description("Event that fires when the Selected Item changes")]
        public event EventHandler SelectedItemChanged;
        #endregion

        #region Properties
        private EntityMetadata _parentEntity;

        /// <summary>
        /// Reference to the Parent Entity for the attributes
        /// </summary>
        [Category("XrmToolBox")]
        [Description("Reference to the Parent Entity for the attributes to be loaded")]
        [Browsable(false)]
        public EntityMetadata ParentEntity { get => _parentEntity; set => SetParentEntity(value); }

        /// <summary>
        /// The Entity Logical Name for the Parent Entity
        /// </summary>
        [Category("XrmToolBox")]
        [Description("Parent Entity LogicalName for the attributes to be loaded")]
        [Browsable(false)]
        public string ParentEntityLogicalName { get => _parentEntity?.LogicalName; set => SetParentEntity(value); }

        /// <summary>
        /// Reference to the currently selected Attribute
        /// </summary>
        [Category("XrmToolBox")]
        [Description("Reference to the Selected Attributes in the list")]
        [Browsable(false)]
        public AttributeMetadata SelectedAttribute { get; private set; } = null;

        /// <summary>
        /// Reference to the currently selected Attribute
        /// </summary>
        [Category("XrmToolBox")]
        [Description("Reference to all Attributes in the list")]
        [Browsable(false)]
        public List<AttributeMetadata> AllAttributes
        {
            get {
                var list = ParentEntity?.Attributes?.ToList<AttributeMetadata>();
                if (list == null) {
                    list = new List<AttributeMetadata>();
                }
                return list;
            }
        }

        /// <summary>
        /// Reference to all Attributes as a bindable list
        /// </summary>
        [Category("XrmToolBox")]
        [Description("Reference to all Attributes as a bindable list")]
        [Browsable(false)]
        public List<ListDisplayItem> AllAttributesBindable { get => comboAttributes.DataSource as List<ListDisplayItem>; }

        #endregion

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
            else if (_parentEntity?.LogicalName.ToLower() == entity?.LogicalName.ToLower())
            {
                return;
            }

            // now update the parent entity reference
            _parentEntity = entity;

            // if the parent entity is null
            if (ParentEntity == null) {

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
        /// Set 
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
                _parentEntity = new EntityMetadata()
                {
                    LogicalName = entityLogicalName
                };

                // set up the entity and then load
                LoadData(false);
            }
        }

        /// <summary>
        /// Load the list of Attributes
        /// </summary>
        public override void LoadData()
        {
            // this is for developers!  If LoadData is called from within WorkAsync, the controls will be 
            // inaccessible because of the worker thread
            if (this.InvokeRequired)
                throw new InvalidOperationException("This method cannot be invoked from WorkAsync");

            LoadData(false);
        }

        private void LoadData(bool throwException)
        {
            OnBeginLoadData();

            if (Service == null || ParentEntityLogicalName == null)
            {
                var ex = new InvalidOperationException("The Service reference and Parent Entity must be set before loading the Entities list");

                // raise the error event and if set, throw error
                OnNotificationMessage(ex.Message, MessageLevel.Exception, ex);

                if (throwException) {
                    throw ex;
                }
                return;
            }

            ToggleMainControlsEnabled(false);

            ClearData();

            try
            {
                OnProgressChanged(0, "Begin loading Entity Attributes from CRM");

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

                    LoadComboItems();

                    OnProgressChanged(100, "Loading Entity Attributes from CRM Complete!");

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

        /// <summary>
        /// Clear the data in the control
        /// </summary>
        public override void ClearData()
        {
            OnBeginClearData();

            if (SelectedAttribute != null)
            {
                SelectedAttribute = null;
                SelectedItemChanged?.Invoke(this, new EventArgs());
            }

            comboAttributes.DataSource = null;
            comboAttributes.Items.Clear();

            base.ClearData();
        }

        /// <summary>
        /// Load the combo control with the list of attributes
        /// </summary>
        private void LoadComboItems()
        {
            comboAttributes.SuspendLayout();

            ClearData();

            var items = from attrib in ParentEntity.Attributes
                        where attrib.AttributeType != AttributeTypeCode.Virtual &&
                              attrib.AttributeOf == null
                        select new ListDisplayItem(
                            attrib.SchemaName,
                            CrmActions.GetLocalizedLabel(attrib.DisplayName, attrib.SchemaName, LanguageCode), 
                            CrmActions.GetLocalizedLabel(attrib.Description, null, LanguageCode), 
                            attrib);

            comboAttributes.DataSource = items.OrderBy(e => e.Name).ToList();
            comboAttributes.ValueMember = "SummaryName";
            comboAttributes.ValueMember = "Name";

            //if (comboAttributes.Items.Count > 0)
            //{
            //    comboAttributes.SelectedIndex = 0;
            //}

            comboAttributes.ResumeLayout();

            ToggleMainControlsEnabled(true);
        }

        #region UI Event Handlers

        /// <summary>
        /// Reload the list of entities
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonReload_Click(object sender, EventArgs e)
        {
            LoadData(false);
        }

        /// <summary>
        /// Selected index changed, update any listeners!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboAttributes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboAttributes.SelectedItem is ListDisplayItem item)
            {
                // check to see if we want to raise the change event
                var attrib = item.Object as AttributeMetadata;
                if (attrib.LogicalName == SelectedAttribute?.LogicalName)
                {
                    return;
                }
                // new attribute, set and raise the event
                SelectedAttribute = attrib;
            }
            else {
                SelectedAttribute = null;
            }

            SelectedItemChanged?.Invoke(this, new EventArgs());
        }
        #endregion
    }
}
