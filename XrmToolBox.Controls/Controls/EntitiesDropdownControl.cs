using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;

namespace XrmToolBox.Controls
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
        [DisplayName("All Entities List")]
        [Description("List of all Entities that have been loaded into the Dropdown.")]
        [Category("XrmToolBox")]
        [Browsable(false)]
        public List<EntityMetadata> AllEntities { get; private set; } = null;

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

            comboEntities.DataSource = null;
            comboEntities.Items.Clear();

            base.ClearData();
        }

        /// <summary>
        /// Close the control and release anything that might be hanging around
        /// </summary>
        public override void Close()
        {
            OnBeginClose();

            ClearData();

            base.Close();
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
                    var entities = CrmActions.RetrieveAllEntities(Service);
                    e.Result = entities;
                };

                worker.RunWorkerCompleted += (s, e) =>
                {
                    var entities = e.Result as List<EntityMetadata>;

                    OnProgressChanged(0, "Loading Entities from CRM Complete!");

                    AllEntities = entities;

                    LoadComboItems();

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

        /// <summary>
        /// Handle the updated connection 
        /// </summary>
        /// <param name="newService">Reference to the new IOrganizationService</param>
        public override void UpdateConnection(IOrganizationService newService)
        {
            base.UpdateConnection(newService);

            // if the service had previously been set, then clear things out
            if (Service != null)
            {
                ClearData();
            }

            // if the auto load is set, now is the time to reload!
            if (_autoLoadData && (Service != null))
            {
                LoadData(true);
            }

            ToggleMainControlsEnabled();
        }
        #endregion

        #region Private helper methods
        /// <summary>
        /// Load the list of Entities into the Combo control
        /// </summary>
        private void LoadComboItems()
        {
            comboEntities.SuspendLayout();

            ClearData();

            var items = from ent in AllEntities
                        select new ListDisplayItem(
                            ent.SchemaName, 
                            CrmActions.GetLocalizedLabel(ent.DisplayName, ent.SchemaName, LanguageCode),
                            CrmActions.GetLocalizedLabel(ent.Description, null, LanguageCode), 
                            ent);

            comboEntities.DataSource = items.OrderBy(e => e.Name).ToList();
            comboEntities.DisplayMember = "SummaryName";
            comboEntities.ValueMember = "Name";

            if (comboEntities.Items.Count > 0)
            {
                comboEntities.SelectedIndex = 0;
            }

            comboEntities.ResumeLayout();

            ToggleMainControlsEnabled(true);
        }

        #endregion

        #region Control event handlers

        private void ComboEntities_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedEntity = null;

            if (comboEntities.SelectedItem is ListDisplayItem item)
            {
                SelectedEntity = item.Object as EntityMetadata;
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
