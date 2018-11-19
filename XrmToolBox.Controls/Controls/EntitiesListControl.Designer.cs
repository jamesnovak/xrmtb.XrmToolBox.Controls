namespace XrmToolBox.Controls
{
    partial class EntitiesListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntitiesListControl));
            this.ListViewEntities = new System.Windows.Forms.ListView();
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
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListViewEntities
            // 
            this.ListViewEntities.CheckBoxes = true;
            this.ListViewEntities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDisplayName,
            this.colName,
            this.colSchemaName,
            this.colState,
            this.colDescription});
            this.ListViewEntities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewEntities.FullRowSelect = true;
            listViewGroup1.Header = "System";
            listViewGroup1.Name = "System";
            listViewGroup1.Tag = "System";
            listViewGroup2.Header = "Custom";
            listViewGroup2.Name = "Custom";
            listViewGroup2.Tag = "Custom";
            this.ListViewEntities.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.ListViewEntities.HideSelection = false;
            this.ListViewEntities.Location = new System.Drawing.Point(0, 30);
            this.ListViewEntities.MultiSelect = false;
            this.ListViewEntities.Name = "ListViewEntities";
            this.ListViewEntities.Size = new System.Drawing.Size(840, 537);
            this.ListViewEntities.TabIndex = 3;
            this.ListViewEntities.Tag = "0";
            this.ListViewEntities.UseCompatibleStateImageBehavior = false;
            this.ListViewEntities.View = System.Windows.Forms.View.Details;
            this.ListViewEntities.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListViewEntities_ColumnClick);
            this.ListViewEntities.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.ListViewEntities_ItemChecked);
            this.ListViewEntities.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListViewEntities_ItemSelectionChanged);
            this.ListViewEntities.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ListViewEntities_KeyUp);
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
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolButtonLoadEntities,
            this.toolStripSeparator1,
            this.toolLinkCheckAll,
            this.toolLinkCheckNone,
            this.toolStripSeparator3,
            this.toolStripLabelFilter,
            this.toolStripTextFilter,
            this.toolStripSeparator2});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(840, 30);
            this.toolStripMain.TabIndex = 4;
            this.toolStripMain.Text = "Typescript Helper Class Utility";
            // 
            // toolButtonLoadEntities
            // 
            this.toolButtonLoadEntities.Image = ((System.Drawing.Image)(resources.GetObject("toolButtonLoadEntities.Image")));
            this.toolButtonLoadEntities.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonLoadEntities.Name = "toolButtonLoadEntities";
            this.toolButtonLoadEntities.Size = new System.Drawing.Size(94, 27);
            this.toolButtonLoadEntities.Text = "Load Entities";
            this.toolButtonLoadEntities.ToolTipText = "Load / Reload Entities from the server";
            this.toolButtonLoadEntities.Click += new System.EventHandler(this.ToolButtonLoadEntities_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // toolLinkCheckAll
            // 
            this.toolLinkCheckAll.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
            this.toolLinkCheckAll.AutoSize = false;
            this.toolLinkCheckAll.Image = ((System.Drawing.Image)(resources.GetObject("toolLinkCheckAll.Image")));
            this.toolLinkCheckAll.IsLink = true;
            this.toolLinkCheckAll.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.toolLinkCheckAll.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.toolLinkCheckAll.Name = "toolLinkCheckAll";
            this.toolLinkCheckAll.Size = new System.Drawing.Size(75, 22);
            this.toolLinkCheckAll.Text = "Check All";
            this.toolLinkCheckAll.ToolTipText = "Check all items in the list of Entities";
            this.toolLinkCheckAll.Click += new System.EventHandler(this.ToolLinkCheckAll_Click);
            // 
            // toolLinkCheckNone
            // 
            this.toolLinkCheckNone.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
            this.toolLinkCheckNone.Image = ((System.Drawing.Image)(resources.GetObject("toolLinkCheckNone.Image")));
            this.toolLinkCheckNone.IsLink = true;
            this.toolLinkCheckNone.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.toolLinkCheckNone.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.toolLinkCheckNone.Name = "toolLinkCheckNone";
            this.toolLinkCheckNone.Size = new System.Drawing.Size(88, 27);
            this.toolLinkCheckNone.Text = "Check None";
            this.toolLinkCheckNone.ToolTipText = "Clear the checked items in the list of Entities";
            this.toolLinkCheckNone.Click += new System.EventHandler(this.ToolLinkCheckNone_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 30);
            // 
            // toolStripLabelFilter
            // 
            this.toolStripLabelFilter.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabelFilter.Image")));
            this.toolStripLabelFilter.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripLabelFilter.Name = "toolStripLabelFilter";
            this.toolStripLabelFilter.Size = new System.Drawing.Size(49, 27);
            this.toolStripLabelFilter.Text = "Filter";
            // 
            // toolStripTextFilter
            // 
            this.toolStripTextFilter.MaxLength = 200;
            this.toolStripTextFilter.Name = "toolStripTextFilter";
            this.toolStripTextFilter.Size = new System.Drawing.Size(125, 30);
            this.toolStripTextFilter.ToolTipText = "Enter a filter for the list of entities";
            this.toolStripTextFilter.TextChanged += new System.EventHandler(this.ToolStripTextFilter_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 30);
            // 
            // EntitiesListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ListViewEntities);
            this.Controls.Add(this.toolStripMain);
            this.Name = "EntitiesListControl";
            this.Size = new System.Drawing.Size(840, 567);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListViewEntities;
        private System.Windows.Forms.ColumnHeader colDisplayName;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colSchemaName;
        private System.Windows.Forms.ColumnHeader colState;
        private System.Windows.Forms.ColumnHeader colDescription;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolButtonLoadEntities;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolLinkCheckAll;
        private System.Windows.Forms.ToolStripLabel toolLinkCheckNone;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabelFilter;
        private System.Windows.Forms.ToolStripTextBox toolStripTextFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}
