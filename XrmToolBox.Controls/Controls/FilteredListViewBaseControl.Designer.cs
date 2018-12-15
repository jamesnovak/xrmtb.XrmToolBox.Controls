namespace XrmToolBox.Controls
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
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("System", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("Custom", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilteredListViewBaseControl));
            this.ListViewMain = new System.Windows.Forms.ListView();
            this.colDisplayName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSchemaName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanelToolbar = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonLoadItems = new System.Windows.Forms.Button();
            this.buttonCheckAll = new System.Windows.Forms.Button();
            this.buttonCheckNone = new System.Windows.Forms.Button();
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
            listViewGroup7.Header = "System";
            listViewGroup7.Name = "System";
            listViewGroup7.Tag = "System";
            listViewGroup8.Header = "Custom";
            listViewGroup8.Name = "Custom";
            listViewGroup8.Tag = "Custom";
            this.ListViewMain.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup7,
            listViewGroup8});
            this.ListViewMain.HideSelection = false;
            this.ListViewMain.Location = new System.Drawing.Point(0, 30);
            this.ListViewMain.MultiSelect = false;
            this.ListViewMain.Name = "ListViewMain";
            this.ListViewMain.Size = new System.Drawing.Size(822, 473);
            this.ListViewMain.TabIndex = 5;
            this.ListViewMain.Tag = "0";
            this.ListViewMain.UseCompatibleStateImageBehavior = false;
            this.ListViewMain.View = System.Windows.Forms.View.Details;
            this.ListViewMain.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListViewMain_ColumnClick);
            this.ListViewMain.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.ListViewMain_ItemChecked);
            this.ListViewMain.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListViewMain_ItemSelectionChanged);
            this.ListViewMain.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ListViewMain_KeyUp);
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
            this.flowLayoutPanelToolbar.Controls.Add(this.buttonLoadItems);
            this.flowLayoutPanelToolbar.Controls.Add(this.buttonCheckAll);
            this.flowLayoutPanelToolbar.Controls.Add(this.buttonCheckNone);
            this.flowLayoutPanelToolbar.Controls.Add(this.labelFilter);
            this.flowLayoutPanelToolbar.Controls.Add(this.textFilterList);
            this.flowLayoutPanelToolbar.Controls.Add(this.buttonClearFilter);
            this.flowLayoutPanelToolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelToolbar.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelToolbar.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelToolbar.Name = "flowLayoutPanelToolbar";
            this.flowLayoutPanelToolbar.Size = new System.Drawing.Size(600, 30);
            this.flowLayoutPanelToolbar.TabIndex = 8;
            // 
            // buttonLoadItems
            // 
            this.buttonLoadItems.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLoadItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadItems.Image = ((System.Drawing.Image)(resources.GetObject("buttonLoadItems.Image")));
            this.buttonLoadItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLoadItems.Location = new System.Drawing.Point(0, 0);
            this.buttonLoadItems.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLoadItems.MinimumSize = new System.Drawing.Size(75, 14);
            this.buttonLoadItems.Name = "buttonLoadItems";
            this.buttonLoadItems.Size = new System.Drawing.Size(88, 27);
            this.buttonLoadItems.TabIndex = 0;
            this.buttonLoadItems.Text = "Load Items";
            this.buttonLoadItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLoadItems.UseVisualStyleBackColor = true;
            this.buttonLoadItems.Click += new System.EventHandler(this.ToolButtonLoadItems_Click);
            // 
            // buttonCheckAll
            // 
            this.buttonCheckAll.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCheckAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckAll.Image = ((System.Drawing.Image)(resources.GetObject("buttonCheckAll.Image")));
            this.buttonCheckAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCheckAll.Location = new System.Drawing.Point(88, 0);
            this.buttonCheckAll.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCheckAll.MinimumSize = new System.Drawing.Size(75, 14);
            this.buttonCheckAll.Name = "buttonCheckAll";
            this.buttonCheckAll.Size = new System.Drawing.Size(88, 27);
            this.buttonCheckAll.TabIndex = 1;
            this.buttonCheckAll.Text = "Check All";
            this.buttonCheckAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCheckAll.UseVisualStyleBackColor = true;
            this.buttonCheckAll.Click += new System.EventHandler(this.ToolLinkCheckAll_Click);
            // 
            // buttonCheckNone
            // 
            this.buttonCheckNone.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCheckNone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckNone.Image = ((System.Drawing.Image)(resources.GetObject("buttonCheckNone.Image")));
            this.buttonCheckNone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCheckNone.Location = new System.Drawing.Point(176, 0);
            this.buttonCheckNone.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCheckNone.MinimumSize = new System.Drawing.Size(75, 14);
            this.buttonCheckNone.Name = "buttonCheckNone";
            this.buttonCheckNone.Size = new System.Drawing.Size(96, 27);
            this.buttonCheckNone.TabIndex = 2;
            this.buttonCheckNone.Text = "Check None";
            this.buttonCheckNone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCheckNone.UseVisualStyleBackColor = true;
            this.buttonCheckNone.Click += new System.EventHandler(this.ToolLinkCheckNone_Click);
            // 
            // labelFilter
            // 
            this.labelFilter.Location = new System.Drawing.Point(272, 0);
            this.labelFilter.Margin = new System.Windows.Forms.Padding(0);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(44, 27);
            this.labelFilter.TabIndex = 3;
            this.labelFilter.Text = "Filter:";
            this.labelFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textFilterList
            // 
            this.textFilterList.Location = new System.Drawing.Point(316, 0);
            this.textFilterList.Margin = new System.Windows.Forms.Padding(0);
            this.textFilterList.MaxLength = 100;
            this.textFilterList.MinimumSize = new System.Drawing.Size(90, 27);
            this.textFilterList.Multiline = true;
            this.textFilterList.Name = "textFilterList";
            this.textFilterList.Size = new System.Drawing.Size(121, 27);
            this.textFilterList.TabIndex = 4;
            this.textFilterList.WordWrap = false;
            this.textFilterList.TextChanged += new System.EventHandler(this.ToolStripTextFilter_TextChanged);
            // 
            // buttonClearFilter
            // 
            this.buttonClearFilter.AutoSize = true;
            this.buttonClearFilter.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearFilter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.125F);
            this.buttonClearFilter.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonClearFilter.Location = new System.Drawing.Point(437, 0);
            this.buttonClearFilter.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClearFilter.Name = "buttonClearFilter";
            this.buttonClearFilter.Size = new System.Drawing.Size(27, 30);
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
            this.splitContainerToolbar.Size = new System.Drawing.Size(822, 30);
            this.splitContainerToolbar.SplitterDistance = 600;
            this.splitContainerToolbar.SplitterWidth = 5;
            this.splitContainerToolbar.TabIndex = 1;
            // 
            // FilteredListViewBaseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ListViewMain);
            this.Controls.Add(this.splitContainerToolbar);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "FilteredListViewBaseControl";
            this.Size = new System.Drawing.Size(822, 503);
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
        protected System.Windows.Forms.Button buttonLoadItems;
        protected System.Windows.Forms.Button buttonCheckAll;
        protected System.Windows.Forms.Button buttonCheckNone;
        protected System.Windows.Forms.Label labelFilter;
        protected System.Windows.Forms.TextBox textFilterList;
        protected System.Windows.Forms.Button buttonClearFilter;
        protected System.Windows.Forms.ColumnHeader colDisplayName;
        protected System.Windows.Forms.ColumnHeader colName;
        protected System.Windows.Forms.ColumnHeader colSchemaName;
        protected System.Windows.Forms.ColumnHeader colState;
        protected System.Windows.Forms.ColumnHeader colDescription;
        protected System.Windows.Forms.SplitContainer splitContainerToolbar;
    }
}
