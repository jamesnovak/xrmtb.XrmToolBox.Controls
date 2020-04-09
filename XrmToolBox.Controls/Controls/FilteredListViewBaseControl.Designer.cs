namespace xrmtb.XrmToolBox.Controls
{
    partial class FilteredListViewBaseControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("System", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Custom", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilteredListViewBaseControl));
            this.ListViewMain = new System.Windows.Forms.ListView();
            this.colDisplayName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSchemaName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanelToolbar = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonELVBaseLoadItems = new System.Windows.Forms.Button();
            this.checkBoxCheckAllNone = new System.Windows.Forms.CheckBox();
            this.labelFilter = new System.Windows.Forms.Label();
            this.textFilterList = new System.Windows.Forms.TextBox();
            this.buttonClearFilter = new System.Windows.Forms.Button();
            this.splitContainerToolbar = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanelToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerToolbar)).BeginInit();
            this.splitContainerToolbar.Panel1.SuspendLayout();
            this.splitContainerToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListViewMain
            // 
            this.ListViewMain.CheckBoxes = true;
            this.ListViewMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDisplayName,
            this.colName,
            this.colSchemaName,
            this.colState,
            this.colDescription});
            this.ListViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewMain.FullRowSelect = true;
            listViewGroup1.Header = "System";
            listViewGroup1.Name = "System";
            listViewGroup1.Tag = "System";
            listViewGroup2.Header = "Custom";
            listViewGroup2.Name = "Custom";
            listViewGroup2.Tag = "Custom";
            this.ListViewMain.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.ListViewMain.HideSelection = false;
            this.ListViewMain.Location = new System.Drawing.Point(0, 55);
            this.ListViewMain.Margin = new System.Windows.Forms.Padding(6);
            this.ListViewMain.MultiSelect = false;
            this.ListViewMain.Name = "ListViewMain";
            this.ListViewMain.Size = new System.Drawing.Size(1455, 874);
            this.ListViewMain.TabIndex = 5;
            this.ListViewMain.Tag = "0";
            this.ListViewMain.UseCompatibleStateImageBehavior = false;
            this.ListViewMain.View = System.Windows.Forms.View.Details;
            this.ListViewMain.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListViewMain_ColumnClick);
            this.ListViewMain.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.ListViewMain_ItemChecked);
            this.ListViewMain.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListViewMain_ItemSelectionChanged);
            this.ListViewMain.Enter += new System.EventHandler(this.ListViewMain_ClearHighLight);
            this.ListViewMain.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ListViewMain_KeyUp);
            this.ListViewMain.Leave += new System.EventHandler(this.ListViewMain_HighLightSelected);
            // 
            // colDisplayName
            // 
            this.colDisplayName.Tag = "DisplayName";
            this.colDisplayName.Text = "Display Name";
            this.colDisplayName.Width = 100;
            // 
            // colName
            // 
            this.colName.Tag = "Name";
            this.colName.Text = "Name";
            this.colName.Width = 100;
            // 
            // colSchemaName
            // 
            this.colSchemaName.Tag = "SchemaName";
            this.colSchemaName.Text = "Schema Name";
            this.colSchemaName.Width = 100;
            // 
            // colState
            // 
            this.colState.Tag = "State";
            this.colState.Text = "State";
            this.colState.Width = 100;
            // 
            // colDescription
            // 
            this.colDescription.Tag = "Description";
            this.colDescription.Text = "Description";
            this.colDescription.Width = 300;
            // 
            // flowLayoutPanelToolbar
            // 
            this.flowLayoutPanelToolbar.Controls.Add(this.buttonELVBaseLoadItems);
            this.flowLayoutPanelToolbar.Controls.Add(this.checkBoxCheckAllNone);
            this.flowLayoutPanelToolbar.Controls.Add(this.labelFilter);
            this.flowLayoutPanelToolbar.Controls.Add(this.textFilterList);
            this.flowLayoutPanelToolbar.Controls.Add(this.buttonClearFilter);
            this.flowLayoutPanelToolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelToolbar.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelToolbar.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelToolbar.Name = "flowLayoutPanelToolbar";
            this.flowLayoutPanelToolbar.Size = new System.Drawing.Size(1051, 55);
            this.flowLayoutPanelToolbar.TabIndex = 8;
            this.flowLayoutPanelToolbar.WrapContents = false;
            // 
            // buttonELVBaseLoadItems
            // 
            this.buttonELVBaseLoadItems.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonELVBaseLoadItems.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonELVBaseLoadItems.Image = ((System.Drawing.Image)(resources.GetObject("buttonELVBaseLoadItems.Image")));
            this.buttonELVBaseLoadItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonELVBaseLoadItems.Location = new System.Drawing.Point(0, 0);
            this.buttonELVBaseLoadItems.Margin = new System.Windows.Forms.Padding(0);
            this.buttonELVBaseLoadItems.MinimumSize = new System.Drawing.Size(138, 26);
            this.buttonELVBaseLoadItems.Name = "buttonELVBaseLoadItems";
            this.buttonELVBaseLoadItems.Size = new System.Drawing.Size(160, 54);
            this.buttonELVBaseLoadItems.TabIndex = 0;
            this.buttonELVBaseLoadItems.Text = "Load Items";
            this.buttonELVBaseLoadItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonELVBaseLoadItems.UseVisualStyleBackColor = true;
            this.buttonELVBaseLoadItems.Click += new System.EventHandler(this.ToolButtonLoadItems_Click);
            // 
            // checkBoxCheckAllNone
            // 
            this.checkBoxCheckAllNone.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBoxCheckAllNone.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBoxCheckAllNone.FlatAppearance.BorderSize = 0;
            this.checkBoxCheckAllNone.Location = new System.Drawing.Point(178, 4);
            this.checkBoxCheckAllNone.Margin = new System.Windows.Forms.Padding(18, 4, 4, 4);
            this.checkBoxCheckAllNone.Name = "checkBoxCheckAllNone";
            this.checkBoxCheckAllNone.Size = new System.Drawing.Size(189, 46);
            this.checkBoxCheckAllNone.TabIndex = 6;
            this.checkBoxCheckAllNone.Text = "Check All/None";
            this.checkBoxCheckAllNone.UseVisualStyleBackColor = true;
            this.checkBoxCheckAllNone.CheckedChanged += new System.EventHandler(this.CheckBoxCheckAllNone_CheckedChanged);
            this.checkBoxCheckAllNone.CheckStateChanged += new System.EventHandler(this.CheckBoxCheckAllNone_CheckStateChanged);
            // 
            // labelFilter
            // 
            this.labelFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelFilter.Location = new System.Drawing.Point(389, 0);
            this.labelFilter.Margin = new System.Windows.Forms.Padding(18, 0, 6, 0);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(70, 54);
            this.labelFilter.TabIndex = 3;
            this.labelFilter.Text = "Filter:";
            this.labelFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textFilterList
            // 
            this.textFilterList.Dock = System.Windows.Forms.DockStyle.Left;
            this.textFilterList.Location = new System.Drawing.Point(465, 0);
            this.textFilterList.Margin = new System.Windows.Forms.Padding(0);
            this.textFilterList.MaxLength = 100;
            this.textFilterList.MinimumSize = new System.Drawing.Size(162, 46);
            this.textFilterList.Multiline = true;
            this.textFilterList.Name = "textFilterList";
            this.textFilterList.Size = new System.Drawing.Size(219, 54);
            this.textFilterList.TabIndex = 4;
            this.textFilterList.WordWrap = false;
            this.textFilterList.TextChanged += new System.EventHandler(this.ToolStripTextFilter_TextChanged);
            // 
            // buttonClearFilter
            // 
            this.buttonClearFilter.AutoSize = true;
            this.buttonClearFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonClearFilter.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonClearFilter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.125F);
            this.buttonClearFilter.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonClearFilter.Location = new System.Drawing.Point(684, 0);
            this.buttonClearFilter.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClearFilter.Name = "buttonClearFilter";
            this.buttonClearFilter.Size = new System.Drawing.Size(57, 54);
            this.buttonClearFilter.TabIndex = 5;
            this.buttonClearFilter.Text = "x";
            this.buttonClearFilter.UseVisualStyleBackColor = true;
            this.buttonClearFilter.Click += new System.EventHandler(this.ToolButtonClearFilter_Click);
            // 
            // splitContainerToolbar
            // 
            this.splitContainerToolbar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.splitContainerToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainerToolbar.Location = new System.Drawing.Point(0, 0);
            this.splitContainerToolbar.Margin = new System.Windows.Forms.Padding(6);
            this.splitContainerToolbar.Name = "splitContainerToolbar";
            // 
            // splitContainerToolbar.Panel1
            // 
            this.splitContainerToolbar.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainerToolbar.Panel1.Controls.Add(this.flowLayoutPanelToolbar);
            // 
            // splitContainerToolbar.Panel2
            // 
            this.splitContainerToolbar.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainerToolbar.Size = new System.Drawing.Size(1455, 55);
            this.splitContainerToolbar.SplitterDistance = 1051;
            this.splitContainerToolbar.SplitterWidth = 9;
            this.splitContainerToolbar.TabIndex = 1;
            // 
            // FilteredListViewBaseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ListViewMain);
            this.Controls.Add(this.splitContainerToolbar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FilteredListViewBaseControl";
            this.Size = new System.Drawing.Size(1455, 929);
            this.flowLayoutPanelToolbar.ResumeLayout(false);
            this.flowLayoutPanelToolbar.PerformLayout();
            this.splitContainerToolbar.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerToolbar)).EndInit();
            this.splitContainerToolbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.ListView ListViewMain;
        protected System.Windows.Forms.FlowLayoutPanel flowLayoutPanelToolbar;
        protected System.Windows.Forms.Button buttonELVBaseLoadItems;
        protected System.Windows.Forms.Label labelFilter;
        protected System.Windows.Forms.TextBox textFilterList;
        protected System.Windows.Forms.Button buttonClearFilter;
        protected System.Windows.Forms.ColumnHeader colDisplayName;
        protected System.Windows.Forms.ColumnHeader colName;
        protected System.Windows.Forms.ColumnHeader colSchemaName;
        protected System.Windows.Forms.ColumnHeader colState;
        protected System.Windows.Forms.ColumnHeader colDescription;
        protected System.Windows.Forms.SplitContainer splitContainerToolbar;
        protected System.Windows.Forms.CheckBox checkBoxCheckAllNone;
    }
}
