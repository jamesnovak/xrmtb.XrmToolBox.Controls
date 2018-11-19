using System;
using System.ComponentModel;
using System.Windows.Forms;

using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;

using McTools.Xrm.Connection;
using XrmToolBox.Extensibility;

namespace XrmToolBox.Controls
{
    public partial class ControlTesterPluginControl : PluginControlBase
    {
        public ControlTesterPluginControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// On Load of the plugin control, perform some initialization of the Controls 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPluginControl_Load(object sender, EventArgs args)
        {
            // initialize the user control with the connection and parent reference
            // EntitiesListControl.Initialize(this, Service);
            EntitiesListControl.Service = Service;

            EntitiesListControl.NotificationMessage += EntitiesListControl_NotificationMessage; ;

            // apply some Entity Filters.  Do not load entities from the futz_ publisher.
            EntitiesListControl.EntityFilters.Add(new FilterInfo()
            {
                FilterMatchType = EnumFilterMatchType.StartsWith,
                FilterString = "futz_"
            });

            EntitiesListControl.DisplayToolbar = true;

            // add the entity filter that will return Attribute metadata
            // EntitiesListControl.EntityRequestFilters.Add(EntityFilters.Attributes);

            // set up the properties detail
            SetPropertySelectedObject();
            entitiesDropdownControl1.Service = Service;
            attributeDropdownControl1.Service = Service;

            if (Service == null)
                return;

            // automatically load the data?
            //if (MessageBox.Show("Would you like to automatically load the Entities?", "Load Entities", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    EntitiesListControl.LoadData();

            //    //WorkAsync(new WorkAsyncInfo()
            //    //{
            //    //    AsyncArgument = null,
            //    //    Message = "Loading!",
            //    //    IsCancelable = true,
            //    //    MessageWidth = 340,
            //    //    MessageHeight = 150,
            //    //    Work = (w, e) =>
            //    //    {
            //    //        EntitiesListControl.LoadData();
            //    //    },
            //    //    ProgressChanged = e =>
            //    //    {
            //    //        // ProgressChanged?.Invoke(this, new ProgressChangedEventArgs(e.ProgressPercentage, e.UserState.ToString()));
            //    //    },
            //    //    PostWorkCallBack = e =>
            //    //    {
            //    //    }
            //    //});
            //}
        }

        private void EntitiesListControl_NotificationMessage(object sender, NotificationEventArgs e)
        {
            var msg = $"{e.Message}";

            if ((e.Exception != null))
            {
                msg += $": {e.Exception.Message}";
            }

            ShowErrorNotification(msg, null);
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        /// <summary>
        /// This event occurs when the plugin is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPluginControl_OnCloseTool(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);

            // ENTITIES LIST - update the connection 
            EntitiesListControl.UpdateConnection(newService);
            entitiesDropdownControl1.UpdateConnection(newService);
        }

        #region Child control event handlers
        private void EntitiesListControl1_CloseComplete(object sender, EventArgs e)
        {
            textBoxEventLog.Text += string.Format($"CloseComplete") + Environment.NewLine;
        }
        private void EntitiesListControl1_InitializeComplete(object sender, EventArgs e)
        {
            // ENTITIES LIST - log event
            textBoxEventLog.Text += string.Format($"InitializeComplete") + Environment.NewLine;
        }

        private void EntitiesListControl1_LoadDataComplete(object sender, EventArgs e)
        {
            // ENTITIES LIST - log event
            textBoxEventLog.Text += string.Format($"LoadDataComplete - All Entities count: {EntitiesListControl.AllEntities.Count }\n") + Environment.NewLine;

            // NOW THAT DATA IS LOADED, APPLY FILTER
            // EntitiesListControl.FilterEntitiesList("Account");
        }

        private void EntitiesListControl1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            textBoxEventLog.Text += string.Format($"{e.UserState} : {e.ProgressPercentage}") + Environment.NewLine;
        }

        private void EntitiesListControl1_CheckedItemsChanged(object sender, EventArgs e)
        {
            textBoxEventLog.Text += string.Format($"CheckedItemsChanged - Checked Entities count: {EntitiesListControl.CheckedEntities.Count}") + Environment.NewLine;
        }
        private void EntitiesListControl1_SelectedItemChanged(object sender, EventArgs e)
        {
            var ent = EntitiesListControl.SelectedEntity;
            // ENTITIES LIST - log event
            textBoxEventLog.Text += string.Format($"SelectedItemChanged: {ent?.SchemaName}") + Environment.NewLine;

            SetPropertySelectedObject();

            this.attributeDropdownControl1.ParentEntityLogicalName = ent.LogicalName;
        }
        private void EntitiesListControl1_ClearDataComplete(object sender, EventArgs e)
        {
            // ENTITIES LIST - log event
            SetPropertySelectedObject();
            textBoxEventLog.Text += string.Format($"ClearDataComplete - All Entities count: {EntitiesListControl.AllEntities.Count}") + Environment.NewLine;
        }
        #endregion

        private void SetPropertySelectedObject()
        {
            if (radioButtonShowEntList.Checked)
            {
                propertyGridDetails.SelectedObject = EntitiesListControl;
            }
            else
            {
                var entRef = EntitiesListControl.SelectedEntity as EntityMetadata;
                propertyGridDetails.SelectedObject = entRef;
            }
        }

        private void radioButtonShowEntList_CheckedChanged(object sender, EventArgs e)
        {
            SetPropertySelectedObject();
        }

        private void radioButtonShowEntity_CheckedChanged(object sender, EventArgs e)
        {
            SetPropertySelectedObject();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            EntitiesListControl.LoadData();
        }

        private void EntitiesListControl_BeginLoadData(object sender, EventArgs e)
        {
            if (this.textBoxEventLog.InvokeRequired)
            {
            }
            else {
                textBoxEventLog.Clear();
            }
        }
    }
}