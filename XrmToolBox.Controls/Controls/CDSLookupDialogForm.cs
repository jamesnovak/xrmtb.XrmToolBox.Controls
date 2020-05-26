using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Extensions;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Windows.Forms;
using System.Xml;
using xrmtb.XrmToolBox.Controls.Helper;

namespace xrmtb.XrmToolBox.Controls.Controls
{
    public partial class CDSLookupDialogForm : Form
    {
        #region Private Fields

        private Dictionary<string, List<Entity>> entityviews;
        private IOrganizationService service;

        #endregion Private Fields

        #region Public Constructors

        public CDSLookupDialogForm(IOrganizationService service, string[] logicalNames, bool multiSelect, bool friendlyNames, string title)
        {
            InitializeComponent();
            SetMulti(multiSelect);
            gridResults.ShowFriendlyNames = friendlyNames;
            gridSelection.ShowFriendlyNames = friendlyNames;
            Text = title;
            SetService(service);
            SetLogicalNames(logicalNames);
        }

        #endregion Public Constructors

        #region Internal Properties

        internal IOrganizationService Service
        {
            get => service;
            set
            {
                service = value;
                cmbView.OrganizationService = value;
                gridResults.OrganizationService = value;
                gridSelection.OrganizationService = value;
            }
        }

        #endregion Internal Properties

        #region Internal Methods

        internal Entity[] GetSelectedRecords()
        {
            if (gridResults.MultiSelect)
            {
                if (gridSelection.GetDataSource<IEnumerable<Entity>>() is IEnumerable<Entity> current)
                {
                    return current.ToArray();
                }
                return new Entity[] { };
            }
            else
            {
                return gridResults.SelectedCellRecords?.Take(1).ToArray();
            }
        }

        #endregion Internal Methods

        #region Private Methods

        private void LoadData()
        {
            if (cmbView.SelectedEntity is Entity view)
            {
                txtFilter.Enabled = view.GetAttributeValue<int>(Savedquery.QueryType) == 4;
                if (!txtFilter.Enabled && !string.IsNullOrWhiteSpace(txtFilter.Text))
                {
                    txtFilter.Text = string.Empty;
                }
                if (!(cmbEntity.SelectedItem is EntityMetadataProxy entity))
                {
                    gridResults.DataSource = null;
                    return;
                }
                gridResults.DataSource = service.ExecuteQuickFind(entity.Metadata.LogicalName, view, txtFilter.Text);
                var layout = new XmlDocument();
                layout.LoadXml(view["layoutxml"].ToString());
                gridResults.ColumnOrder = String.Join(",", layout.SelectNodes("//cell/@name").OfType<XmlAttribute>().Select(a => a.Value));
                gridResults.ShowAllColumnsInColumnOrder = true;
                gridResults.ShowColumnsNotInColumnOrder = false;
                gridSelection.ColumnOrder = gridResults.ColumnOrder;
                gridSelection.ShowAllColumnsInColumnOrder = true;
                gridSelection.ShowColumnsNotInColumnOrder = false;
            }
        }

        private void SetLogicalNames(string[] logicalNames)
        {
            cmbEntity.Items.Clear();
            if (logicalNames != null)
            {
                cmbEntity.Items.AddRange(logicalNames
                    .Where(l => !string.IsNullOrWhiteSpace(l))
                    .Select(l => service.GetEntity(l))
                    .Where(m => m != null)
                    .Select(m => new EntityMetadataProxy(m))
                    .ToArray());
            }
            cmbEntity.SelectedIndex = cmbEntity.Items.Count > 0 ? 0 : -1;
            cmbEntity.Enabled = cmbEntity.Items.Count > 1;
        }

        private void SetMulti(bool multiSelect)
        {
            splitGrids.Panel2Collapsed = !multiSelect;
            gridResults.MultiSelect = multiSelect;
        }

        private void SetService(IOrganizationService service)
        {
            Service = service;
            entityviews = new Dictionary<string, List<Entity>>();
        }

        private void SetViews(EntityMetadataProxy entity)
        {
            if (entity == null)
            {
                cmbView.DataSource = null;
                return;
            }
            var logicalname = entity.Metadata.LogicalName;
            if (!entityviews.ContainsKey(logicalname))
            {
                var views = new List<Entity>();
                if (service.RetrieveViews(logicalname, true) is EntityCollection qfviews)
                {
                    views.AddRange(qfviews.Entities);
                }
                if (service.RetrieveViews(logicalname, false) is EntityCollection otherviews)
                {
                    views.AddRange(otherviews.Entities);
                }
                entityviews.Add(logicalname, views);
            }
            if (entityviews.ContainsKey(logicalname))
            {
                cmbView.DataSource = entityviews[logicalname];
            }
        }

        #endregion Private Methods

        #region Private Event Handlers

        private void btnAddSelection_Click(object sender, EventArgs e)
        {
            if (gridResults.SelectedRowRecords is IEnumerable<Entity> selected)
            {
                var current = GetSelectedRecords().ToList();
                current.AddRange(selected);
                gridSelection.DataSource = current.Distinct();
            }
        }

        private void btnClearSelection_Click(object sender, EventArgs e)
        {
            gridSelection.DataSource = null;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnRemoveSelection_Click(object sender, EventArgs e)
        {
            if (gridSelection.SelectedRowRecords is IEnumerable<Entity> selected)
            {
                var current = GetSelectedRecords().ToList();
                selected.ToList().ForEach(s => current.Remove(s));
                gridSelection.DataSource = current;
            }
        }

        private void cmbEntity_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetViews(cmbEntity.SelectedItem as EntityMetadataProxy);
        }

        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gridResults_SelectionChanged(object sender, EventArgs e)
        {
            btnAddSelection.Enabled = gridResults.SelectedRowRecords?.Count() > 0;
        }

        private void gridSelection_DataSourceChanged(object sender, EventArgs e)
        {
            btnClearSelection.Enabled = gridSelection.Rows.Count > 0;
        }

        private void gridResults_RecordDoubleClick(object sender, CRMRecordEventArgs e)
        {
            if (gridResults.MultiSelect)
            {
                btnAddSelection_Click(sender, e);
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void gridSelection_SelectionChanged(object sender, EventArgs e)
        {
            btnRemoveSelection.Enabled = gridSelection.SelectedRowRecords?.Count() > 0;
        }

        private void txtFilter_Enter(object sender, EventArgs e)
        {
            AcceptButton = btnFilter;
        }

        private void txtFilter_Leave(object sender, EventArgs e)
        {
            AcceptButton = btnOk;
        }

        #endregion Private Event Handlers
    }
}