using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Microsoft.Xrm.Sdk.Metadata;

namespace xrmtb.XrmToolBox.Controls
{
    public partial class GlobalOptionSetListControl : FilteredListViewBaseControl
    {
        public GlobalOptionSetListControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Flag indicating whether to retrieve the metadata that has not been published
        /// </summary>
        [Category("XrmToolBox")]
        [DisplayName("Retrieve As If Published")]
        [Description("Flag indicating whether to retrieve the metadata that has not been published")]
        public bool RetrieveAsIfPublished { get; set; }

        #region Runtime Properties
        /// <summary>
        /// List of all checked OptionSetMetadataBase objects in the ListView
        /// </summary>
        [Category("XrmToolBox")]
        [DisplayName("Checked Global OptionSet List")]
        [Description("List of all Global OptionSets that are checked in the control.")]
        [Browsable(false)]
        public List<OptionSetMetadataBase> CheckedOptionSets { get => CheckedItems?.Select(i => i as OptionSetMetadataBase).ToList<OptionSetMetadataBase>(); }

        /// <summary>
        /// The currently selected OptionSetMetadataBase object in the ListView
        /// </summary>
        [Category("XrmToolBox")]
        [DisplayName("Selected Global OptionSet")]
        [Description("The Global OptionSet that is currently selected the control.")]
        [Browsable(false)]
        public OptionSetMetadataBase SelectedOptionSet { get => SelectedItem as OptionSetMetadataBase; }

        /// <summary>
        /// List of all loaded OptionSetMetadataBase objects for the current connection
        /// </summary>
        [Category("XrmToolBox")]
        [DisplayName("All Global OptionSets List")]
        [Description("List of all Global OptionSets that have been loaded.")]
        [Browsable(false)]
        public List<OptionSetMetadataBase> AllOptionSets
        {
            get => AllItems?.ConvertAll<OptionSetMetadataBase>(new Converter<object, OptionSetMetadataBase>((item) => { return item as OptionSetMetadataBase; }));
        }

        /// <summary>
        /// Set up the ListViewColumnDef defaults
        /// </summary>
        protected override void ResetListViewColDefs()
        {
            // default the col defs for the 
            ListViewColDefs = new ListViewColumnDef[] {
                new ListViewColumnDef( "DisplayName", 1, "Display Name") { Width = 250 },
                new ListViewColumnDef( "Name", 2, "Name") { IsFilterColumn = false },
                new ListViewColumnDef( "OptionSetType", 3, "OptionSet Type") { Width = 150 },
                new ListViewColumnDef( "IsManaged", 4, "Managed State") { IsGroupColumn = true },
                new ListViewColumnDef( "Description", 5) { Width = 250 }
            };
        }

        #endregion

        #region Public methods

        #region IXrmToolBoxControl methods
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
            if (Service == null)
            {
                var ex = new InvalidOperationException("The Service reference must be set before loading the Global OptionSet list");

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
                OnProgressChanged(0, "Loading Global OptionSets");

                OnBeginLoadData();

                ToggleMainControlsEnabled(false);

                // first clear out all data currently loaded
                this.ClearData();

                var worker = new BackgroundWorker();

                worker.DoWork += (w, e) => {

                    var optionSets = CrmActions.RetrieveGlobalOptionSets(Service, RetrieveAsIfPublished);
                    
                    e.Result = optionSets;
                };

                worker.RunWorkerCompleted += (s, e) =>
                {
                    var allEntities = e.Result as List<OptionSetMetadataBase>;

                    OnProgressChanged(99, $"{allEntities.Count} Global OptionSets loaded");

                    // now that the entities are loaded, populate the list view.
                    SetAllItems<OptionSetMetadataBase>(allEntities);

                    ToggleMainControlsEnabled();

                    OnProgressChanged(100, "Loading Global OptionSets Complete!");

                    base.LoadData();
                };

                // kick off the worker thread!
                worker.RunWorkerAsync();
            }
            catch (System.ServiceModel.FaultException ex)
            {
                OnNotificationMessage($"An error occured attetmpting to load the list of Global OptionSets", MessageLevel.Exception, ex);

                if (throwException)
                {
                    throw ex;
                }
            }
        }
        #endregion
        #endregion
    }
}
