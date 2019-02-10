using Microsoft.Xrm.Sdk;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace xrmtb.XrmToolBox.Controls
{
    /// <summary>
    /// Helper base class for XrmToolBox Controls
    /// </summary>
    public partial class XrmToolBoxControlBase : UserControl, IXrmToolBoxControl
    {
        private IOrganizationService _service = null;

        /// <summary>
        /// Constructor
        /// </summary>
        public XrmToolBoxControlBase()
        {
            InitializeComponent();
        }

        #region IXrmToolBoxControl Properties
        /// <summary>
        /// Reference to the IOrganizationService object
        /// </summary>
        [Category("XrmToolBox")]
        [DisplayName("Organization Service")]
        [Description("Reference to the IOrganizationService object.")]
        [Browsable(false)]
        public IOrganizationService Service { get => _service; set => UpdateConnection(value); }

        /// <summary>
        /// Language code to be used when displaying labels or other strings from CRM
        /// </summary>
        [Category("XrmToolBox")]
        [DisplayName("Language Code")]
        [Description("Language code for this control.")]
        public int LanguageCode { get; set; } = 1033;

        /// <summary>
        /// Flag indicating whether to automatically load data when the Service connection is set or updated.
        /// </summary>
        [Category("XrmToolBox")]
        [DisplayName("Automatically Load Data")]
        [Description("Flag indicating whether to automatically load data when the Service connection is set or updated.")]
        public bool AutoLoadData { get; set; }
        #endregion

        #region IXrmToolBoxControl Event Definitions
        /// <summary>
        /// Event fired when the progress changes for an async event 
        /// </summary>
        [Category("XrmToolBox")]
        [Description("Event fired when the progress changes for an async event")]
        public event EventHandler<ProgressChangedEventArgs> ProgressChanged;

        /// <summary>
        /// Event that fires when the LoadData method begins
        /// </summary>
        [Category("XrmToolBox")]
        [Description("Event that fires when the LoadData method begins")]
        public virtual event EventHandler BeginLoadData;

        /// <summary>
        /// Event that fires when <see cref="LoadData"/>() completes
        /// </summary>
        [Category("XrmToolBox")]
        [Description("Event that fires when LoadData() completes")]
        public event EventHandler LoadDataComplete;

        /// <summary>
        /// Event that fires when ClearData() starts
        /// </summary>
        [Category("XrmToolBox")]
        [Description("Event that fires when ClearData() begins for the Dropdown")]
        public event EventHandler BeginClearData;

        /// <summary>
        /// Event that fires when ClearData() completes
        /// </summary>
        [Category("XrmToolBox")]
        [Description("Event that fires when ClearData() completes")]
        public event EventHandler ClearDataComplete;

        /// <summary>
        /// Event that fires when Close() begins
        /// </summary>
        [Category("XrmToolBox")]
        [Description("Event that fires when Close() begins")]
        public event EventHandler BeginClose;

        /// <summary>
        /// Event that fires when Close() completes
        /// </summary>
        [Category("XrmToolBox")]
        [Description("Event that fires when Close() completes")]
        public event EventHandler CloseComplete;

        /// <summary>
        /// A Notificaiton Has been raised
        /// </summary>
        [Category("XrmToolBox")]
        [Description("Event that fires when a Notification is raised")]
        public virtual event EventHandler<NotificationEventArgs> NotificationMessage;

        /// <summary>
        /// Raises the ProgressChanged event to all listeners
        /// </summary>
        /// <param name="progressPercent">Progress percentage</param>
        /// <param name="message">Additional message with progress</param>
        protected void OnProgressChanged(int progressPercent, string message)
        {
            // if (this.InvokeRequired)  return;
            ProgressChanged?.Invoke(this, new ProgressChangedEventArgs(progressPercent, message));
        }

        /// <summary>
        /// Fires the NotificationMessgae event to all listeners
        /// </summary>
        /// <param name="message">Text message for client</param>
        /// <param name="level">MessageLevel for this event</param>
        /// <param name="ex">Optional Exception object</param>
        protected void OnNotificationMessage(string message, MessageLevel level, Exception ex = null)
        {
            // if (this.InvokeRequired) return;
            NotificationMessage?.Invoke(this, new NotificationEventArgs(message, level, ex));
        }

        /// <summary>
        /// Fires the BeginLoadData event to all listeners
        /// </summary>
        protected void OnBeginLoadData() {
            // if (this.InvokeRequired) return;
            BeginLoadData?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// Fires the LoadDataComplete event for all listeners
        /// </summary>
        protected void OnLoadDataComplete() {
            // if (this.InvokeRequired) return;
            LoadDataComplete?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// Fires the BeginClearData event to all listeners
        /// </summary>
        protected void OnBeginClearData() {
            // if (this.InvokeRequired) return;
            BeginClearData?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// Fires the ClearDataComplete event to all listeners
        /// </summary>
        protected void OnClearDataComplete() {
            // if (this.InvokeRequired) return;
            ClearDataComplete?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// Fires the BeginClose event to all listeners
        /// </summary>
        protected void OnBeginClose() {
            // if (this.InvokeRequired) return;
            BeginClose?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// Fires the CloseComplete event to all listeners
        /// </summary>
        protected void OnCloseComplete() {
            // if (this.InvokeRequired) return;
            CloseComplete?.Invoke(this, new EventArgs());
        }
        #endregion

        #region IXrmToolBoxControl Methods Definitions

        /// <summary>
        /// 
        /// </summary>
        public virtual void ClearData()
        {
            OnClearDataComplete();
        }

        /// <summary>
        /// Close has been called
        /// </summary>
        public virtual void Close()
        {
            OnBeginClose();

            _service = null;

            // use this. to ensure that any overrides are called
            this.ClearData();

            ToggleMainControlsEnabled();

            OnCloseComplete();
        }

        /// <summary>
        /// Load the data relevant to the control
        /// </summary>
        public virtual void LoadData()
        {
            OnLoadDataComplete();
        }
        /// <summary>
        /// Handle the updated connection 
        /// </summary>
        /// <param name="newService">Reference to the new IOrganizationService</param>
        public virtual void UpdateConnection(IOrganizationService newService)
        {
            _service = newService;
            
            // if the service had previously been set, then clear things out
            if (Service != null)
            {
                ClearData();
            }

            // toggle main controls based on the state of the new service 
            this.ToggleMainControlsEnabled();

            // if the auto load is set, now is the time to reload!
            if (AutoLoadData && (Service != null))
            {
                LoadData();
            }

            ToggleMainControlsEnabled();
        }
        #endregion

        #region Helper methods 

        /// <summary>
        /// Helper method for toggling main UI controls enabled based on Service ref and base Enabled state
        /// </summary>
        protected virtual void ToggleMainControlsEnabled()
        {
            var enabled = (Enabled) ? Service != null : Enabled;

            ToggleMainControlsEnabled(enabled);
        }

        /// <summary>
        /// Toggle the main controls enabled
        /// </summary>
        /// <param name="enabled"></param>
        protected virtual void ToggleMainControlsEnabled(bool enabled)
        {
            foreach (Control control in Controls)
            {
                control.Enabled = enabled;
            }
        }
        /// <summary>
        /// Event handler for base control Enalbed state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void XrmToolBoxControlBase_EnabledChanged(object sender, EventArgs e)
        {
            ToggleMainControlsEnabled();
        }

        #endregion
    }
}
