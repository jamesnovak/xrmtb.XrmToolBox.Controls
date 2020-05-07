using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace xrmtb.XrmToolBox.Controls.Controls
{
    public delegate void ProgressUpdate(string message);
    public delegate void RetrieveComplete(int itemCount, Entity FirstItem);

    public class CDSComboBoxItem
    {
        #region Private Fields

        private readonly Entity entity;
        private IOrganizationService service;

        #endregion Private Fields

        #region Public Constructors

        public CDSComboBoxItem(Entity entity, string format, IOrganizationService organizationService)
        {
            this.entity = entity;
            this.Format = format;
            this.service = organizationService;
        }

        #endregion Public Constructors

        #region Public Properties

        public Entity Entity => entity;

        public string Format { get; set; }

        #endregion Public Properties

        #region Public Methods

        public override string ToString()
        {
            if (entity == null)
            {
                return string.Empty;
            }
            return ParseFormat();
        }

        #endregion Public Methods

        #region Private Methods

        private string GetFormattedValue(string attribute, string format)
        {
            if (!entity.Contains(attribute))
            {
                return string.Empty;
            }
            var value = entity[attribute];
            var metadata = MetadataHelper.GetAttribute(service, entity.LogicalName, attribute, value);
            if (EntitySerializer.AttributeToBaseType(value) is DateTime dtvalue && (dtvalue).Kind == DateTimeKind.Utc)
            {
                value = dtvalue.ToLocalTime();
            }
            if (!ValueTypeIsFriendly(value) && metadata != null)
            {
                value = EntitySerializer.AttributeToString(value, metadata, format);
            }
            else
            {
                value = EntitySerializer.AttributeToBaseType(value).ToString();
            }
            return value.ToString();
        }

        private string ParseFormat()
        {
            var value = Format;
            if (string.IsNullOrWhiteSpace(value))
            {
                value = MetadataHelper.GetPrimaryAttribute(service, entity.LogicalName)?.LogicalName;
            }
            if (!Format.Contains("{{") || !Format.Contains("}}"))
            {
                value = "{{" + value + "}}";
            }
            while (value.Contains("{{") && value.Contains("}}"))
            {
                var part = value.Substring(value.IndexOf("{{") + 2).Split(new string[] { "}}" }, StringSplitOptions.None)[0];
                var attribute = part;
                var format = string.Empty;
                if (part.Contains("|"))
                {
                    attribute = part.Split('|')[0];
                    format = part.Split('|')[1];
                }
                var partvalue = GetFormattedValue(attribute, format);
                value = value.Replace("{{" + part + "}}", partvalue);
            }
            return value;
        }

        private bool ValueTypeIsFriendly(object value)
        {
            return value is Int32 || value is decimal || value is double || value is string || value is Money;
        }

        #endregion Private Methods

    }

    public partial class CDSDataComboBox : ComboBox
    {
        #region Private properties
        private string displayFormat = string.Empty;
        private IEnumerable<Entity> entities;
        private IOrganizationService organizationService;
        #endregion

        #region Public Constructors

        public CDSDataComboBox()
        {
            InitializeComponent();
        }

        #endregion Public Constructors

        #region Public Properties

        [Category("Data")]
        [Description("Indicates the source of data (EntityCollection) for the CDSDataComboBox control.")]
        public new object DataSource
        {
            get
            {
                if (entities != null)
                {
                    return entities;
                }
                return base.DataSource;
            }
            set
            {
                IEnumerable<Entity> newEntities = null;
                if (value is EntityCollection entityCollection)
                {
                    newEntities = entityCollection.Entities;
                }
                else if (value is IEnumerable<Entity> entities)
                {
                    newEntities = entities;
                }
                if (newEntities != null)
                {
                    entities = newEntities;
                    Refresh();
                }
            }
        }

        [Category("Data")]
        [DisplayName("Display Format")]
        [Description("Single attribute from datasource to display for items, or use {{attributename}} syntax freely.")]
        public string DisplayFormat
        {
            get { return displayFormat; }
            set
            {
                if (value != displayFormat)
                {
                    displayFormat = value;
                    Refresh();
                }
            }
        }

        [Category("Data")]
        [DefaultValue(null)]
        public IOrganizationService OrganizationService
        {
            get { return organizationService; }
            set
            {
                organizationService = value;
                Refresh();
            }
        }

        public Entity SelectedEntity => (SelectedItem is CDSComboBoxItem item) ? item.Entity : null;

        #endregion Public Properties

        #region Public Methods

        public override void Refresh()
        {
            base.DataSource = entities?.Select(e => new CDSComboBoxItem(e, displayFormat, organizationService)).ToArray();
            base.Refresh();
        }

        public void RetrieveMultiple(QueryBase query, ProgressUpdate progressCallback, RetrieveComplete completeCallback)
        {
            if (this.OrganizationService == null)
            {
                throw new InvalidOperationException("The Service reference must be set before calling RetrieveMultiple.");
            }

            try
            {
                var worker = new BackgroundWorker();
                worker.DoWork += (w, e) =>
                {
                    var queryExp = e.Argument as QueryBase;

                    BeginInvoke(progressCallback, "Begin Retrieve Multiple");

                    var fetchReq = new RetrieveMultipleRequest
                    {
                        Query = queryExp
                    };

                    var records = OrganizationService.RetrieveMultiple(query);

                    BeginInvoke(progressCallback, "End Retrieve Multiple");

                    e.Result = records;
                };

                worker.RunWorkerCompleted += (s, e) =>
                {
                    var records = e.Result as EntityCollection;

                    BeginInvoke(progressCallback, $"Retrieve Multiple - records returned: {records.Entities.Count}");

                    DataSource = records;

                    // make the final callback
                    BeginInvoke(completeCallback, entities?.Count(), SelectedEntity);
                };

                // kick off the worker thread!
                worker.RunWorkerAsync(query);
            }
            catch (System.ServiceModel.FaultException ex)
            {
            }
        }

        public void RetrieveMultiple(string fetchXml, ProgressUpdate progressCallback, RetrieveComplete completeCallback)
        {
            RetrieveMultiple(new FetchExpression(fetchXml), progressCallback, completeCallback);
        }

        #endregion Public Methods
    }
}
