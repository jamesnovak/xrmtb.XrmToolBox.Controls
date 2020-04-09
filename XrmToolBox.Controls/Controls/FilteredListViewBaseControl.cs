using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using System.Drawing;

namespace xrmtb.XrmToolBox.Controls
{
    /// <summary>
    /// Base UserControl class that will implement the data binding of a generic List of objects to a ListView
    /// Includes toolbar functionality for check all/none, load list, sort, filter, etc 
    /// Derived classes can provide the actual load functionality
    /// </summary>
    public partial class FilteredListViewBaseControl : XrmToolBoxControlBase
    {

        #region Internal/private/protected properties for use by this and possibly derived classes
        private List<ListViewItem> _listViewItemsColl = null;
        private List<string> _listViewGroups = new List<string>();
        private ListViewColumnDef[] _listViewColDefs = new List<ListViewColumnDef>().ToArray();
        private bool _performingBulkSelection = false; // let's keep the listview from flickering and crashing

        /// <summary>
        /// internal list of all items 
        /// </summary>
        private List<object> _allItems = new List<object>();

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
        private ListViewColumnDef GroupByCol {
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
                ListViewMain.AutoResizeColumns(AutosizeColumns);
            }
        }

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
            set {
                // only allowed to define one group column... otherwise, mayhem 
                if (value?.Where(c => c.IsGroupColumn).ToList().Count > 1)
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
        protected virtual void ResetListViewColDefs() {
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
        /// Toggle the display of the toolbar within the control
        /// </summary>
        [Category("XrmToolBox")]
        [DisplayName("Display Toolbar")]
        [Description("Toggle the display of the toolbar within the control")]
        public bool DisplayToolbar
        {
            get { return splitContainerToolbar.Visible; }
            set { splitContainerToolbar.Visible = value; }
        }

        /// <summary>
        /// Flag indicating whether to display Checkboxes in the ListView control
        /// </summary>
        [Category("XrmToolBox")]
        [DisplayName("Display Checkboxes")]
        [Description("Flag indicating whether to display Checkboxes in the ListView control")]
        public bool Checkboxes
        {
            get { return ListViewMain.CheckBoxes; }
            set {
                // uncheck everything if no checkboxes
                if (value == false)
                {
                    CheckAllNone(false);
                }
                _performingBulkSelection = true;
                ListViewMain.SuspendLayout();

                ListViewMain.CheckBoxes = value;

                checkBoxCheckAllNone.Enabled = ListViewMain.CheckBoxes;
                ListViewMain.ResumeLayout();
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
                var filter = textFilterList.Text;
                return (filter != null) ? filter.Trim() : filter;
            }
            internal set {
                if (DesignMode) return;
                textFilterList.Text = value;
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
            get {
                return ListViewMain.Sorting;
            }
            internal set { ListViewMain.Tag = value; }
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
                int.TryParse(ListViewMain.Tag.ToString(), out currCol);
                return currCol;
            }
            internal set { ListViewMain.Tag = value; }
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
            private set 
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
        protected internal void SetAllItems<T>(List<T> items)
        {
            _allItems = items.Select(i=> i as object).ToList();

            ListItemType = typeof(T);

            // set the ListItemType from the list of items if not set
            SetUpListViewColumns();

            // load up the items into the list view.
            PopulateListView();
        }

        /// <summary>
        /// Internal collection of items bound to the list view.
        /// </summary>
        protected internal List<object> AllItems
        {
            get { return _allItems; }
        }

        /// <summary>
        /// The currently selected object in the ListView
        /// </summary>
        protected internal object SelectedItem { get; private set; } = null;

        /// <summary>
        /// List of all checked items in the ListView
        /// </summary>
        protected internal List<object> CheckedItems { get; private set; } = null;

        /// <summary>
        /// Filter the list of items using the current filter settings
        /// </summary>
        /// <param name="filterString"></param>
        public void FilterList(string filterString)
        {
            this.textFilterList.Text = filterString;
        }

        /// <summary>
        /// Clear out the saved items list and update the ListView
        /// </summary>
        public override void ClearData()
        {
            // clear out list view list, collection of items, etc.
            _listViewItemsColl?.Clear();
            CheckedItems = new List<object>();
            _allItems = new List<object>();

            ListViewMain.Items.Clear();

            if (SelectedItem != null)
            {
                this.ToggleMainControlsEnabled();
            }
            SelectedItemChanged?.Invoke(this, new EventArgs());

            base.ClearData();
        }

        #endregion

        #region Events
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

        /// <summary>
        /// Constructor!
        /// </summary>
        public FilteredListViewBaseControl()
        {
            InitializeComponent();

            // handle the enabled changed event
            EnabledChanged += FilteredListViewBaseControl_EnabledChanged;

            //ToggleMainControlsEnabled();
        }

        #region Main Methods
        /// <summary>
        /// Load the Items into the list view, binding the columns based on the control properties
        /// </summary>
        internal void PopulateListView()
        {
            ListViewMain.SuspendLayout();
            ListViewMain.Enabled = false;
            ListViewMain.Items.Clear();
            ListViewMain.Refresh();

            // persist the list of list view items for the filtering
            _listViewItemsColl = new List<ListViewItem>();

            if (_allItems != null && _allItems?.Count > 0)
            {
                var cols = ListViewMain.Columns;

                var props = ListItemType.GetProperties().ToDictionary(p=>p.Name, p=>p);

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

                    for (var i = 1; i< cols.Count; i++) {
                        var prop = props[cols[i].Name];
                        var colVal = Utility.GetPropertyValue<string>(item, prop);
                        var subitem = new ListViewItem.ListViewSubItem(lvItem, colVal) {
                            Name = cols[i].Name
                        };
                        lvItem.SubItems.Add(subitem);
                    }

                    // add to the internal collection of ListView Items and the external list
                    _listViewItemsColl.Add(lvItem);
                }

                ListViewMain.Items.AddRange(_listViewItemsColl.ToArray<ListViewItem>());
                // now auto size using the values specified
                ListViewMain.AutoResizeColumns(AutosizeColumns);
            }

            ListViewMain.ResumeLayout();
            ListViewMain.Enabled = true;
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
            if (props == null) {
                props = ListItemType.GetProperties().ToDictionary(p => p.Name, p => p);
            }
            // set up group if a group by col has been set
            ListViewGroup group = null;
            if (GroupByCol != null)
            {
                // only add new group if not already there
                var label = Utility.GetPropertyValue<string>(item, props[GroupByCol.Name]) ?? "(no value)";
                var groupVal = $"{GroupByCol.DisplayName}: {label}";

                group = ListViewMain.Groups[groupVal];

                if (group == null)
                {
                    group = new ListViewGroup(groupVal, HorizontalAlignment.Left)
                    {
                        Header = groupVal,
                        Name = groupVal,
                        Tag = groupVal
                    };
                    ListViewMain.Groups.Add(group);
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
            if (ListViewMain.Columns.Count == cols.Count)
            {
                var listCols = ListViewMain.Columns.Cast<ColumnHeader>().Select(c => c.Name);
                if (cols.Select(c => c.Name).SequenceEqual(listCols)) {
                    return;
                }
            }

            ListViewMain.SuspendLayout();
            ListViewMain.Columns.Clear();

            ListViewMain.Columns.AddRange(cols.ToArray());
            ListViewMain.ResumeLayout();
        }
        #endregion

        #region ListView Methods/Events

        /// <summary>
        /// Handle the ListView Item Checked event and set the selected list of items
        /// </summary>
        /// <param name="sender">event sender object</param>
        /// <param name="e">event args object</param>
        private void ListViewMain_ItemChecked(object sender, ItemCheckedEventArgs e)
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
        private void ListViewMain_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
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
        private void ListViewMain_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            SortList(e.Column);
        }

        /// <summary>
        /// Handle keyboard select all / none
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListViewMain_KeyUp(object sender, KeyEventArgs e)
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
                sortOrder = (ListViewMain.Sorting == SortOrder.Ascending) ? SortOrder.Descending : SortOrder.Ascending;
            }

            _performingBulkSelection = true;
            ListViewMain.SuspendLayout();

            // update the main list and save the values to properties
            ListViewMain.Sorting = sortOrder.Value;

            ListSortOrder = ListViewMain.Sorting;
            ListSortColumn = sortColumn;

            // now apply the sorter helper 
            ListViewMain.ListViewItemSorter = new ListViewItemComparer(ListSortColumn, ListViewMain.Sorting);

            _performingBulkSelection = false;

            ListViewMain.ResumeLayout();
        }

        /// <summary>
        /// Update the list of selected items based on the list of Checked items in the ListView
        /// Maintain this list dynamically because of how filtering has been implemented.  
        /// </summary>
        private void UpdateSelectedItemsList()
        {
            if (_performingBulkSelection) {
                return;
            }

            if (CheckedItems == null) {
                CheckedItems = new List<object>();
            }

            if (ListViewMain.CheckedItems.Count == 0) {
                CheckedItems.Clear();
            }
            else
            {
                foreach (ListViewItem listItem in ListViewMain.Items)
                {
                    var item = listItem.Tag;
                    if (listItem.Checked)
                    {
                        // if not already added, add the checked item
                        if (!CheckedItems.Contains(item)) {
                            CheckedItems.Add(item);
                        }
                    }
                    else
                    {
                        // if already added, then remove it
                        if (CheckedItems.Contains(item)) {
                            CheckedItems.Remove(item);
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
            _performingBulkSelection = true;

            ListViewMain.SuspendLayout();

            // if check all and we have checkboxes enabled, then do some work
            if (checkAll && Checkboxes)
            {
                foreach (ListViewItem item in ListViewMain.Items) {
                    item.Checked = true;
                }
            }
            else
            {
                foreach (ListViewItem item in ListViewMain.CheckedItems) {
                    item.Checked = false;
                }
            }
            ListViewMain.ResumeLayout();

            _performingBulkSelection = false;

            // now that we have an updated list view, udpate the list of selected items
            UpdateSelectedItemsList();
        }

        /// <summary>
        /// Filter the list using the text in the text box.
        /// </summary>
        private void FilterList()
        {
            string filterText = textFilterList.Text.ToLower();
            List<ListViewItem> newList = null;

            _performingBulkSelection = true;

            ListViewMain.SuspendLayout();

            // filter the cols 
            if (filterText.Length > 3)
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
                    var curr =  _listViewItemsColl
                                .Where(i => (col.Order == 0) ? 
                                i.Text.ToLower().Contains(filterText) : 
                                i.SubItems[col.Name].Text.ToLower().Contains(filterText)
                                );

                    // add to the current list
                    newList.AddRange(curr.Except(newList));
                }
            }
            else
            {
                if (ListViewMain.Items.Count != _listViewItemsColl.Count)
                {
                    newList = _listViewItemsColl;
                }
            }

            // if we have a new list to be set, clear and reset groups
            if (newList != null)
            {
                ListViewMain.Items.Clear();
                ListViewMain.Items.AddRange(newList.ToArray<ListViewItem>());

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

            ListViewMain.ResumeLayout();

            FilterListComplete?.Invoke(this, new EventArgs());
        }
        #endregion

        #region Additional UI element handlers
        /// <summary>
        /// Override the general disable main UI to handle enabling tool bar buttons
        /// </summary>
        protected override void ToggleMainControlsEnabled()
        {
            var count = AllItems?.Count;
            if (Service != null)
            {
                textFilterList.Enabled =
                //buttonCheckAll.Enabled =
                // buttonCheckNone.Enabled
                checkBoxCheckAllNone.Enabled = (count > 0);
                splitContainerToolbar.Enabled =
                buttonELVBaseLoadItems.Enabled = true;
            }
            else
            {
                base.ToggleMainControlsEnabled();
            }
        }

        /// <summary>
        /// Apply the filter to the list using the text provided
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripTextFilter_TextChanged(object sender, EventArgs e)
        {
            FilterList();
        }

        /// <summary>
        /// Just a helper to clear the filter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolButtonClearFilter_Click(object sender, EventArgs e)
        {
            textFilterList.Clear();
        }
        /// <summary>
        /// Clear the list of checked items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolLinkCheckNone_Click(object sender, EventArgs e)
        {
            CheckAllNone(false);
        }

        /// <summary>
        /// Check all items in the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolLinkCheckAll_Click(object sender, EventArgs e)
        {
            CheckAllNone(true);
        }

        /// <summary>
        /// Call the derived class overloaded method to load the data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolButtonLoadItems_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        /// <summary>
        /// Handle the Enabled property change to ensure that the child controls are also disabled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilteredListViewBaseControl_EnabledChanged(object sender, EventArgs e)
        {
            ToggleMainControlsEnabled();
        }

        private void CheckBoxCheckAllNone_CheckStateChanged(object sender, EventArgs e)
        {
            CheckAllNone(checkBoxCheckAllNone.Checked);
        }

        private void CheckBoxCheckAllNone_CheckedChanged(object sender, EventArgs e)
        {
            CheckAllNone(checkBoxCheckAllNone.Checked);
        }

        /// <summary>
        /// When the ListView is not active, the selected row is really hard to see. Set the highlight manually on enter/leave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListViewMain_HighLightSelected(object sender, EventArgs e)
        {
            SetSelectedHighlight(SystemColors.Highlight, SystemColors.HighlightText);
        }

        /// <summary>
        /// When the ListView is not active, the selected row is really hard to see. Set the highlight manually on enter/leave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListViewMain_ClearHighLight(object sender, EventArgs e)
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

            ListViewMain.SuspendLayout();

            if (ListViewMain.SelectedItems.Count > 0)
            {
                var selItem = ListViewMain.SelectedItems[0];
                selItem.ForeColor = foreColor;
                selItem.BackColor = backColor;
            }
            ListViewMain.ResumeLayout();
        }
        #endregion

    }
}
