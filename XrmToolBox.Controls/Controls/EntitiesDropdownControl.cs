using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;

namespace xrmtb.XrmToolBox.Controls
{
    /// <summary>
    /// Shared XrmToolBox Control that will load a list of entities into a Dropdown control
    /// </summary>
    public partial class EntitiesDropdownControl : XrmToolBoxControlBase
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public EntitiesDropdownControl()
        {
            InitializeComponent();
        }

        #region Private properties
        private bool _autoLoadData = false;

        #endregion

        #region Public Properties
        /// <summary>
        /// Defines which Entity types should be loaded on retrieve.
        /// </summary>
        [Category("XrmToolBox")]
        [DisplayName("Solution Filter")]
        [Description("Specifies a Solution Unique Name filter to be used when retrieving Entities.")]
        public string SolutionFilter { get; set; }

        /// <summary>
        /// The currently selected EntityMetadata object in the ListView
        /// </summary>
        [DisplayName("Selected Entity")]
        [Description("The Entity that is currently selected in the Dropdown.")]
        [Category("XrmToolBox")]
        [Browsable(false)]
        public EntityMetadata SelectedEntity { get; private set; } = null;

        /// <summary>
        /// List of all loaded EntityMetadata objects for the current connection
        /// </summary>
        [Description("List of all Entities that have been loaded into the Dropdown.")]
        [Category("XrmToolBox")]
        [Browsable(false)]
        public List<EntityMetadata> AllEntities { get; private set; } = null;

        /// <summary>
        /// Reference to all Entities as a bindable list
        /// </summary>
        [Category("XrmToolBox")]
        [Description("Reference to all Entities as a bindable list")]
        [Browsable(false)]
        public List<ListDisplayItem> AllEntitiesBindable { get => comboEntities.DataSource as List<ListDisplayItem>; }
        #endregion

        #region Event Definitions
        /// <summary>
        /// Event that fires when the Selected Item changes
        /// </summary>
        [Category("XrmToolBox")]
        [Description("Event that fires when the Selected Item in the Dropdown changes")]
        public event EventHandler SelectedItemChanged;
        #endregion

        #region Public properties
        #endregion

        #region IXrmToolBoxControl methods
        /// <summary>
        /// Clear all loaded data in your control
        /// </summary>
        public override void ClearData()
        {
            OnBeginClearData();

            if (SelectedEntity != null)
            {
                SelectedEntity = null;
                SelectedItemChanged?.Invoke(this, new EventArgs());
            }

            AllEntities?.Clear();
            AllEntities = new List<EntityMetadata>();

            comboEntities.DataSource = null;
            comboEntities.Items.Clear();

            base.ClearData();
        }

        /// <summary>
        /// Load the Entities using the current IOrganizationService.
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
        private void LoadData(bool throwException)
        {
            OnBeginLoadData();

            if (Service == null)
            {
                var ex = new InvalidOperationException("The Service reference must be set before loading the Entities list");

                // raise the error event and if set, throw error
                OnNotificationMessage(ex.Message, MessageLevel.Exception, ex);

                if (throwException)
                {
                    throw ex;
                }
                return;
            }

            ToggleMainControlsEnabled(false);

            ClearData();

            try
            {
                OnProgressChanged(0, "Begin loading Entities from CRM");

                // retrieve all entities and bind to the combo
                // var entities = CrmActions.RetrieveAllEntities(Service);
                var worker = new BackgroundWorker();

                worker.DoWork += (w, e) => {

                    var entities = new List<EntityMetadata>();
                    if (SolutionFilter != null)
                    {
                        entities = CrmActions.RetrieveEntitiesForSolution(Service, SolutionFilter);
                    }
                    else
                    {
                        entities = CrmActions.RetrieveAllEntities(Service);
                    }

                    e.Result = entities;
                };

                worker.RunWorkerCompleted += (s, e) =>
                {
                    var entities = e.Result as List<EntityMetadata>;

                    AllEntities = entities;

                    LoadComboItems();

                    OnProgressChanged(100, "Loading Entities from CRM Complete!");

                    base.LoadData();
                };

                // kick off the worker thread!
                worker.RunWorkerAsync();
            }
            catch (System.ServiceModel.FaultException ex)
            {
                OnNotificationMessage($"An error occured attetmpting to load the list of Entities", MessageLevel.Exception, ex);

                if (throwException) {
                    throw ex;
                }
            }
        }
        #endregion

        #region Private helper methods
        /// <summary>
        /// Load the list of Entities into the Combo control
        /// </summary>
        private void LoadComboItems()
        {
            comboEntities.SuspendLayout();

            comboEntities.DataSource = null;

            var items = from ent in AllEntities
                        select new ListDisplayItem(
                            ent.SchemaName, 
                            CrmActions.GetLocalizedLabel(ent.DisplayName, ent.SchemaName, LanguageCode),
                            CrmActions.GetLocalizedLabel(ent.Description, null, LanguageCode), 
                            ent);

            comboEntities.DataSource = items.OrderBy(e => e.Name).ToList();
            comboEntities.DisplayMember = "SummaryName";
            comboEntities.ValueMember = "Name";

            comboEntities.ResumeLayout();

            ToggleMainControlsEnabled(true);
        }

        #endregion

        #region Control event handlers

        private void ComboEntities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboEntities.SelectedItem is ListDisplayItem item)
            {
                // check to see if we want to raise the change event
                var ent = item.Object as EntityMetadata;
                if (ent.LogicalName == SelectedEntity?.LogicalName)
                {
                    return;
                }
                // new entity, set and raise the event
                SelectedEntity = ent;
            }
            else {
                SelectedEntity = null;
            }
            SelectedItemChanged?.Invoke(this, new EventArgs());
        }

        private void ButtonReload_Click(object sender, EventArgs e)
        {
            LoadData(false);
        }
        #endregion
    }
}
