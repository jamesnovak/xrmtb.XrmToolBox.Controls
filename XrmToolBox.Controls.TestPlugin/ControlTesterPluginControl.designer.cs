using System.ComponentModel;

namespace XrmToolBox.Controls
{
    partial class ControlTesterPluginControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlTesterPluginControl));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolButton_LoadData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolButton_ClearData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolButton_UpdateConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.toolButton_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelFilter = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextFilter = new System.Windows.Forms.ToolStripTextBox();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageEntList = new System.Windows.Forms.TabPage();
            this.splitterEntityList = new System.Windows.Forms.SplitContainer();
            this.EntityListControl = new XrmToolBox.Controls.EntitiesListControl();
            this.tableEntListDetails = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioEntListShowProps = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioEntListShowEnt = new System.Windows.Forms.RadioButton();
            this.propGridEntList = new System.Windows.Forms.PropertyGrid();
            this.textEntListLog = new System.Windows.Forms.TextBox();
            this.tabPageEntDropdown = new System.Windows.Forms.TabPage();
            this.splitterEntDropdown = new System.Windows.Forms.SplitContainer();
            this.tableEntDropdown = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.EntityDropdown = new XrmToolBox.Controls.EntitiesDropdownControl();
            this.labelEntityDropdown = new System.Windows.Forms.Label();
            this.listBoxEntities = new System.Windows.Forms.ListBox();
            this.tableEntDropdownDetail = new System.Windows.Forms.TableLayoutPanel();
            this.propGridEntDropdown = new System.Windows.Forms.PropertyGrid();
            this.textEntDropdownLog = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.radioEntDropdownShowEnt = new System.Windows.Forms.RadioButton();
            this.radioEntDropdownShowProps = new System.Windows.Forms.RadioButton();
            this.tabPageAttrList = new System.Windows.Forms.TabPage();
            this.splitterAttribList = new System.Windows.Forms.SplitContainer();
            this.tableAttribList = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.EntityDropdownAttribList = new XrmToolBox.Controls.EntitiesDropdownControl();
            this.label11 = new System.Windows.Forms.Label();
            this.AttribListControl = new XrmToolBox.Controls.AttributeListControl();
            this.tableAttribListDetail = new System.Windows.Forms.TableLayoutPanel();
            this.propGridAttrList = new System.Windows.Forms.PropertyGrid();
            this.textAttribListLog = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.radioAttribListShowProps = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.radioAttribListShowAttrib = new System.Windows.Forms.RadioButton();
            this.tabPageAttrDropDown = new System.Windows.Forms.TabPage();
            this.splitterAttribDropdown = new System.Windows.Forms.SplitContainer();
            this.tableAttribDropdown = new System.Windows.Forms.TableLayoutPanel();
            this.AttributeDropdown = new XrmToolBox.Controls.AttributeDropdownControl();
            this.labelAttributes = new System.Windows.Forms.Label();
            this.EntityDropdownAttribs = new XrmToolBox.Controls.EntitiesDropdownControl();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxAttributes = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableAttribDropdownDetail = new System.Windows.Forms.TableLayoutPanel();
            this.propGridAttribDropdown = new System.Windows.Forms.PropertyGrid();
            this.textAttribDropdownLog = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioAttribDropdownShowProps = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.radioAttribDropdownShowAttrib = new System.Windows.Forms.RadioButton();
            this.tabPageSolution = new System.Windows.Forms.TabPage();
            this.splitterSolnDropdown = new System.Windows.Forms.SplitContainer();
            this.tableSolnDropdown = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.SolutionDropdown = new XrmToolBox.Controls.SolutionsDropdownControl();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxSolutions = new System.Windows.Forms.ListBox();
            this.tableSolnDropdownDetail = new System.Windows.Forms.TableLayoutPanel();
            this.propGridSolutions = new System.Windows.Forms.PropertyGrid();
            this.textSolnDropdownLog = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radioSolnDropdownShowProps = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.radioSolnDropdownShowSoln = new System.Windows.Forms.RadioButton();
            this.toolStripMenu.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageEntList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitterEntityList)).BeginInit();
            this.splitterEntityList.Panel1.SuspendLayout();
            this.splitterEntityList.Panel2.SuspendLayout();
            this.splitterEntityList.SuspendLayout();
            this.tableEntListDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageEntDropdown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitterEntDropdown)).BeginInit();
            this.splitterEntDropdown.Panel1.SuspendLayout();
            this.splitterEntDropdown.Panel2.SuspendLayout();
            this.splitterEntDropdown.SuspendLayout();
            this.tableEntDropdown.SuspendLayout();
            this.tableEntDropdownDetail.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPageAttrList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitterAttribList)).BeginInit();
            this.splitterAttribList.Panel1.SuspendLayout();
            this.splitterAttribList.Panel2.SuspendLayout();
            this.splitterAttribList.SuspendLayout();
            this.tableAttribList.SuspendLayout();
            this.tableAttribListDetail.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabPageAttrDropDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitterAttribDropdown)).BeginInit();
            this.splitterAttribDropdown.Panel1.SuspendLayout();
            this.splitterAttribDropdown.Panel2.SuspendLayout();
            this.splitterAttribDropdown.SuspendLayout();
            this.tableAttribDropdown.SuspendLayout();
            this.tableAttribDropdownDetail.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPageSolution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitterSolnDropdown)).BeginInit();
            this.splitterSolnDropdown.Panel1.SuspendLayout();
            this.splitterSolnDropdown.Panel2.SuspendLayout();
            this.splitterSolnDropdown.SuspendLayout();
            this.tableSolnDropdown.SuspendLayout();
            this.tableSolnDropdownDetail.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.tssSeparator1,
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.toolStripLabelFilter,
            this.toolStripTextFilter});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(835, 25);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(86, 22);
            this.tsbClose.Text = "Close this tool";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolButton_LoadData,
            this.toolButton_ClearData,
            this.toolButton_UpdateConnection,
            this.toolButton_Close});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(138, 22);
            this.toolStripDropDownButton1.Text = "Call External Method...";
            // 
            // toolButton_LoadData
            // 
            this.toolButton_LoadData.Name = "toolButton_LoadData";
            this.toolButton_LoadData.Size = new System.Drawing.Size(182, 22);
            this.toolButton_LoadData.Text = "LoadData()";
            this.toolButton_LoadData.Click += new System.EventHandler(this.ToolButtonLoadData_Click);
            // 
            // toolButton_ClearData
            // 
            this.toolButton_ClearData.Name = "toolButton_ClearData";
            this.toolButton_ClearData.Size = new System.Drawing.Size(182, 22);
            this.toolButton_ClearData.Text = "ClearData()";
            this.toolButton_ClearData.Click += new System.EventHandler(this.ToolButtonClearData_Click);
            // 
            // toolButton_UpdateConnection
            // 
            this.toolButton_UpdateConnection.Name = "toolButton_UpdateConnection";
            this.toolButton_UpdateConnection.Size = new System.Drawing.Size(182, 22);
            this.toolButton_UpdateConnection.Text = "UpdateConnection()";
            this.toolButton_UpdateConnection.Click += new System.EventHandler(this.ToolButtonUpdateConnection_Click);
            // 
            // toolButton_Close
            // 
            this.toolButton_Close.Name = "toolButton_Close";
            this.toolButton_Close.Size = new System.Drawing.Size(182, 22);
            this.toolButton_Close.Text = "Close()";
            this.toolButton_Close.Click += new System.EventHandler(this.ToolButtonClose_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelFilter
            // 
            this.toolStripLabelFilter.Name = "toolStripLabelFilter";
            this.toolStripLabelFilter.Size = new System.Drawing.Size(82, 22);
            this.toolStripLabelFilter.Text = "Filter ListView:";
            // 
            // toolStripTextFilter
            // 
            this.toolStripTextFilter.Name = "toolStripTextFilter";
            this.toolStripTextFilter.Size = new System.Drawing.Size(102, 25);
            this.toolStripTextFilter.TextChanged += new System.EventHandler(this.toolStripTextFilter_TextChanged);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlMain.Controls.Add(this.tabPageEntList);
            this.tabControlMain.Controls.Add(this.tabPageEntDropdown);
            this.tabControlMain.Controls.Add(this.tabPageAttrList);
            this.tabControlMain.Controls.Add(this.tabPageAttrDropDown);
            this.tabControlMain.Controls.Add(this.tabPageSolution);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.ItemSize = new System.Drawing.Size(175, 30);
            this.tabControlMain.Location = new System.Drawing.Point(0, 25);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(835, 602);
            this.tabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlMain.TabIndex = 7;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabPageEntList
            // 
            this.tabPageEntList.Controls.Add(this.splitterEntityList);
            this.tabPageEntList.Location = new System.Drawing.Point(4, 34);
            this.tabPageEntList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageEntList.Name = "tabPageEntList";
            this.tabPageEntList.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageEntList.Size = new System.Drawing.Size(827, 564);
            this.tabPageEntList.TabIndex = 0;
            this.tabPageEntList.Text = "Entity List Control";
            // 
            // splitterEntityList
            // 
            this.splitterEntityList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitterEntityList.Location = new System.Drawing.Point(3, 3);
            this.splitterEntityList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitterEntityList.Name = "splitterEntityList";
            // 
            // splitterEntityList.Panel1
            // 
            this.splitterEntityList.Panel1.Controls.Add(this.EntityListControl);
            // 
            // splitterEntityList.Panel2
            // 
            this.splitterEntityList.Panel2.Controls.Add(this.tableEntListDetails);
            this.splitterEntityList.Size = new System.Drawing.Size(821, 558);
            this.splitterEntityList.SplitterDistance = 273;
            this.splitterEntityList.SplitterWidth = 10;
            this.splitterEntityList.TabIndex = 0;
            // 
            // EntityListControl
            // 
            this.EntityListControl.AutoLoadData = false;
            this.EntityListControl.AutosizeColumns = System.Windows.Forms.ColumnHeaderAutoResizeStyle.None;
            this.EntityListControl.Checkboxes = true;
            this.EntityListControl.DisplayToolbar = false;
            this.EntityListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EntityListControl.EntityTypes = XrmToolBox.Controls.EnumEntityTypes.BothCustomAndSystem;
            this.EntityListControl.LanguageCode = 1033;
            this.EntityListControl.ListViewColDefs = new XrmToolBox.Controls.ListViewColumnDef[] {
        ((XrmToolBox.Controls.ListViewColumnDef)(resources.GetObject("EntityListControl.ListViewColDefs"))),
        ((XrmToolBox.Controls.ListViewColumnDef)(resources.GetObject("EntityListControl.ListViewColDefs1"))),
        ((XrmToolBox.Controls.ListViewColumnDef)(resources.GetObject("EntityListControl.ListViewColDefs2"))),
        ((XrmToolBox.Controls.ListViewColumnDef)(resources.GetObject("EntityListControl.ListViewColDefs3"))),
        ((XrmToolBox.Controls.ListViewColumnDef)(resources.GetObject("EntityListControl.ListViewColDefs4")))};
            this.EntityListControl.Location = new System.Drawing.Point(0, 0);
            this.EntityListControl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.EntityListControl.Name = "EntityListControl";
            this.EntityListControl.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EntityListControl.RetrieveAsIfPublished = true;
            this.EntityListControl.Service = null;
            this.EntityListControl.Size = new System.Drawing.Size(273, 558);
            this.EntityListControl.TabIndex = 13;
            this.EntityListControl.SelectedItemChanged += new System.EventHandler(this.EntitiesListControl_SelectedItemChanged);
            this.EntityListControl.CheckedItemsChanged += new System.EventHandler(this.EntitiesListControl_CheckedItemsChanged);
            this.EntityListControl.ProgressChanged += new System.EventHandler<System.ComponentModel.ProgressChangedEventArgs>(this.EntitiesListControl_ProgressChanged);
            this.EntityListControl.LoadDataComplete += new System.EventHandler(this.EntitiesListControl_LoadDataComplete);
            this.EntityListControl.ClearDataComplete += new System.EventHandler(this.EntitiesListControl_ClearDataComplete);
            this.EntityListControl.CloseComplete += new System.EventHandler(this.EntitiesListControl_CloseComplete);
            this.EntityListControl.NotificationMessage += new System.EventHandler<XrmToolBox.Controls.NotificationEventArgs>(this.AllControls_NotificationMessage);
            // 
            // tableEntListDetails
            // 
            this.tableEntListDetails.ColumnCount = 2;
            this.tableEntListDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableEntListDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableEntListDetails.Controls.Add(this.panel1, 0, 1);
            this.tableEntListDetails.Controls.Add(this.propGridEntList, 0, 0);
            this.tableEntListDetails.Controls.Add(this.textEntListLog, 1, 0);
            this.tableEntListDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableEntListDetails.Location = new System.Drawing.Point(0, 0);
            this.tableEntListDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableEntListDetails.Name = "tableEntListDetails";
            this.tableEntListDetails.RowCount = 2;
            this.tableEntListDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableEntListDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableEntListDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableEntListDetails.Size = new System.Drawing.Size(546, 558);
            this.tableEntListDetails.TabIndex = 20;
            // 
            // panel1
            // 
            this.tableEntListDetails.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.radioEntListShowProps);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioEntListShowEnt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 504);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 52);
            this.panel1.TabIndex = 16;
            // 
            // radioEntListShowProps
            // 
            this.radioEntListShowProps.AutoSize = true;
            this.radioEntListShowProps.Checked = true;
            this.radioEntListShowProps.Location = new System.Drawing.Point(10, 27);
            this.radioEntListShowProps.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioEntListShowProps.Name = "radioEntListShowProps";
            this.radioEntListShowProps.Size = new System.Drawing.Size(132, 17);
            this.radioEntListShowProps.TabIndex = 3;
            this.radioEntListShowProps.TabStop = true;
            this.radioEntListShowProps.Text = "Entity List View Control";
            this.radioEntListShowProps.UseVisualStyleBackColor = true;
            this.radioEntListShowProps.CheckedChanged += new System.EventHandler(this.RadioEntitiesList_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose what displays in the property control";
            // 
            // radioEntListShowEnt
            // 
            this.radioEntListShowEnt.AutoSize = true;
            this.radioEntListShowEnt.Location = new System.Drawing.Point(150, 27);
            this.radioEntListShowEnt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioEntListShowEnt.Name = "radioEntListShowEnt";
            this.radioEntListShowEnt.Size = new System.Drawing.Size(96, 17);
            this.radioEntListShowEnt.TabIndex = 2;
            this.radioEntListShowEnt.TabStop = true;
            this.radioEntListShowEnt.Text = "Selected Entity";
            this.radioEntListShowEnt.UseVisualStyleBackColor = true;
            this.radioEntListShowEnt.CheckedChanged += new System.EventHandler(this.RadioEntitiesList_CheckedChanged);
            // 
            // propGridEntList
            // 
            this.propGridEntList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propGridEntList.Location = new System.Drawing.Point(4, 3);
            this.propGridEntList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.propGridEntList.Name = "propGridEntList";
            this.propGridEntList.Size = new System.Drawing.Size(265, 496);
            this.propGridEntList.TabIndex = 8;
            // 
            // textEntListLog
            // 
            this.textEntListLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEntListLog.Location = new System.Drawing.Point(277, 3);
            this.textEntListLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textEntListLog.Multiline = true;
            this.textEntListLog.Name = "textEntListLog";
            this.textEntListLog.ReadOnly = true;
            this.textEntListLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textEntListLog.Size = new System.Drawing.Size(265, 496);
            this.textEntListLog.TabIndex = 7;
            // 
            // tabPageEntDropdown
            // 
            this.tabPageEntDropdown.Controls.Add(this.splitterEntDropdown);
            this.tabPageEntDropdown.Location = new System.Drawing.Point(4, 34);
            this.tabPageEntDropdown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageEntDropdown.Name = "tabPageEntDropdown";
            this.tabPageEntDropdown.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageEntDropdown.Size = new System.Drawing.Size(827, 569);
            this.tabPageEntDropdown.TabIndex = 1;
            this.tabPageEntDropdown.Text = "Entity Dropdown Control";
            this.tabPageEntDropdown.UseVisualStyleBackColor = true;
            // 
            // splitterEntDropdown
            // 
            this.splitterEntDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitterEntDropdown.Location = new System.Drawing.Point(3, 3);
            this.splitterEntDropdown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitterEntDropdown.Name = "splitterEntDropdown";
            // 
            // splitterEntDropdown.Panel1
            // 
            this.splitterEntDropdown.Panel1.Controls.Add(this.tableEntDropdown);
            // 
            // splitterEntDropdown.Panel2
            // 
            this.splitterEntDropdown.Panel2.Controls.Add(this.tableEntDropdownDetail);
            this.splitterEntDropdown.Size = new System.Drawing.Size(821, 563);
            this.splitterEntDropdown.SplitterDistance = 273;
            this.splitterEntDropdown.SplitterWidth = 10;
            this.splitterEntDropdown.TabIndex = 18;
            // 
            // tableEntDropdown
            // 
            this.tableEntDropdown.ColumnCount = 1;
            this.tableEntDropdown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableEntDropdown.Controls.Add(this.label7, 0, 2);
            this.tableEntDropdown.Controls.Add(this.EntityDropdown, 0, 1);
            this.tableEntDropdown.Controls.Add(this.labelEntityDropdown, 0, 0);
            this.tableEntDropdown.Controls.Add(this.listBoxEntities, 0, 3);
            this.tableEntDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableEntDropdown.Location = new System.Drawing.Point(0, 0);
            this.tableEntDropdown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableEntDropdown.Name = "tableEntDropdown";
            this.tableEntDropdown.RowCount = 4;
            this.tableEntDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableEntDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableEntDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableEntDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableEntDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableEntDropdown.Size = new System.Drawing.Size(273, 563);
            this.tableEntDropdown.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(3, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "Full list of Entities";
            // 
            // EntityDropdown
            // 
            this.EntityDropdown.AutoLoadData = false;
            this.EntityDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EntityDropdown.LanguageCode = 1033;
            this.EntityDropdown.Location = new System.Drawing.Point(4, 29);
            this.EntityDropdown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EntityDropdown.Name = "EntityDropdown";
            this.EntityDropdown.Service = null;
            this.EntityDropdown.Size = new System.Drawing.Size(265, 30);
            this.EntityDropdown.TabIndex = 15;
            this.EntityDropdown.SelectedItemChanged += new System.EventHandler(this.EntityDropdown_SelectedItemChanged);
            this.EntityDropdown.ProgressChanged += new System.EventHandler<System.ComponentModel.ProgressChangedEventArgs>(this.EntityDropdown_ProgressChanged);
            this.EntityDropdown.BeginLoadData += new System.EventHandler(this.EntityDropdown_BeginLoadData);
            this.EntityDropdown.LoadDataComplete += new System.EventHandler(this.EntityDropdown_LoadDataComplete);
            this.EntityDropdown.BeginClearData += new System.EventHandler(this.EntityDropdown_BeginClearData);
            this.EntityDropdown.ClearDataComplete += new System.EventHandler(this.EntityDropdown_ClearDataComplete);
            this.EntityDropdown.NotificationMessage += new System.EventHandler<XrmToolBox.Controls.NotificationEventArgs>(this.AllControls_NotificationMessage);
            // 
            // labelEntityDropdown
            // 
            this.labelEntityDropdown.Location = new System.Drawing.Point(2, 0);
            this.labelEntityDropdown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEntityDropdown.Name = "labelEntityDropdown";
            this.labelEntityDropdown.Size = new System.Drawing.Size(260, 15);
            this.labelEntityDropdown.TabIndex = 0;
            this.labelEntityDropdown.Text = "Entity Dropdown Control";
            // 
            // listBoxEntities
            // 
            this.listBoxEntities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxEntities.FormattingEnabled = true;
            this.listBoxEntities.Location = new System.Drawing.Point(3, 91);
            this.listBoxEntities.Name = "listBoxEntities";
            this.listBoxEntities.Size = new System.Drawing.Size(267, 489);
            this.listBoxEntities.TabIndex = 16;
            // 
            // tableEntDropdownDetail
            // 
            this.tableEntDropdownDetail.ColumnCount = 2;
            this.tableEntDropdownDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableEntDropdownDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableEntDropdownDetail.Controls.Add(this.propGridEntDropdown, 0, 0);
            this.tableEntDropdownDetail.Controls.Add(this.textEntDropdownLog, 1, 0);
            this.tableEntDropdownDetail.Controls.Add(this.panel3, 0, 1);
            this.tableEntDropdownDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableEntDropdownDetail.Location = new System.Drawing.Point(0, 0);
            this.tableEntDropdownDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableEntDropdownDetail.Name = "tableEntDropdownDetail";
            this.tableEntDropdownDetail.RowCount = 2;
            this.tableEntDropdownDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableEntDropdownDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableEntDropdownDetail.Size = new System.Drawing.Size(546, 563);
            this.tableEntDropdownDetail.TabIndex = 21;
            // 
            // propGridEntDropdown
            // 
            this.propGridEntDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propGridEntDropdown.Location = new System.Drawing.Point(4, 3);
            this.propGridEntDropdown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.propGridEntDropdown.Name = "propGridEntDropdown";
            this.propGridEntDropdown.Size = new System.Drawing.Size(265, 500);
            this.propGridEntDropdown.TabIndex = 8;
            // 
            // textEntDropdownLog
            // 
            this.textEntDropdownLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEntDropdownLog.Location = new System.Drawing.Point(277, 3);
            this.textEntDropdownLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textEntDropdownLog.Multiline = true;
            this.textEntDropdownLog.Name = "textEntDropdownLog";
            this.textEntDropdownLog.ReadOnly = true;
            this.textEntDropdownLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textEntDropdownLog.Size = new System.Drawing.Size(265, 500);
            this.textEntDropdownLog.TabIndex = 7;
            // 
            // panel3
            // 
            this.tableEntDropdownDetail.SetColumnSpan(this.panel3, 2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.radioEntDropdownShowEnt);
            this.panel3.Controls.Add(this.radioEntDropdownShowProps);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(2, 508);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(542, 53);
            this.panel3.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(542, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Choose what displays in the property control";
            // 
            // radioEntDropdownShowEnt
            // 
            this.radioEntDropdownShowEnt.Location = new System.Drawing.Point(170, 20);
            this.radioEntDropdownShowEnt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioEntDropdownShowEnt.Name = "radioEntDropdownShowEnt";
            this.radioEntDropdownShowEnt.Size = new System.Drawing.Size(135, 23);
            this.radioEntDropdownShowEnt.TabIndex = 2;
            this.radioEntDropdownShowEnt.TabStop = true;
            this.radioEntDropdownShowEnt.Text = "Selected Entity";
            this.radioEntDropdownShowEnt.UseVisualStyleBackColor = true;
            this.radioEntDropdownShowEnt.CheckedChanged += new System.EventHandler(this.RadioEntDropdown_CheckedChanged);
            // 
            // radioEntDropdownShowProps
            // 
            this.radioEntDropdownShowProps.Checked = true;
            this.radioEntDropdownShowProps.Location = new System.Drawing.Point(14, 20);
            this.radioEntDropdownShowProps.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioEntDropdownShowProps.Name = "radioEntDropdownShowProps";
            this.radioEntDropdownShowProps.Size = new System.Drawing.Size(148, 23);
            this.radioEntDropdownShowProps.TabIndex = 3;
            this.radioEntDropdownShowProps.TabStop = true;
            this.radioEntDropdownShowProps.Text = "Entity Dropdown Control";
            this.radioEntDropdownShowProps.UseVisualStyleBackColor = true;
            this.radioEntDropdownShowProps.CheckedChanged += new System.EventHandler(this.RadioEntDropdown_CheckedChanged);
            // 
            // tabPageAttrList
            // 
            this.tabPageAttrList.Controls.Add(this.splitterAttribList);
            this.tabPageAttrList.Location = new System.Drawing.Point(4, 34);
            this.tabPageAttrList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageAttrList.Name = "tabPageAttrList";
            this.tabPageAttrList.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageAttrList.Size = new System.Drawing.Size(827, 564);
            this.tabPageAttrList.TabIndex = 4;
            this.tabPageAttrList.Text = "Attribute List Control";
            this.tabPageAttrList.UseVisualStyleBackColor = true;
            // 
            // splitterAttribList
            // 
            this.splitterAttribList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitterAttribList.Location = new System.Drawing.Point(2, 2);
            this.splitterAttribList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitterAttribList.Name = "splitterAttribList";
            // 
            // splitterAttribList.Panel1
            // 
            this.splitterAttribList.Panel1.Controls.Add(this.tableAttribList);
            // 
            // splitterAttribList.Panel2
            // 
            this.splitterAttribList.Panel2.Controls.Add(this.tableAttribListDetail);
            this.splitterAttribList.Size = new System.Drawing.Size(823, 560);
            this.splitterAttribList.SplitterDistance = 273;
            this.splitterAttribList.SplitterWidth = 10;
            this.splitterAttribList.TabIndex = 20;
            // 
            // tableAttribList
            // 
            this.tableAttribList.ColumnCount = 1;
            this.tableAttribList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableAttribList.Controls.Add(this.label10, 0, 2);
            this.tableAttribList.Controls.Add(this.EntityDropdownAttribList, 0, 1);
            this.tableAttribList.Controls.Add(this.label11, 0, 0);
            this.tableAttribList.Controls.Add(this.AttribListControl, 0, 3);
            this.tableAttribList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableAttribList.Location = new System.Drawing.Point(0, 0);
            this.tableAttribList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableAttribList.Name = "tableAttribList";
            this.tableAttribList.RowCount = 4;
            this.tableAttribList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableAttribList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableAttribList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableAttribList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableAttribList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableAttribList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableAttribList.Size = new System.Drawing.Size(273, 560);
            this.tableAttribList.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(2, 62);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(269, 26);
            this.label10.TabIndex = 18;
            this.label10.Text = "Attributes List";
            // 
            // EntityDropdownAttribList
            // 
            this.EntityDropdownAttribList.AutoLoadData = false;
            this.EntityDropdownAttribList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EntityDropdownAttribList.LanguageCode = 1033;
            this.EntityDropdownAttribList.Location = new System.Drawing.Point(4, 29);
            this.EntityDropdownAttribList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EntityDropdownAttribList.Name = "EntityDropdownAttribList";
            this.EntityDropdownAttribList.Service = null;
            this.EntityDropdownAttribList.Size = new System.Drawing.Size(265, 30);
            this.EntityDropdownAttribList.TabIndex = 15;
            this.EntityDropdownAttribList.SelectedItemChanged += new System.EventHandler(this.EntityDropdownAttribList_SelectedItemChanged);
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(2, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(269, 26);
            this.label11.TabIndex = 0;
            this.label11.Text = "Entity Dropdown Control";
            // 
            // AttribListControl
            // 
            this.AttribListControl.AutoLoadData = false;
            this.AttribListControl.AutosizeColumns = System.Windows.Forms.ColumnHeaderAutoResizeStyle.None;
            this.AttribListControl.Checkboxes = true;
            this.AttribListControl.DisplayToolbar = false;
            this.AttribListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AttribListControl.LanguageCode = 1033;
            this.AttribListControl.ListViewColDefs = new XrmToolBox.Controls.ListViewColumnDef[] {
        ((XrmToolBox.Controls.ListViewColumnDef)(resources.GetObject("AttribListControl.ListViewColDefs"))),
        ((XrmToolBox.Controls.ListViewColumnDef)(resources.GetObject("AttribListControl.ListViewColDefs1"))),
        ((XrmToolBox.Controls.ListViewColumnDef)(resources.GetObject("AttribListControl.ListViewColDefs2"))),
        ((XrmToolBox.Controls.ListViewColumnDef)(resources.GetObject("AttribListControl.ListViewColDefs3"))),
        ((XrmToolBox.Controls.ListViewColumnDef)(resources.GetObject("AttribListControl.ListViewColDefs4"))),
        ((XrmToolBox.Controls.ListViewColumnDef)(resources.GetObject("AttribListControl.ListViewColDefs5"))),
        ((XrmToolBox.Controls.ListViewColumnDef)(resources.GetObject("AttribListControl.ListViewColDefs6")))};
            this.AttribListControl.Location = new System.Drawing.Point(0, 89);
            this.AttribListControl.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.AttribListControl.Name = "AttribListControl";
            this.AttribListControl.ParentEntity = null;
            this.AttribListControl.ParentEntityLogicalName = null;
            this.AttribListControl.Service = null;
            this.AttribListControl.Size = new System.Drawing.Size(273, 495);
            this.AttribListControl.TabIndex = 19;
            this.AttribListControl.SelectedItemChanged += new System.EventHandler(this.AttribListControl_SelectedItemChanged);
            this.AttribListControl.CheckedItemsChanged += new System.EventHandler(this.AttribListControl_CheckedItemsChanged);
            this.AttribListControl.FilterListComplete += new System.EventHandler(this.AttribListControl_FilterListComplete);
            this.AttribListControl.ProgressChanged += new System.EventHandler<System.ComponentModel.ProgressChangedEventArgs>(this.AttribListControl_ProgressChanged);
            this.AttribListControl.LoadDataComplete += new System.EventHandler(this.AttribListControl_LoadDataComplete);
            this.AttribListControl.NotificationMessage += new System.EventHandler<XrmToolBox.Controls.NotificationEventArgs>(this.AllControls_NotificationMessage);
            // 
            // tableAttribListDetail
            // 
            this.tableAttribListDetail.ColumnCount = 2;
            this.tableAttribListDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableAttribListDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableAttribListDetail.Controls.Add(this.propGridAttrList, 0, 0);
            this.tableAttribListDetail.Controls.Add(this.textAttribListLog, 1, 0);
            this.tableAttribListDetail.Controls.Add(this.panel5, 0, 1);
            this.tableAttribListDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableAttribListDetail.Location = new System.Drawing.Point(0, 0);
            this.tableAttribListDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableAttribListDetail.Name = "tableAttribListDetail";
            this.tableAttribListDetail.RowCount = 2;
            this.tableAttribListDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableAttribListDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableAttribListDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableAttribListDetail.Size = new System.Drawing.Size(548, 560);
            this.tableAttribListDetail.TabIndex = 21;
            // 
            // propGridAttrList
            // 
            this.propGridAttrList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propGridAttrList.Location = new System.Drawing.Point(4, 3);
            this.propGridAttrList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.propGridAttrList.Name = "propGridAttrList";
            this.propGridAttrList.Size = new System.Drawing.Size(266, 498);
            this.propGridAttrList.TabIndex = 8;
            // 
            // textAttribListLog
            // 
            this.textAttribListLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textAttribListLog.Location = new System.Drawing.Point(278, 3);
            this.textAttribListLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textAttribListLog.Multiline = true;
            this.textAttribListLog.Name = "textAttribListLog";
            this.textAttribListLog.ReadOnly = true;
            this.textAttribListLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textAttribListLog.Size = new System.Drawing.Size(266, 498);
            this.textAttribListLog.TabIndex = 7;
            // 
            // panel5
            // 
            this.tableAttribListDetail.SetColumnSpan(this.panel5, 2);
            this.panel5.Controls.Add(this.radioAttribListShowProps);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.radioAttribListShowAttrib);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(2, 506);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(544, 52);
            this.panel5.TabIndex = 16;
            // 
            // radioAttribListShowProps
            // 
            this.radioAttribListShowProps.AutoSize = true;
            this.radioAttribListShowProps.Checked = true;
            this.radioAttribListShowProps.Location = new System.Drawing.Point(14, 20);
            this.radioAttribListShowProps.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioAttribListShowProps.Name = "radioAttribListShowProps";
            this.radioAttribListShowProps.Size = new System.Drawing.Size(119, 17);
            this.radioAttribListShowProps.TabIndex = 3;
            this.radioAttribListShowProps.TabStop = true;
            this.radioAttribListShowProps.Text = "Attribute List Control";
            this.radioAttribListShowProps.UseVisualStyleBackColor = true;
            this.radioAttribListShowProps.CheckedChanged += new System.EventHandler(this.RadioAttribList_CheckedChanged);
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(544, 18);
            this.label13.TabIndex = 4;
            this.label13.Text = "Choose what displays in the property control";
            // 
            // radioAttribListShowAttrib
            // 
            this.radioAttribListShowAttrib.AutoSize = true;
            this.radioAttribListShowAttrib.Location = new System.Drawing.Point(170, 20);
            this.radioAttribListShowAttrib.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioAttribListShowAttrib.Name = "radioAttribListShowAttrib";
            this.radioAttribListShowAttrib.Size = new System.Drawing.Size(109, 17);
            this.radioAttribListShowAttrib.TabIndex = 2;
            this.radioAttribListShowAttrib.TabStop = true;
            this.radioAttribListShowAttrib.Text = "Selected Attribute";
            this.radioAttribListShowAttrib.UseVisualStyleBackColor = true;
            this.radioAttribListShowAttrib.CheckedChanged += new System.EventHandler(this.RadioAttribList_CheckedChanged);
            // 
            // tabPageAttrDropDown
            // 
            this.tabPageAttrDropDown.Controls.Add(this.splitterAttribDropdown);
            this.tabPageAttrDropDown.Location = new System.Drawing.Point(4, 34);
            this.tabPageAttrDropDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageAttrDropDown.Name = "tabPageAttrDropDown";
            this.tabPageAttrDropDown.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageAttrDropDown.Size = new System.Drawing.Size(827, 564);
            this.tabPageAttrDropDown.TabIndex = 2;
            this.tabPageAttrDropDown.Text = "Attributes Dropdown";
            this.tabPageAttrDropDown.UseVisualStyleBackColor = true;
            // 
            // splitterAttribDropdown
            // 
            this.splitterAttribDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitterAttribDropdown.Location = new System.Drawing.Point(3, 3);
            this.splitterAttribDropdown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitterAttribDropdown.Name = "splitterAttribDropdown";
            // 
            // splitterAttribDropdown.Panel1
            // 
            this.splitterAttribDropdown.Panel1.Controls.Add(this.tableAttribDropdown);
            // 
            // splitterAttribDropdown.Panel2
            // 
            this.splitterAttribDropdown.Panel2.Controls.Add(this.tableAttribDropdownDetail);
            this.splitterAttribDropdown.Size = new System.Drawing.Size(821, 558);
            this.splitterAttribDropdown.SplitterDistance = 273;
            this.splitterAttribDropdown.SplitterWidth = 10;
            this.splitterAttribDropdown.TabIndex = 19;
            // 
            // tableAttribDropdown
            // 
            this.tableAttribDropdown.ColumnCount = 1;
            this.tableAttribDropdown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableAttribDropdown.Controls.Add(this.AttributeDropdown, 0, 3);
            this.tableAttribDropdown.Controls.Add(this.labelAttributes, 0, 2);
            this.tableAttribDropdown.Controls.Add(this.EntityDropdownAttribs, 0, 1);
            this.tableAttribDropdown.Controls.Add(this.label4, 0, 0);
            this.tableAttribDropdown.Controls.Add(this.listBoxAttributes, 0, 5);
            this.tableAttribDropdown.Controls.Add(this.label6, 0, 4);
            this.tableAttribDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableAttribDropdown.Location = new System.Drawing.Point(0, 0);
            this.tableAttribDropdown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableAttribDropdown.Name = "tableAttribDropdown";
            this.tableAttribDropdown.RowCount = 6;
            this.tableAttribDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableAttribDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableAttribDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableAttribDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableAttribDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableAttribDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableAttribDropdown.Size = new System.Drawing.Size(273, 558);
            this.tableAttribDropdown.TabIndex = 19;
            // 
            // AttributeDropdown
            // 
            this.AttributeDropdown.AutoLoadData = false;
            this.AttributeDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AttributeDropdown.LanguageCode = 1033;
            this.AttributeDropdown.Location = new System.Drawing.Point(0, 89);
            this.AttributeDropdown.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.AttributeDropdown.Name = "AttributeDropdown";
            this.AttributeDropdown.ParentEntity = null;
            this.AttributeDropdown.ParentEntityLogicalName = null;
            this.AttributeDropdown.Service = null;
            this.AttributeDropdown.Size = new System.Drawing.Size(273, 34);
            this.AttributeDropdown.TabIndex = 17;
            this.AttributeDropdown.SelectedItemChanged += new System.EventHandler(this.AttributeDropdown_SelectedItemChanged);
            this.AttributeDropdown.ProgressChanged += new System.EventHandler<System.ComponentModel.ProgressChangedEventArgs>(this.AttributeDropdown_ProgressChanged);
            this.AttributeDropdown.BeginLoadData += new System.EventHandler(this.AttributeDropdown_BeginLoadData);
            this.AttributeDropdown.LoadDataComplete += new System.EventHandler(this.AttributeDropdown_LoadDataComplete);
            this.AttributeDropdown.BeginClearData += new System.EventHandler(this.AttributeDropdown_BeginClearData);
            this.AttributeDropdown.ClearDataComplete += new System.EventHandler(this.AttributeDropdown_ClearDataComplete);
            this.AttributeDropdown.NotificationMessage += new System.EventHandler<XrmToolBox.Controls.NotificationEventArgs>(this.AllControls_NotificationMessage);
            // 
            // labelAttributes
            // 
            this.labelAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAttributes.Location = new System.Drawing.Point(2, 62);
            this.labelAttributes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAttributes.Name = "labelAttributes";
            this.labelAttributes.Size = new System.Drawing.Size(269, 26);
            this.labelAttributes.TabIndex = 18;
            this.labelAttributes.Text = "Attributes Dropdown";
            // 
            // EntityDropdownAttribs
            // 
            this.EntityDropdownAttribs.AutoLoadData = false;
            this.EntityDropdownAttribs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EntityDropdownAttribs.LanguageCode = 1033;
            this.EntityDropdownAttribs.Location = new System.Drawing.Point(4, 29);
            this.EntityDropdownAttribs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EntityDropdownAttribs.Name = "EntityDropdownAttribs";
            this.EntityDropdownAttribs.Service = null;
            this.EntityDropdownAttribs.Size = new System.Drawing.Size(265, 30);
            this.EntityDropdownAttribs.TabIndex = 15;
            this.EntityDropdownAttribs.SelectedItemChanged += new System.EventHandler(this.EntityDropdownAttribs_SelectedItemChanged);
            this.EntityDropdownAttribs.ProgressChanged += new System.EventHandler<System.ComponentModel.ProgressChangedEventArgs>(this.EntityDropdownAttribs_ProgressChanged);
            this.EntityDropdownAttribs.BeginLoadData += new System.EventHandler(this.EntityDropdownAttribs_BeginLoadData);
            this.EntityDropdownAttribs.LoadDataComplete += new System.EventHandler(this.EntityDropdownAttribs_LoadDataComplete);
            this.EntityDropdownAttribs.NotificationMessage += new System.EventHandler<XrmToolBox.Controls.NotificationEventArgs>(this.AllControls_NotificationMessage);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(2, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Entity Dropdown Control";
            // 
            // listBoxAttributes
            // 
            this.listBoxAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxAttributes.FormattingEnabled = true;
            this.listBoxAttributes.Location = new System.Drawing.Point(3, 153);
            this.listBoxAttributes.Name = "listBoxAttributes";
            this.listBoxAttributes.Size = new System.Drawing.Size(267, 427);
            this.listBoxAttributes.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(3, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Full list of Attributes";
            // 
            // tableAttribDropdownDetail
            // 
            this.tableAttribDropdownDetail.ColumnCount = 2;
            this.tableAttribDropdownDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableAttribDropdownDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableAttribDropdownDetail.Controls.Add(this.propGridAttribDropdown, 0, 0);
            this.tableAttribDropdownDetail.Controls.Add(this.textAttribDropdownLog, 1, 0);
            this.tableAttribDropdownDetail.Controls.Add(this.panel2, 0, 1);
            this.tableAttribDropdownDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableAttribDropdownDetail.Location = new System.Drawing.Point(0, 0);
            this.tableAttribDropdownDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableAttribDropdownDetail.Name = "tableAttribDropdownDetail";
            this.tableAttribDropdownDetail.RowCount = 2;
            this.tableAttribDropdownDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableAttribDropdownDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableAttribDropdownDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableAttribDropdownDetail.Size = new System.Drawing.Size(538, 558);
            this.tableAttribDropdownDetail.TabIndex = 21;
            // 
            // propGridAttribDropdown
            // 
            this.propGridAttribDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propGridAttribDropdown.Location = new System.Drawing.Point(4, 3);
            this.propGridAttribDropdown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.propGridAttribDropdown.Name = "propGridAttribDropdown";
            this.propGridAttribDropdown.Size = new System.Drawing.Size(261, 496);
            this.propGridAttribDropdown.TabIndex = 8;
            // 
            // textAttribDropdownLog
            // 
            this.textAttribDropdownLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textAttribDropdownLog.Location = new System.Drawing.Point(273, 3);
            this.textAttribDropdownLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textAttribDropdownLog.Multiline = true;
            this.textAttribDropdownLog.Name = "textAttribDropdownLog";
            this.textAttribDropdownLog.ReadOnly = true;
            this.textAttribDropdownLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textAttribDropdownLog.Size = new System.Drawing.Size(261, 496);
            this.textAttribDropdownLog.TabIndex = 7;
            // 
            // panel2
            // 
            this.tableAttribDropdownDetail.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.radioAttribDropdownShowProps);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.radioAttribDropdownShowAttrib);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 504);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(534, 52);
            this.panel2.TabIndex = 16;
            // 
            // radioAttribDropdownShowProps
            // 
            this.radioAttribDropdownShowProps.AutoSize = true;
            this.radioAttribDropdownShowProps.Checked = true;
            this.radioAttribDropdownShowProps.Location = new System.Drawing.Point(14, 20);
            this.radioAttribDropdownShowProps.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioAttribDropdownShowProps.Name = "radioAttribDropdownShowProps";
            this.radioAttribDropdownShowProps.Size = new System.Drawing.Size(152, 17);
            this.radioAttribDropdownShowProps.TabIndex = 3;
            this.radioAttribDropdownShowProps.TabStop = true;
            this.radioAttribDropdownShowProps.Text = "Attribute Dropdown Control";
            this.radioAttribDropdownShowProps.UseVisualStyleBackColor = true;
            this.radioAttribDropdownShowProps.CheckedChanged += new System.EventHandler(this.RadioAttribDropdown_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(534, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Choose what displays in the property control";
            // 
            // radioAttribDropdownShowAttrib
            // 
            this.radioAttribDropdownShowAttrib.AutoSize = true;
            this.radioAttribDropdownShowAttrib.Location = new System.Drawing.Point(170, 20);
            this.radioAttribDropdownShowAttrib.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioAttribDropdownShowAttrib.Name = "radioAttribDropdownShowAttrib";
            this.radioAttribDropdownShowAttrib.Size = new System.Drawing.Size(109, 17);
            this.radioAttribDropdownShowAttrib.TabIndex = 2;
            this.radioAttribDropdownShowAttrib.TabStop = true;
            this.radioAttribDropdownShowAttrib.Text = "Selected Attribute";
            this.radioAttribDropdownShowAttrib.UseVisualStyleBackColor = true;
            // 
            // tabPageSolution
            // 
            this.tabPageSolution.Controls.Add(this.splitterSolnDropdown);
            this.tabPageSolution.Location = new System.Drawing.Point(4, 34);
            this.tabPageSolution.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageSolution.Name = "tabPageSolution";
            this.tabPageSolution.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageSolution.Size = new System.Drawing.Size(827, 569);
            this.tabPageSolution.TabIndex = 3;
            this.tabPageSolution.Text = "Solutions Dropdown";
            this.tabPageSolution.UseVisualStyleBackColor = true;
            // 
            // splitterSolnDropdown
            // 
            this.splitterSolnDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitterSolnDropdown.Location = new System.Drawing.Point(3, 3);
            this.splitterSolnDropdown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitterSolnDropdown.Name = "splitterSolnDropdown";
            // 
            // splitterSolnDropdown.Panel1
            // 
            this.splitterSolnDropdown.Panel1.Controls.Add(this.tableSolnDropdown);
            // 
            // splitterSolnDropdown.Panel2
            // 
            this.splitterSolnDropdown.Panel2.Controls.Add(this.tableSolnDropdownDetail);
            this.splitterSolnDropdown.Size = new System.Drawing.Size(821, 563);
            this.splitterSolnDropdown.SplitterDistance = 273;
            this.splitterSolnDropdown.SplitterWidth = 10;
            this.splitterSolnDropdown.TabIndex = 20;
            // 
            // tableSolnDropdown
            // 
            this.tableSolnDropdown.ColumnCount = 1;
            this.tableSolnDropdown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSolnDropdown.Controls.Add(this.label9, 0, 2);
            this.tableSolnDropdown.Controls.Add(this.SolutionDropdown, 0, 1);
            this.tableSolnDropdown.Controls.Add(this.label2, 0, 0);
            this.tableSolnDropdown.Controls.Add(this.listBoxSolutions, 0, 3);
            this.tableSolnDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableSolnDropdown.Location = new System.Drawing.Point(0, 0);
            this.tableSolnDropdown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableSolnDropdown.Name = "tableSolnDropdown";
            this.tableSolnDropdown.RowCount = 4;
            this.tableSolnDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableSolnDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableSolnDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableSolnDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableSolnDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSolnDropdown.Size = new System.Drawing.Size(273, 563);
            this.tableSolnDropdown.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Location = new System.Drawing.Point(2, 62);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(269, 26);
            this.label9.TabIndex = 21;
            this.label9.Text = "Solutions Dropdown Control";
            // 
            // SolutionDropdown
            // 
            this.SolutionDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SolutionDropdown.AutoLoadData = false;
            this.SolutionDropdown.LanguageCode = 1033;
            this.SolutionDropdown.Location = new System.Drawing.Point(0, 27);
            this.SolutionDropdown.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.SolutionDropdown.Name = "SolutionDropdown";
            this.SolutionDropdown.Service = null;
            this.SolutionDropdown.Size = new System.Drawing.Size(273, 34);
            this.SolutionDropdown.TabIndex = 19;
            this.SolutionDropdown.SelectedItemChanged += new System.EventHandler(this.SolutionDropdown_SelectedItemChanged);
            this.SolutionDropdown.ProgressChanged += new System.EventHandler<System.ComponentModel.ProgressChangedEventArgs>(this.SolutionDropdown_ProgressChanged);
            this.SolutionDropdown.BeginLoadData += new System.EventHandler(this.SolutionDropdown_BeginLoadData);
            this.SolutionDropdown.LoadDataComplete += new System.EventHandler(this.SolutionsDropdown_LoadDataComplete);
            this.SolutionDropdown.BeginClearData += new System.EventHandler(this.SolutionDropdown_BeginClearData);
            this.SolutionDropdown.ClearDataComplete += new System.EventHandler(this.SolutionDropdown_ClearDataComplete);
            this.SolutionDropdown.NotificationMessage += new System.EventHandler<XrmToolBox.Controls.NotificationEventArgs>(this.AllControls_NotificationMessage);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Solutions Dropdown Control";
            // 
            // listBoxSolutions
            // 
            this.listBoxSolutions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSolutions.FormattingEnabled = true;
            this.listBoxSolutions.Location = new System.Drawing.Point(3, 91);
            this.listBoxSolutions.Name = "listBoxSolutions";
            this.listBoxSolutions.Size = new System.Drawing.Size(267, 489);
            this.listBoxSolutions.TabIndex = 20;
            // 
            // tableSolnDropdownDetail
            // 
            this.tableSolnDropdownDetail.ColumnCount = 2;
            this.tableSolnDropdownDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSolnDropdownDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSolnDropdownDetail.Controls.Add(this.propGridSolutions, 0, 0);
            this.tableSolnDropdownDetail.Controls.Add(this.textSolnDropdownLog, 1, 0);
            this.tableSolnDropdownDetail.Controls.Add(this.panel4, 0, 1);
            this.tableSolnDropdownDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableSolnDropdownDetail.Location = new System.Drawing.Point(0, 0);
            this.tableSolnDropdownDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableSolnDropdownDetail.Name = "tableSolnDropdownDetail";
            this.tableSolnDropdownDetail.RowCount = 2;
            this.tableSolnDropdownDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableSolnDropdownDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableSolnDropdownDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSolnDropdownDetail.Size = new System.Drawing.Size(546, 563);
            this.tableSolnDropdownDetail.TabIndex = 20;
            // 
            // propGridSolutions
            // 
            this.propGridSolutions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propGridSolutions.Location = new System.Drawing.Point(4, 3);
            this.propGridSolutions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.propGridSolutions.Name = "propGridSolutions";
            this.propGridSolutions.Size = new System.Drawing.Size(265, 500);
            this.propGridSolutions.TabIndex = 8;
            // 
            // textSolnDropdownLog
            // 
            this.textSolnDropdownLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textSolnDropdownLog.Location = new System.Drawing.Point(277, 3);
            this.textSolnDropdownLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textSolnDropdownLog.Multiline = true;
            this.textSolnDropdownLog.Name = "textSolnDropdownLog";
            this.textSolnDropdownLog.ReadOnly = true;
            this.textSolnDropdownLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textSolnDropdownLog.Size = new System.Drawing.Size(265, 500);
            this.textSolnDropdownLog.TabIndex = 7;
            // 
            // panel4
            // 
            this.tableSolnDropdownDetail.SetColumnSpan(this.panel4, 2);
            this.panel4.Controls.Add(this.radioSolnDropdownShowProps);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.radioSolnDropdownShowSoln);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(2, 508);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(542, 53);
            this.panel4.TabIndex = 16;
            // 
            // radioSolnDropdownShowProps
            // 
            this.radioSolnDropdownShowProps.AutoSize = true;
            this.radioSolnDropdownShowProps.Checked = true;
            this.radioSolnDropdownShowProps.Location = new System.Drawing.Point(14, 20);
            this.radioSolnDropdownShowProps.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioSolnDropdownShowProps.Name = "radioSolnDropdownShowProps";
            this.radioSolnDropdownShowProps.Size = new System.Drawing.Size(152, 17);
            this.radioSolnDropdownShowProps.TabIndex = 3;
            this.radioSolnDropdownShowProps.TabStop = true;
            this.radioSolnDropdownShowProps.Text = "Attribute Dropdown Control";
            this.radioSolnDropdownShowProps.UseVisualStyleBackColor = true;
            this.radioSolnDropdownShowProps.CheckedChanged += new System.EventHandler(this.RadioSolnDropdownShowProps_CheckedChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(542, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Choose what displays in the property control";
            // 
            // radioSolnDropdownShowSoln
            // 
            this.radioSolnDropdownShowSoln.AutoSize = true;
            this.radioSolnDropdownShowSoln.Location = new System.Drawing.Point(170, 20);
            this.radioSolnDropdownShowSoln.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioSolnDropdownShowSoln.Name = "radioSolnDropdownShowSoln";
            this.radioSolnDropdownShowSoln.Size = new System.Drawing.Size(96, 17);
            this.radioSolnDropdownShowSoln.TabIndex = 2;
            this.radioSolnDropdownShowSoln.TabStop = true;
            this.radioSolnDropdownShowSoln.Text = "Selected Entity";
            this.radioSolnDropdownShowSoln.UseVisualStyleBackColor = true;
            // 
            // ControlTesterPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ControlTesterPluginControl";
            this.Size = new System.Drawing.Size(835, 627);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageEntList.ResumeLayout(false);
            this.splitterEntityList.Panel1.ResumeLayout(false);
            this.splitterEntityList.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitterEntityList)).EndInit();
            this.splitterEntityList.ResumeLayout(false);
            this.tableEntListDetails.ResumeLayout(false);
            this.tableEntListDetails.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageEntDropdown.ResumeLayout(false);
            this.splitterEntDropdown.Panel1.ResumeLayout(false);
            this.splitterEntDropdown.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitterEntDropdown)).EndInit();
            this.splitterEntDropdown.ResumeLayout(false);
            this.tableEntDropdown.ResumeLayout(false);
            this.tableEntDropdownDetail.ResumeLayout(false);
            this.tableEntDropdownDetail.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabPageAttrList.ResumeLayout(false);
            this.splitterAttribList.Panel1.ResumeLayout(false);
            this.splitterAttribList.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitterAttribList)).EndInit();
            this.splitterAttribList.ResumeLayout(false);
            this.tableAttribList.ResumeLayout(false);
            this.tableAttribListDetail.ResumeLayout(false);
            this.tableAttribListDetail.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabPageAttrDropDown.ResumeLayout(false);
            this.splitterAttribDropdown.Panel1.ResumeLayout(false);
            this.splitterAttribDropdown.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitterAttribDropdown)).EndInit();
            this.splitterAttribDropdown.ResumeLayout(false);
            this.tableAttribDropdown.ResumeLayout(false);
            this.tableAttribDropdownDetail.ResumeLayout(false);
            this.tableAttribDropdownDetail.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPageSolution.ResumeLayout(false);
            this.splitterSolnDropdown.Panel1.ResumeLayout(false);
            this.splitterSolnDropdown.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitterSolnDropdown)).EndInit();
            this.splitterSolnDropdown.ResumeLayout(false);
            this.tableSolnDropdown.ResumeLayout(false);
            this.tableSolnDropdownDetail.ResumeLayout(false);
            this.tableSolnDropdownDetail.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageEntList;
        private System.Windows.Forms.SplitContainer splitterEntityList;
        private System.Windows.Forms.SplitContainer splitterEntDropdown;
        private System.Windows.Forms.TabPage tabPageEntDropdown;
        private System.Windows.Forms.TabPage tabPageAttrDropDown;
        private System.Windows.Forms.TabPage tabPageSolution;
        private System.Windows.Forms.SplitContainer splitterAttribDropdown;
        private EntitiesListControl EntityListControl;
        private System.Windows.Forms.TableLayoutPanel tableEntListDetails;
        private System.Windows.Forms.PropertyGrid propGridEntList;
        private System.Windows.Forms.RadioButton radioEntListShowProps;
        private System.Windows.Forms.RadioButton radioEntListShowEnt;
        private System.Windows.Forms.TextBox textEntListLog;
        private System.Windows.Forms.TableLayoutPanel tableEntDropdown;
        private EntitiesDropdownControl EntityDropdown;
        private System.Windows.Forms.Label labelEntityDropdown;
        private System.Windows.Forms.TableLayoutPanel tableEntDropdownDetail;
        private System.Windows.Forms.PropertyGrid propGridEntDropdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioEntDropdownShowProps;
        private System.Windows.Forms.RadioButton radioEntDropdownShowEnt;
        private System.Windows.Forms.TextBox textEntDropdownLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableAttribDropdown;
        private AttributeDropdownControl AttributeDropdown;
        private System.Windows.Forms.Label labelAttributes;
        private EntitiesDropdownControl EntityDropdownAttribs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableAttribDropdownDetail;
        private System.Windows.Forms.PropertyGrid propGridAttribDropdown;
        private System.Windows.Forms.TextBox textAttribDropdownLog;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioAttribDropdownShowProps;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioAttribDropdownShowAttrib;
        private System.Windows.Forms.SplitContainer splitterSolnDropdown;
        private System.Windows.Forms.TableLayoutPanel tableSolnDropdown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableSolnDropdownDetail;
        private System.Windows.Forms.PropertyGrid propGridSolutions;
        private System.Windows.Forms.TextBox textSolnDropdownLog;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton radioSolnDropdownShowProps;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioSolnDropdownShowSoln;
        private SolutionsDropdownControl SolutionDropdown;
        private System.Windows.Forms.ListBox listBoxSolutions;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxEntities;
        private System.Windows.Forms.ListBox listBoxAttributes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPageAttrList;
        private System.Windows.Forms.SplitContainer splitterAttribList;
        private System.Windows.Forms.TableLayoutPanel tableAttribList;
        private System.Windows.Forms.Label label10;
        private EntitiesDropdownControl EntityDropdownAttribList;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel tableAttribListDetail;
        private System.Windows.Forms.PropertyGrid propGridAttrList;
        private System.Windows.Forms.TextBox textAttribListLog;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton radioAttribListShowProps;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton radioAttribListShowAttrib;
        private AttributeListControl AttribListControl;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toolButton_LoadData;
        private System.Windows.Forms.ToolStripMenuItem toolButton_ClearData;
        private System.Windows.Forms.ToolStripMenuItem toolButton_UpdateConnection;
        private System.Windows.Forms.ToolStripMenuItem toolButton_Close;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelFilter;
        private System.Windows.Forms.ToolStripTextBox toolStripTextFilter;
    }
}
