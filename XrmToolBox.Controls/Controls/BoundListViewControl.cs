using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Xrm.Sdk;
using System.Reflection;
using Microsoft.Xrm.Sdk.Messages;

namespace xrmtb.XrmToolBox.Controls
{
    /// <summary>
    /// Base class that will bind a generic object to the ListView
    /// </summary>
    public partial class BoundListViewControl : ListView, IXrmToolBoxControl
    {
        /// <summary>
        /// 
        /// </summary>
        public BoundListViewControl()
        {
            InitializeComponent();
        }

        #region Internal/private/protected properties for use by this and possibly derived classes
        /// <summary>
        /// Collection of ListViewColumn Defs
        /// </summary>
        internal protected List<ListViewItem> _listViewItemsColl = null;

        internal List<string> _listViewGroups = new List<string>();
        private ListViewColumnDef[] _listViewColDefs = new List<ListViewColumnDef>().ToArray();
        private string _filterString = null;

        private bool _performingBulkSelection = false; // let's keep the listview from flickering and crashing

        #region IXrmToolboxControl
        private IOrganizationService _service = null;
        #endregion

        /// <summary>
        /// internal list of all items 
        /// </summary>
        internal protected List<object> _allItems = new List<object>();

        /// <summary>
        /// ColDef set up as for grouping
        /// </summary>
        private ListViewColumnDef _groupByCol = null;

        /// <summary>
        /// .NET type for the bound list.  This will be used to retrieve property values 
        /// </summary>
        private Type _listItemType = null;

        private ColumnHeaderAutoResizeStyle _autoResizeStyle = ColumnHeaderAutoResizeStyle.None;

        /// <summary>
        /// Helper method for the column to be used in grouping
        /// </summary>
        private ListViewColumnDef GroupByCol
        {
            get 
            {
                if (_groupByCol == null)
                {
                    // get a list of the group col names
                    if (ListViewColDefs.Length > 0)
                    {
                        _groupByCol = ListViewColDefs
                            .Where(c => c.IsGroupColumn == true)
                            .FirstOrDefault();
                    }
                }
                return _groupByCol;
            }
        }
        #endregion

        #region Runtime properties

        /// <summary>
        /// Mode for automatically resizing Column in the ListView.  Autosize may cause some flickering for ListView many columns
        /// </summary>
        [Category("XrmToolBox")]
        [DisplayName("Auto Resize Column Style")]
        [Description("Mode for automatically resizing Column in the ListView.  Autosize may cause some flickering for ListView many columns")]
        public ColumnHeaderAutoResizeStyle AutosizeColumns
        {
            get { return _autoResizeStyle; }
            set {
                _autoResizeStyle = value;
                AutoResizeColumns(AutosizeColumns);
            }
        }
        /// <summary>
        /// Flag indicating whether to automatically load data when the Service connection is set or updated.
        /// </summary>
        [Category("XrmToolBox")]
        [DisplayName("Automatically Load Data")]
        [Description("Flag indicating whether to automatically load data when the Service connection is set or updated.")]
        public bool AutoLoadData { get; set; }

