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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("System", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Custom", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilteredListViewBaseControl));
            this.ListViewMain = new System.Windows.Forms.ListView();
            this.colDisplayName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSchemaName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolButtonLoadEntities = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolLinkCheckAll = new System.Windows.Forms.ToolStripLabel();
            this.toolLinkCheckNone = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelFilter = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextFilter = new System.Windows.Forms.ToolStripTextBox();
            this.toolButtonClearFilter = new System.Windows.Forms.ToolStripButton();
            this.toolStripMain.SuspendLayout();
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
            this.ListViewMain.Location = new System.Drawing.Point(0, 58);
            this.ListViewMain.Margin = new System.Windows.Forms.Padding(6);
            this.ListViewMain.MultiSelect = false;
            this.ListViewMain.Name = "ListViewMain";
            this.ListViewMain.Size = new System.Drawing.Size(1174, 909);
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
            // toolStripMain
            // 
            this.toolStripMain.AutoSize = false;
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolButtonLoadEntities,
            this.toolStripSeparator1,
            this.toolLinkCheckAll,
            this.toolLinkCheckNone,
            this.toolStripSeparator3,
            this.toolStripLabelFilter,
            this.toolStripTextFilter,
            this.toolButtonClearFilter});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripMain.Size = new System.Drawing.Size(1174, 58);
            this.toolStripMain.TabIndex = 6;
            this.toolStripMain.Text = "Typescript Helper Class Utility";
            // 
            // toolButtonLoadEntities
            // 
            this.toolButtonLoadEntities.AutoSize = false;
            this.toolButtonLoadEntities.Image = ((System.Drawing.Image)(resources.GetObject("toolButtonLoadEntities.Image")));
            this.toolButtonLoadEntities.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolButtonLoadEntities.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonLoadEntities.Name = "toolButtonLoadEntities";
            this.toolButtonLoadEntities.Size = new System.Drawing.Size(90, 27);
            this.toolButtonLoadEntities.Text = "Load Items";
            this.toolButtonLoadEntities.ToolTipText = "Load / Reload Entities from the server";
            this.toolButtonLoadEntities.Click += new System.EventHandler(this.ToolButtonLoadEntities_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 58);
            // 
            // toolLinkCheckAll
            // 
            this.toolLinkCheckAll.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
            this.toolLinkCheckAll.AutoSize = false;
            this.toolLinkCheckAll.Image = ((System.Drawing.Image)(resources.GetObject("toolLinkCheckAll.Image")));
            this.toolLinkCheckAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolLinkCheckAll.IsLink = true;
            this.toolLinkCheckAll.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.toolLinkCheckAll.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.toolLinkCheckAll.Name = "toolLinkCheckAll";
            this.toolLinkCheckAll.Size = new System.Drawing.Size(95, 22);
            this.toolLinkCheckAll.Text = "Check All";
            this.toolLinkCheckAll.ToolTipText = "Check all items in the list of Entities";
            this.toolLinkCheckAll.Click += new System.EventHandler(this.ToolLinkCheckAll_Click);
            // 
            // toolLinkCheckNone
            // 
            this.toolLinkCheckNone.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
            this.toolLinkCheckNone.AutoSize = false;
            this.toolLinkCheckNone.Image = ((System.Drawing.Image)(resources.GetObject("toolLinkCheckNone.Image")));
            this.toolLinkCheckNone.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolLinkCheckNone.IsLink = true;
            this.toolLinkCheckNone.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.toolLinkCheckNone.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.toolLinkCheckNone.Name = "toolLinkCheckNone";
            this.toolLinkCheckNone.Size = new System.Drawing.Size(95, 27);
            this.toolLinkCheckNone.Text = "Check None";
            this.toolLinkCheckNone.ToolTipText = "Clear the checked items in the list of Entities";
            this.toolLinkCheckNone.Click += new System.EventHandler(this.ToolLinkCheckNone_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 58);
            // 
            // toolStripLabelFilter
            // 
            this.toolStripLabelFilter.AutoSize = false;
            this.toolStripLabelFilter.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabelFilter.Image")));
            this.toolStripLabelFilter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLabelFilter.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripLabelFilter.Name = "toolStripLabelFilter";
            this.toolStripLabelFilter.Size = new System.Drawing.Size(60, 27);
            this.toolStripLabelFilter.Text = "Filter:";
            // 
            // toolStripTextFilter
            // 
            this.toolStripTextFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextFilter.MaxLength = 200;
            this.toolStripTextFilter.Name = "toolStripTextFilter";
            this.toolStripTextFilter.Size = new System.Drawing.Size(248, 58);
            this.toolStripTextFilter.ToolTipText = "Enter a filter for the list of entities";
            this.toolStripTextFilter.TextChanged += new System.EventHandler(this.ToolStripTextFilter_TextChanged);
            // 
            // toolButtonClearFilter
            // 
            this.toolButtonClearFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolButtonClearFilter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolButtonClearFilter.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolButtonClearFilter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolButtonClearFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonClearFilter.Name = "toolButtonClearFilter";
            this.toolButtonClearFilter.Size = new System.Drawing.Size(33, 55);
            this.toolButtonClearFilter.Text = "x";
            this.toolButtonClearFilter.ToolTipText = "Clear the current filter";
            this.toolButtonClearFilter.Click += new System.EventHandler(this.ToolButtonClearFilter_Click);
            // 
            // FilteredListViewBaseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ListViewMain);
            this.Controls.Add(this.toolStripMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FilteredListViewBaseControl";
            this.Size = new System.Drawing.Size(1174, 967);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader colDisplayName;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colSchemaName;
        private System.Windows.Forms.ColumnHeader colState;
        private System.Windows.Forms.ColumnHeader colDescription;
        protected System.Windows.Forms.ListView ListViewMain;
        protected System.Windows.Forms.ToolStripButton toolButtonLoadEntities;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        protected System.Windows.Forms.ToolStripLabel toolLinkCheckAll;
        protected System.Windows.Forms.ToolStripLabel toolLinkCheckNone;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        protected System.Windows.Forms.ToolStripLabel toolStripLabelFilter;
        protected System.Windows.Forms.ToolStripTextBox toolStripTextFilter;
        protected System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolButtonClearFilter;
    }
}
