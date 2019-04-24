using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace MsCrmTools.AccessChecker.Forms
{
    public partial class LookupSingle : Form
    {
        private readonly string entityName;
        private readonly IOrganizationService service;
        private EntityMetadata metadata;

        public LookupSingle(string entityName, IOrganizationService service)
        {
            InitializeComponent();

            this.entityName = entityName;
            this.service = service;
        }

        public LookupSingle(EntityMetadata emd, IOrganizationService service) : this(emd.LogicalName, service)
        {
            metadata = emd;
        }

        public Guid SelectedRecordId { get; private set; }
        
        private void BtnCancelClick(object sender, EventArgs e)
        {
            SelectedRecordId = Guid.Empty;
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnOkClick(object sender, EventArgs e)
        {
            SelectedRecordId = (Guid)lvResults.SelectedItems[0].Tag;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ProcessFilter(XmlNode node, string searchTerm)
        {

            foreach (XmlNode condition in node.SelectNodes("condition"))
            {
                if (!condition.Attributes["value"].Value.StartsWith("{"))
                {
                    continue;
                }
                var attr = metadata.Attributes.First(a => a.LogicalName == condition.Attributes["attribute"].Value);

                #region Manage each attribute type

                switch (attr.AttributeType.Value)
                {
                    case AttributeTypeCode.Memo:
                    case AttributeTypeCode.String:
                    {
                        condition.Attributes["value"].Value = searchTerm.Replace("*", "%");
                    }
                        break;
                    case AttributeTypeCode.Boolean:
                    {
                        if (searchTerm != "0" && searchTerm != "1")
                        {
                                node.RemoveChild(condition);
                                continue;
                            }

                        condition.Attributes["value"].Value = (searchTerm == "1").ToString();
                    }
                        break;
                    case AttributeTypeCode.Customer:
                    case AttributeTypeCode.Lookup:
                    case AttributeTypeCode.Owner:
                    {
                        if (
                            metadata.Attributes.FirstOrDefault(
                                a => a.LogicalName == condition.Attributes["attribute"].Value + "name") == null)
                        {
                            node.RemoveChild(condition);

                            continue;
                        }
                        

                        condition.Attributes["attribute"].Value += "name";
                        condition.Attributes["value"].Value = searchTerm.Replace("*", "%");
                    }
                        break;
                    case AttributeTypeCode.DateTime:
                    {
                        DateTime dt;
                        if (!DateTime.TryParse(searchTerm, out dt))
                        {
                            condition.Attributes["value"].Value = new DateTime(1754,1,1).ToString("yyyy-MM-dd");
                        }
                        else
                        {
                            condition.Attributes["value"].Value = dt.ToString("yyyy-MM-dd");
                        }
                    }
                        break;
                        case AttributeTypeCode.Decimal:
                        case AttributeTypeCode.Double:
                        case AttributeTypeCode.Money:
                    {
                            decimal d;
                            if (!decimal.TryParse(searchTerm, out d))
                            {
                                condition.Attributes["value"].Value = int.MinValue.ToString(CultureInfo.InvariantCulture);
                            }
                            else
                            {
                                condition.Attributes["value"].Value = d.ToString(CultureInfo.InvariantCulture);
                            }
                        }
                        break;
                        case AttributeTypeCode.Integer:
                        {
                            int d;
                            if (!int.TryParse(searchTerm, out d))
                            {
                                condition.Attributes["value"].Value = int.MinValue.ToString(CultureInfo.InvariantCulture);
                            }
                            else
                            {
                                condition.Attributes["value"].Value = d.ToString(CultureInfo.InvariantCulture);
                            }
                        }
                        break;
                        case AttributeTypeCode.Picklist:
                    {
                        var opt = ((PicklistAttributeMetadata) attr).OptionSet.Options.FirstOrDefault(
                            o => o.Label.UserLocalizedLabel.Label == searchTerm);

                        if (opt == null)
                        {
                            condition.Attributes["value"].Value = int.MinValue.ToString(CultureInfo.InvariantCulture);
                            }
                        else
                        {
                            condition.Attributes["value"].Value = opt.Value.Value.ToString(CultureInfo.InvariantCulture);
                            }
                    }
                        break;
                    case AttributeTypeCode.State:
                        {
                            var opt = ((StateAttributeMetadata)attr).OptionSet.Options.FirstOrDefault(
                                o => o.Label.UserLocalizedLabel.Label == searchTerm);

                            if (opt == null)
                            {
                                condition.Attributes["value"].Value = int.MinValue.ToString(CultureInfo.InvariantCulture);
                            }
                            else
                            {
                                condition.Attributes["value"].Value = opt.Value.Value.ToString(CultureInfo.InvariantCulture);
                            }
                        }
                        break;
                    case AttributeTypeCode.Status:
                        {
                            var opt = ((StatusAttributeMetadata)attr).OptionSet.Options.FirstOrDefault(
                                o => o.Label.UserLocalizedLabel.Label == searchTerm);

                            if (opt == null)
                            {
                                condition.Attributes["value"].Value = int.MinValue.ToString(CultureInfo.InvariantCulture);
                            }
                            else
                            {
                                condition.Attributes["value"].Value = opt.Value.Value.ToString(CultureInfo.InvariantCulture);
                            }
                        }
                        break;
                }

                #endregion
            }

            foreach (XmlNode filter in node.SelectNodes("filter"))
            {
                ProcessFilter(filter, searchTerm);
            }
        }

        private void BtnSearchClick(object sender, EventArgs e)
        {
            lvResults.Items.Clear();

            string newFetchXml = "";
            string resultXml = "";
            try
            {
                if (txtSearch.Text.Length == 0) txtSearch.Text = "*";

                var view = ((ViewInfo) cbbViews.SelectedItem).Entity;
                var layout = new XmlDocument();
                layout.LoadXml(view["layoutxml"].ToString());


                string fetchXml = view["fetchxml"].ToString();
                var fetchDoc = new XmlDocument();
                fetchDoc.LoadXml(fetchXml);
                var filterNodes = fetchDoc.SelectNodes("fetch/entity/filter");
                foreach (XmlNode filterNode in filterNodes)

                    ProcessFilter(filterNode, txtSearch.Text);

                newFetchXml = fetchDoc.OuterXml;

                resultXml =
                    ((ExecuteFetchResponse) service.Execute(new ExecuteFetchRequest {FetchXml = newFetchXml }))
                        .FetchXmlResult;
                var resultsDoc = new XmlDocument();
                resultsDoc.LoadXml(resultXml);

                foreach (XmlNode node in resultsDoc.SelectNodes("//result"))
                {
                    bool isFirstCell = true;

                    var item = new ListViewItem();
                    item.Tag = new Guid(node.SelectSingleNode(metadata.PrimaryIdAttribute).InnerText);

                    foreach (XmlNode cell in layout.SelectNodes("//cell"))
                    {
                        var attributeNode = node.SelectSingleNode(cell.Attributes["name"].Value);
                        if (attributeNode == null)
                        {
                            if (isFirstCell)
                            {
                                item.Text = "";
                                isFirstCell = false;
                            }
                            else
                            {
                                item.SubItems.Add("");
                            }
                        }
                        else
                        {
                            if (attributeNode.Attributes["name"] != null)
                            {
                                if (isFirstCell)
                                {
                                    item.Text = attributeNode.Attributes["name"].Value;
                                    isFirstCell = false;
                                }
                                else
                                {
                                    item.SubItems.Add(attributeNode.Attributes["name"].Value);
                                }
                            }
                            else
                            {
                                if (isFirstCell)
                                {
                                    item.Text = attributeNode.InnerText;
                                    isFirstCell = false;
                                }
                                else
                                {
                                    item.SubItems.Add(attributeNode.InnerText);
                                }
                            }
                        }
                    }

                    lvResults.Items.Add(item);
                }

                if (resultsDoc.SelectSingleNode("resultset").Attributes["morerecords"].Value == "1")
                {
                    MessageBox.Show(this,
                        "There is more than 250 records that match your search! Please refine your search",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(this,
                    "An error occured: " + error.ToString() + " --> " + newFetchXml + " --> " + resultXml,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbbViewsSelectedIndexChanged(object sender, EventArgs e)
        {
            lvResults.Columns.Clear();

            var view = ((ViewInfo)cbbViews.SelectedItem).Entity;
            var layout = new XmlDocument();
            layout.LoadXml(view["layoutxml"].ToString());

            foreach (XmlNode cell in layout.SelectNodes("//cell"))
            {
                var ch = new ColumnHeader();
                try
                {
                    ch.Text =
                        metadata.Attributes.First(a => a.LogicalName == cell.Attributes["name"].Value)
                            .DisplayName.UserLocalizedLabel.Label;
                    ch.Width = int.Parse(cell.Attributes["width"].Value);
                }
                catch
                {
                    ch.Text = cell.Attributes["name"].Value;
                }
                lvResults.Columns.Add(ch);
            }
        }

        private void LookupSingleLoad(object sender, EventArgs e)
        {
            var qe = new QueryExpression("savedquery");
            qe.ColumnSet = new ColumnSet(true);
            qe.Criteria.AddCondition("returnedtypecode", ConditionOperator.Equal, entityName);
            qe.Criteria.AddCondition("querytype", ConditionOperator.Equal, 4);
            var records = service.RetrieveMultiple(qe);

            if(records.Entities.Count == 0)
            {
                MessageBox.Show(this, "Cannot load views since this entity does not have Quick Find view defined", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            int index = 0;
            int defaultViewIndex = 0;

            foreach (var record in records.Entities)
            {
                if ((bool)record["isdefault"])
                    defaultViewIndex = index;

                var view = new ViewInfo();
                view.Entity = record;

                cbbViews.Items.Add(view);

                index++;
            }

            cbbViews.SelectedIndex = defaultViewIndex;
        }

        private void LvResultsColumnClick(object sender, ColumnClickEventArgs e)
        {
            lvResults.Sorting = lvResults.Sorting == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            lvResults.ListViewItemSorter = new ListViewItemComparer(e.Column, lvResults.Sorting);
        }

        private void LvResultsDoubleClick(object sender, EventArgs e)
        {
            BtnOkClick(null, null);
        }

        private void TxtSearchKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                BtnSearchClick(null, null);
            }
        }
    }
}