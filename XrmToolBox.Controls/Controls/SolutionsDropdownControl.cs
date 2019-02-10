using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Xrm.Sdk;

namespace xrmtb.XrmToolBox.Controls
{
    public partial class SolutionsDropdownControl : XrmToolBoxControlBase
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public SolutionsDropdownControl()
        {
            InitializeComponent();
        }

        private List<string> _publisherPrefixes = new List<string>();

        /// <summary>
        /// Reference to the Parent Entity for the attributes
        /// </summary>
        [Category("XrmToolBox")]
        [DisplayName("Publisher Prefix Filters")]
        [Description("Load solutoins for only the Publisher Prefixes provided in the list")]
        public List<string> PublisherPrefixes { get => _publisherPrefixes; }


        /// <summary>
        /// The currently selected Solution object in the ListView
        /// </summary>
        [DisplayName("Selected Solution")]
        [Description("The Solution that is currently selected in the Dropdown.")]
        [Category("XrmToolBox")]
        [Browsable(false)]
        public Entity SelectedSolution { get; private set; } = null;

        /// <summary>
        /// List of all loaded EntityMetadata objects for the current connection
        /// </summary>
        [Description("List of all Solutions that have been loaded into the Dropdown.")]
        [Category("XrmToolBox")]
        [Browsable(false)]
        public List<Entity> AllSolutions { get; private set; } = null;

        /// <summary>
        /// Reference to all Attributes as a bindable list
        /// </summary>
        [Category("XrmToolBox")]
        [Description("Reference to all Solutions as a bindable list")]
        [Browsable(false)]
        public List<ListDisplayItem> AllSolutionsBindable { get => comboSolutions.DataSource as List<ListDisplayItem>; }

        #region Event Definitions
        /// <summary>
        /// Event that fires when the Selected Item changes
        /// </summary>
        [Category("XrmToolBox")]
        [Description("Event that fires when the Selected Item in the Dropdown changes")]
        public event EventHandler SelectedItemChanged;
        #endregion

        #region IXrmToolBoxControl methods
        /// <summary>
        /// Clear all loaded data in your control
        /// </summary>
        public override void ClearData()
        {
            OnBeginClearData();

            if (SelectedSolution != null)
            {
                SelectedSolution = null;
                SelectedItemChanged?.Invoke(this, new EventArgs());
            }
            
            AllSolutions?.Clear();
            AllSolutions = new List<Entity>();

            comboSolutions.DataSource = null;
            comboSolutions.Items.Clear();

            base.ClearData();
        }

        /// <summary>
        /// Load data into the control
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
                OnProgressChanged(0, "Begin loading Solutions from CRM");

                // retrieve all entities and bind to the combo
                var worker = new BackgroundWorker();

                worker.DoWork += (w, e) => {
                    var entities = CrmActions.RetrieveSolutions(Service, PublisherPrefixes);
                    e.Result = entities;
                };

                worker.RunWorkerCompleted += (s, e) =>
                {
                    var entities = e.Result as List<Entity>;

                    AllSolutions = entities;

                    LoadComboItems();

                    OnProgressChanged(100, "Loading Solutions from CRM Complete!");

                    base.LoadData();
                };

                // kick off the worker thread!
                worker.RunWorkerAsync();
            }
            catch (System.ServiceModel.FaultException ex)
            {
                OnNotificationMessage($"An error occured attetmpting to load the list of Entities", MessageLevel.Exception, ex);

                if (throwException)
                {
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
            comboSolutions.SuspendLayout();

            comboSolutions.DataSource = null;

            var items = from ent in AllSolutions
                        select 
                        new ListDisplayItem( 
                            (string)ent["uniquename"], 
                            (string)ent["friendlyname"], 
                            (ent.Attributes.ContainsKey("description")) ? (string)ent["description"] : "", 
                            ent);

            comboSolutions.DataSource = items.OrderBy(e => e.Name).ToList();
            comboSolutions.DisplayMember = "SummaryName";
            comboSolutions.ValueMember = "Name";

            comboSolutions.ResumeLayout();

            ToggleMainControlsEnabled(true);
        }

        #endregion

        #region Control event handlers

        private void ComboSolutions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSolutions.SelectedItem is ListDisplayItem item)
            {
                // check to see if we want to raise the change event
                var ent = item.Object as Entity;
                if (ent.Id == SelectedSolution?.Id)
                {
                    return;
                }
                // new entity, set and raise the event
                SelectedSolution = ent;
            }
            else {
                SelectedSolution = null;
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