        /// <summary>
        /// List of Column Definitions for the main ListView.  If not specified, the Columns will be automatically generated using the type of object in the AllItems list
        /// </summary>
        [Category("XrmToolBox")]
        [DisplayName("List View Columns")]
        [Description("List of Column Definitions for the main ListView.  If not specified, the Columns will be automatically generated using the type of object in the AllItems list")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ListViewColumnDef[] ListViewColDefs
        {
            get { return _listViewColDefs; }
            set
            {
                // only allowed to define one group column... otherwise, mayhem 
                if (value.Where(c => c.IsGroupColumn).ToList().Count > 1)
                {
                    throw new ArgumentException("Only one column can be specified as a Group By column");
                }
                _groupByCol = null;
                _listViewColDefs = value;

                // update ListVidew with new settings
                SetUpListViewColumns();

                // reload items into list view now that cols have changed.
                PopulateListView();
            }
        }

        /// <summary>
        /// Used for the designer, allow reset of the ListViewColumnDef array in the property grid
        /// </summary>
        protected virtual void ResetListViewColDefs()
        {
            _listViewColDefs = new ListViewColumnDef[0];
        }
        /// <summary>
        /// Property Grid helper methods 
        /// </summary>
        /// <returns></returns>
        protected virtual bool ShouldListViewColDefs()
        {
            return true;
        }

        /// <summary>
        /// Flag indicating whether to display Checkboxes in the ListView control
        /// </summary>
        [Category("XrmToolBox")]
        [DisplayName("Display Checkboxes")]
        [Description("Flag indicating whether to display Checkboxes in the ListView control")]
        public bool DisplayCheckBoxes
        {
            get { return CheckBoxes; }
            set {
                // uncheck everything if no checkboxes
                if (value == false)
                {
                    CheckAllNone(false);
                }
                _performingBulkSelection = true;
                SuspendLayout();

                CheckBoxes = value;

                ResumeLayout();
                _performingBulkSelection = false;
            }
        }

        /// <summary>
        /// Filter string for the toolbar 
        /// </summary>
        [Category("XrmToolBox")]
        [DisplayName("List Filter String")]
        [Description("Filter string applied to the main ListView control for the loaded Item List.")]
        public string ListFilterString
        {
            get {
                var filter = _filterString;
                return (filter != null) ? filter.Trim() : filter;
            }
            internal set {
                if (DesignMode) return;
                _filterString = value?.Trim();
            }
        }

        /// <summary>
        /// Current SortOrder for the main List View
        /// </summary>
        [Category("XrmToolBox")]
        [DisplayName("List Sort Order")]
        [Description("Current SortOrder for the main List View.")]
        [Browsable(false)]
        public SortOrder ListSortOrder
        {
            get { return Sorting; }
            internal set { Tag = value; }
        }

        /// <summary>
        /// Current SortColumn index for the main List View
        /// </summary>
        [Category("XrmToolBox")]
        [DisplayName("List Sort Column")]
        [Description("Current Sort Column for the main ListView.")]
        [Browsable(false)]
        public int ListSortColumn
        {
            get {
                var currCol = 0;
                int.TryParse(Tag.ToString(), out currCol);
                return currCol;
            }
            internal set { Tag = value; }
        }

        #endregion

        #region Protected Internal properties/methods
        // These will be extended by derived classes
        /// <summary>
        /// .NET Type for the bound item. Used to set up columns and retrieve property values
        /// </summary>
        protected internal Type ListItemType
        {
            get { return _listItemType; }
            internal set 
            {
                _listItemType = value;

                // only set up columns col defs not defined
                if (ListViewColDefs.Length == 0)
                {
                    SetUpListViewColumns();
                }
            }
        }

        /// <summary>
        /// Helper method for setting the internal list of items bound to the ListView.
        /// Allows us to specify the object Type being bound
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        public virtual void LoadData<T>(List<T> items)
        {
            // before we load new, be sure to clear
            ClearData();

            _allItems = items.ConvertAll<object>(new Converter<T, object>((item) => { return item as object; }));

            ListItemType = typeof(T);

            // set the ListItemType from the list of items if not set
            SetUpListViewColumns();

            // load up the items into the list view.
            PopulateListView();

            OnLoadDataComplete();
        }

        /// <summary>
        /// Internal collection of items bound to the list view.
        /// </summary>
        protected internal List<object> AllItems
        {
            get { return _allItems; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T GetSelectedItem<T>() {

            if (SelectedItem != null)
            {
                return (T)SelectedItem;
            }
            else {
                return default; 
            }
        }

        /// <summary>
        /// The currently selected object in the ListView
        /// </summary>
        protected internal object SelectedItem { get; private set; } = null;

        /// <summary>
        /// List of all checked items in the ListView
        /// </summary>
        protected internal List<object> CheckedObjects { get; private set; } = null;

        #endregion

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
        #endregion

        #region IXrmToolBoxControl Event Definitions

        #region Event Definitions
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
        /// Event that fires when <see cref="BoundListViewControl.LoadData"/>() completes
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
        #endregion

        #region Methods
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

            // if the auto load is set, now is the time to reload!
            if (AutoLoadData && (Service != null))
            {
                LoadData();
            }
        }

        /// <summary>
        /// Close has been called
        /// </summary>
        public virtual void Close()
        {
            OnBeginClose();

            _service = null;

            // use this. to ensure that any overrides are called
            ClearData();

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
        /// Clear out the saved items list and update the ListView
        /// </summary>
        public void ClearData()
        {
            // clear out list view list, collection of items, etc.
            _listViewItemsColl?.Clear();
            CheckedObjects = new List<object>();
            _allItems = new List<object>();

            Items.Clear();
            SelectedItem = null;
            SelectedItemChanged?.Invoke(this, new EventArgs());
        }

        #endregion

        #region Event helpers
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
        protected void OnBeginLoadData()
        {
            // if (this.InvokeRequired) return;
            BeginLoadData?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// Fires the LoadDataComplete event for all listeners
        /// </summary>
        protected void OnLoadDataComplete()
        {
            // if (this.InvokeRequired) return;
            LoadDataComplete?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// Fires the BeginClearData event to all listeners
        /// </summary>
        protected void OnBeginClearData()
        {
            // if (this.InvokeRequired) return;
            BeginClearData?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// Fires the ClearDataComplete event to all listeners
        /// </summary>
        protected void OnClearDataComplete()
        {
            // if (this.InvokeRequired) return;
            ClearDataComplete?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// Fires the BeginClose event to all listeners
        /// </summary>
        protected void OnBeginClose()
        {
            // if (this.InvokeRequired) return;
            BeginClose?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// Fires the CloseComplete event to all listeners
        /// </summary>
        protected void OnCloseComplete()
        {
            // if (this.InvokeRequired) return;
            CloseComplete?.Invoke(this, new EventArgs());
        }
        #endregion

        #endregion

        #region ListView specific Event definition
        /// <summary>
        /// Event that fires when the Selected Item changes
        /// </summary>
        [Category("XrmToolBox")]
        [Description("Event that fires when the Selected Item changes")]
        public event EventHandler SelectedItemChanged;

        /// <summary>
        /// Event that fires when the list of Checked Items changes
        /// </summary>
        [Category("XrmToolBox")]
        [Description("Event that fires when the list of Checked Items changes")]
        public event EventHandler CheckedItemsChanged;

        /// <summary>
        /// Event that fires when FilterList() completes
        /// </summary>
        [Category("XrmToolBox")]
        [Description("Event that fires when the list of Checked Items changes")]
        public event EventHandler FilterListComplete;


        #endregion

        #region ListView Methods/Events
        /// <summary>
        /// Handle the ListView Item Checked event and set the selected list of items
        /// </summary>
        /// <param name="sender">event sender object</param>
        /// <param name="e">event args object</param>
        private void ListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (!_performingBulkSelection)
            {
                UpdateSelectedItemsList();
            }
        }

        /// <summary>
        /// Handle the item selection change for the list view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            // clear current selection 
            SelectedItem = null;

            if (!e.IsSelected)
                return;

            // grab the current selected object from the ListItem tag.
            SelectedItem = e.Item.Tag;

            SelectedItemChanged?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// Handle the column click for the list view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            SortList(e.Column);
        }

        /// <summary>
        /// Handle keyboard select all / none
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListView_KeyUp(object sender, KeyEventArgs e)
        {
            if (!e.Handled)
            {
                if (e.Control)
                {
                    if (e.KeyCode == Keys.A)
                    {
                        CheckAllNone(true);
                    }
                    else if (e.KeyCode == Keys.D)
                    {
                        CheckAllNone(false);
                    }
                }
            }
        }

        /// <summary>
        /// When the ListView is not active, the selected row is really hard to see. Set the highlight manually on enter/leave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListView_HighLightSelected(object sender, EventArgs e)
        {
            SetSelectedHighlight(SystemColors.Highlight, SystemColors.HighlightText);
        }

        /// <summary>
        /// When the ListView is not active, the selected row is really hard to see. Set the highlight manually on enter/leave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListView_ClearHighLight(object sender, EventArgs e)
        {
            SetSelectedHighlight(SystemColors.Window, SystemColors.WindowText);
        }
        /// <summary>
        /// Helper method for setting the fore and back color for the selected row
        /// </summary>
        /// <param name="backColor"></param>
        /// <param name="foreColor"></param>
        private void SetSelectedHighlight(Color backColor, Color foreColor)
        {

            SuspendLayout();

            if (SelectedItems.Count > 0)
            {
                var selItem = SelectedItems[0];
                selItem.ForeColor = foreColor;
                selItem.BackColor = backColor;
            }
            ResumeLayout();
        }
        /// <summary>
        /// Internal method that allows us to decide whether to throw an exception to the user, or to simply add notification
        /// </summary>
        /// <param name="throwException"></param>
        protected virtual void LoadData(bool throwException) { }

        /// <summary>
        /// Sort the current list of items in the ListView
        /// </summary>
        /// <param name="sortColumn">ListView column index to be sorted</param>
        /// <param name="sortOrder">Sort order for the selected column</param>
        public void SortList(int sortColumn, SortOrder? sortOrder = null)
        {
            // toggle the sort order if not passed as a param
            if (sortOrder == null)
            {
                sortOrder = (Sorting == SortOrder.Ascending) ? SortOrder.Descending : SortOrder.Ascending;
            }

            _performingBulkSelection = true;
            SuspendLayout();

            // update the main list and save the values to properties
            Sorting = sortOrder.Value;

            ListSortOrder = Sorting;
            ListSortColumn = sortColumn;

            // now apply the sorter helper 
            ListViewItemSorter = new ListViewItemComparer(ListSortColumn, Sorting);

            _performingBulkSelection = false;

            ResumeLayout();
        }

        /// <summary>
        /// Update the list of selected items based on the list of Checked items in the ListView
        /// Maintain this list dynamically because of how filtering has been implemented.  
        /// </summary>
        private void UpdateSelectedItemsList()
        {
            if (_performingBulkSelection)
            {
                return;
            }

            if (CheckedObjects == null)
            {
                CheckedObjects = new List<object>();
            }

            if (CheckedItems.Count == 0)
            {
                CheckedObjects.Clear();
            }
            else
            {
                foreach (ListViewItem listItem in Items)
                {
                    var item = listItem.Tag;
                    if (listItem.Checked)
                    {
                        // if not already added, add the checked item
                        if (!CheckedObjects.Contains(item))
                        {
                            CheckedObjects.Add(item);
                        }
                    }
                    else
                    {
                        // if already added, then remove it
                        if (CheckedObjects.Contains(item))
                        {
                            CheckedObjects.Remove(item);
                        }
                    }
                }
            }
            CheckedItemsChanged?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// Check all items in the ListView
        /// </summary>
        public void CheckAll()
        {
            CheckAllNone(true);
        }

        /// <summary>
        /// Uncheck all items in the ListView
        /// </summary>
        public void CheckNone()
        {
            CheckAllNone(false);
        }

        /// <summary>
        /// Toggle all or none checked in the main list view
        /// </summary>
        /// <param name="checkAll">flag indicating whether to check all items in the ListView</param>
        private void CheckAllNone(bool checkAll)
        {
            if (CheckedObjects == null)
                return;

            _performingBulkSelection = true;

            SuspendLayout();

            // if check all and we have checkboxes enabled, then do some work
            if (checkAll && CheckBoxes)
            {
                foreach (ListViewItem item in Items)
                {
                    item.Checked = true;
                }
            }
            else
            {
                foreach (ListViewItem item in CheckedObjects)
                {
                    item.Checked = false;
                }
            }
            ResumeLayout();

            _performingBulkSelection = false;

            // now that we have an updated list view, udpate the list of selected items
            UpdateSelectedItemsList();
        }

        /// <summary>
        /// Filter the list using the text in the text box.
        /// </summary>
        private void FilterList()
        {
            List<ListViewItem> newList = null;

            _performingBulkSelection = true;

            SuspendLayout();

            // filter the cols 
            if (_filterString.Length > 3)
            {
                // get the filter cols... this allows us to check the correct col for the value
                // if none found, default to first col
                var filterCols = ListViewColDefs.Where(c => c.IsFilterColumn == true).ToList();
                if (filterCols.Count == 0)
                {
                    filterCols = ListViewColDefs.OrderBy(c => c.Order).Take(1).ToList();
                }

                newList = new List<ListViewItem>();
                foreach (var col in filterCols)
                {
                    // filter the master list and bind it to the list view. Col 0 is the text while the rest are subitems/cols
                    var curr = _listViewItemsColl
                                .Where(i => (col.Order == 0) ?
                                i.Text.ToLower().Contains(_filterString) :
                                i.SubItems[col.Name].Text.ToLower().Contains(_filterString)
                                );

                    // add to the current list
                    newList.AddRange(curr.Except(newList));
                }
            }
            else
            {
                if (Items.Count != _listViewItemsColl.Count)
                {
                    newList = _listViewItemsColl;
                }
            }

            // if we have a new list to be set, clear and reset groups
            if (newList != null)
            {
                Items.Clear();
                Items.AddRange(newList.ToArray<ListViewItem>());

                var props = ListItemType.GetProperties().ToDictionary(p => p.Name, p => p);

                // now reset the group for each list item
                foreach (var item in newList)
                {
                    item.Group = GetListItemGroup(item.Tag, props);
                }

                // now that we have an updated list view, udpate the list of selected items
                UpdateSelectedItemsList();
            }
            _performingBulkSelection = false;

            ResumeLayout();

            FilterListComplete?.Invoke(this, new EventArgs());
        }
        #endregion

        #region Main Methods
        /// <summary>
        /// Load the Items into the list view, binding the columns based on the control properties
        /// </summary>
        internal virtual void PopulateListView()
        {
            SuspendLayout();
            Enabled = false;
            Items.Clear();
            Refresh();

            // persist the list of list view items for the filtering
            _listViewItemsColl = new List<ListViewItem>();

            // if ListItemType is null, we are clearing things out 
            if (_allItems != null && _allItems?.Count > 0)
            {
                var cols = Columns;

                var props = ListItemType.GetProperties().ToDictionary(p => p.Name, p => p);

                foreach (var item in _allItems)
                {
                    var col = cols[0];
                    var colDef = col.Tag as ListViewColumnDef;

                    // get the ListView group for the current row/ListViewItem
                    var group = GetListItemGroup(item, props);

                    var text = Utility.GetPropertyValue<string>(item, props[col.Name]);

                    // new list view item 
                    var lvItem = new ListViewItem()
                    {
                        Name = cols[0].Name,
                        ImageIndex = 0,
                        StateImageIndex = 0,
                        Text = text,
                        Tag = item,  // stash the template here so we can view details later
                        Group = group
                    };

                    for (var i = 1; i < cols.Count; i++)
                    {
                        var prop = props[cols[i].Name];
                        var colVal = Utility.GetPropertyValue<string>(item, prop);
                        var subitem = new ListViewItem.ListViewSubItem(lvItem, colVal)
                        {
                            Name = cols[i].Name
                        };
                        lvItem.SubItems.Add(subitem);
                    }

                    // add to the internal collection of ListView Items and the external list
                    _listViewItemsColl.Add(lvItem);
                }

                Items.AddRange(_listViewItemsColl.ToArray<ListViewItem>());
                // now auto size using the values specified
                AutoResizeColumns(AutosizeColumns);
            }

            ResumeLayout();
            Enabled = true;
        }

        /// <summary>
        /// Get the group for the current ListViewItem based on the current properties
        /// If the group is not present, it will be dynamically added
        /// </summary>
        /// <param name="item"></param>
        /// <param name="props"></param>
        /// <returns></returns>
        private ListViewGroup GetListItemGroup(object item, Dictionary<string, PropertyInfo> props = null)
        {
            if (props == null)
            {
                props = ListItemType.GetProperties().ToDictionary(p => p.Name, p => p);
            }
            // set up group if a group by col has been set
            ListViewGroup group = null;
            if (GroupByCol != null)
            {
                // only add new group if not already there
                var label = Utility.GetPropertyValue<string>(item, props[GroupByCol.Name]) ?? "(no value)";
                var groupVal = $"{GroupByCol.DisplayName}: {label}";

                group = Groups[groupVal];

                if (group == null)
                {
                    group = new ListViewGroup(groupVal, HorizontalAlignment.Left)
                    {
                        Header = groupVal,
                        Name = groupVal,
                        Tag = groupVal
                    };
                    Groups.Add(group);
                }
            }
            return group;
        }
        /// <summary>
        /// Set up the ListView Columns either using the Col Def list provided, 
        /// or generically with the object property definitions from object metadata 
        /// </summary>
        private void SetUpListViewColumns()
        {
            var cols = new List<ColumnHeader>();

            if (ListViewColDefs.Length > 0)
            {
                // use the list of predefined columns for the list view.
                foreach (var colDef in ListViewColDefs.OrderBy(o => o.Order))
                {
                    cols.Add(new ColumnHeader()
                    {
                        Name = colDef.Name,
                        Text = colDef.DisplayName,
                        DisplayIndex = colDef.Order,
                        Width = colDef.Width,
                        Tag = colDef
                    });
                }
            }
            else if (ListItemType != null)
            {
                // render all of the properties for the bound list object type
                PropertyInfo[] props = ListItemType.GetProperties();

                foreach (PropertyInfo p in props)
                {
                    cols.Add(new ColumnHeader()
                    {
                        Name = p.Name,
                        Text = p.Name,
                        Width = 100
                    });
                }
            }

            // if the two are the same, then no need to reset
            if (Columns.Count == cols.Count)
            {
                var listCols = Columns.Cast<ColumnHeader>().Select(c => c.Name);
                if (cols.Select(c => c.Name).SequenceEqual(listCols))
                {
                    return;
                }
            }

            SuspendLayout();
            Columns.Clear();

            Columns.AddRange(cols.ToArray());
            ResumeLayout();
        }
        #endregion

    }
}
