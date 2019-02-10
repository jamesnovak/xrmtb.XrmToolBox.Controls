using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace xrmtb.XrmToolBox.Controls
{
    public partial class ViewsDropdownControl : XrmToolBoxControlBase
    {
        /// <summary>
        /// Constructor
        /// </summary>

        public ViewsDropdownControl()
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
        private List<Entity> _allViews;
        private bool _includePersonal;

        /// <summary>
        /// Flag indicating whether Personal views should be included in the list.
        /// </summary>
        [Category("XrmToolBox")]
        [Description("Flag indicating whether Personal views should be included in the list.")]
        public bool IncludePersonalViews
        {
            get { return _includePersonal; }
            set {
                _includePersonal = value;
            }
        }

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
        [Description("Reference to the Selected View in the list")]
        [Browsable(false)]
        public Entity SelectedView { get; private set; } = null;

        /// <summary>
        /// Reference to the currently selected Attribute
        /// </summary>
        [Category("XrmToolBox")]
        [Description("Reference to all Attributes in the list")]
        [Browsable(false)]
        public List<Entity> AllViews
        {
            get {
                if (_allViews == null)
                {
                    _allViews = new List<Entity>();
                }
                return _allViews;
            }
        }

        /// <summary>
        /// Reference to all Attributes as a bindable list
        /// </summary>
        [Category("XrmToolBox")]
        [Description("Reference to all Attributes as a bindable list")]
        [Browsable(false)]
        public List<ListDisplayItem> AllViewsBindable { get => ComboViews.DataSource as List<ListDisplayItem>; }

        #endregion

        /// <summary>
        /// Set a reference to the parent entity for the attributes
        /// </summary>
        /// <param name="entity"></param>
        private void SetParentEntity(EntityMetadata entity)
        {
            // already cleared or never initialized, nothing to do 
            if (_parentEntity == null && entity == null)
            {
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
                var ex = new InvalidOperationException("The Service reference and Parent Entity must be set before loading the Views");

                // raise the error event and if set, throw error
                OnNotificationMessage(ex.Message, MessageLevel.Exception, ex);

                if (throwException)
                {
                    throw ex;
                }
                return;
            }

            ToggleMainControlsEnabled(false);

            // clear out the data, but leave the parent entity ref 
            ClearData(false);

            try
            {
                OnProgressChanged(0, $"Begin loading Views for the Current Entity: {ParentEntityLogicalName}");

                // load the entity metadata for the current entity logical name
                var worker = new BackgroundWorker();

                worker.DoWork += (w, e) =>
                {
                    var views = CrmActions.RetrieveEntityViews(Service, ParentEntity.ObjectTypeCode.Value, IncludePersonalViews);
                    e.Result = views;
                };

                worker.RunWorkerCompleted += (s, e) =>
                {
                    // set the parent entity reference with the loaded attributes
                    _allViews = e.Result as List<Entity>;

                    LoadComboItems();

                    OnProgressChanged(100, "Loading Entity Views from CRM Complete!");

                    base.LoadData();
                };

                // kick off the worker thread!
                worker.RunWorkerAsync();
            }
            catch (System.ServiceModel.FaultException ex)
            {
                OnNotificationMessage($"An error occured attetmpting to load the list of Entity Views", MessageLevel.Exception, ex);

                if (throwException)
                {
                    throw ex;
                }
            }
        }

        /// <summary>
        /// Clear the data in the control
        /// </summary>
        public override void ClearData()
        {
            ClearData(true);
        }

        private void ClearData(bool clearParent)
        {

            OnBeginClearData();

            if (SelectedView != null)
            {
                SelectedView = null;
                SelectedItemChanged?.Invoke(this, new EventArgs());
            }

            if (clearParent)
            {
                _parentEntity = null;
            }
            ComboViews.DataSource = null;
            ComboViews.Items.Clear();

            base.ClearData();
        }

        /// <summary>
        /// Load the combo control with the list of attributes
        /// </summary>
        private void LoadComboItems()
        {
            ComboViews.SuspendLayout();

            ComboViews.DataSource = null;

            var items = from view in _allViews
                        select new ListDisplayItem(
                            view.Attributes.ContainsKey("userqueryid") ? $"{(string)view["name"]} (Personal)" : (string)view["name"],
                            null, 
                            (view.Attributes.ContainsKey("description")) ? (string)view["description"] : null,
                            view);

            ComboViews.DataSource = items.OrderBy(e => e.Name).ToList();
            ComboViews.DisplayMember = "SummaryName";
            ComboViews.ValueMember = "Name";

            ComboViews.ResumeLayout();

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
        private void ComboViews_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboViews.SelectedItem is ListDisplayItem item)
            {
                // check to see if we want to raise the change event
                var view = item.Object as Entity;
                if (view.Id == SelectedView?.Id)
                {
                    return;
                }
                // new view, set and raise the event
                SelectedView= view;
            }
            else
            {
                SelectedView = null;
            }

            SelectedItemChanged?.Invoke(this, new EventArgs());
        }
        #endregion
    }
}
