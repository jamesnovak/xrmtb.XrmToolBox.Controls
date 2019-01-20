using System.ComponentModel;

namespace xrmtb.XrmToolBox.Controls
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
            this.EntityListControl = new xrmtb.XrmToolBox.Controls.EntitiesListControl();
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
            this.EntityDropdown = new xrmtb.XrmToolBox.Controls.EntitiesDropdownControl();
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
            this.EntityDropdownAttribList = new xrmtb.XrmToolBox.Controls.EntitiesDropdownControl();
            this.label11 = new System.Windows.Forms.Label();
            this.AttribListControl = new xrmtb.XrmToolBox.Controls.AttributeListControl();
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
            this.AttributeDropdown = new xrmtb.XrmToolBox.Controls.AttributeDropdownControl();
            this.labelAttributes = new System.Windows.Forms.Label();
            this.EntityDropdownAttribs = new xrmtb.XrmToolBox.Controls.EntitiesDropdownControl();
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
            this.SolutionDropdown = new xrmtb.XrmToolBox.Controls.SolutionsDropdownControl();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxSolutions = new System.Windows.Forms.ListBox();
            this.tableSolnDropdownDetail = new System.Windows.Forms.TableLayoutPanel();
            this.propGridSolutions = new System.Windows.Forms.PropertyGrid();
            this.textSolnDropdownLog = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radioSolnDropdownShowProps = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.radioSolnDropdownShowSoln = new System.Windows.Forms.RadioButton();
            this.tabPageViewsDropdown = new System.Windows.Forms.TabPage();
            this.splitterViewDropdown = new System.Windows.Forms.SplitContainer();
            this.tableViewDropdown = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.EntityDropdownViews = new xrmtb.XrmToolBox.Controls.EntitiesDropdownControl();
            this.label14 = new System.Windows.Forms.Label();
            this.listBoxViews = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ViewDropdown = new xrmtb.XrmToolBox.Controls.Controls.ViewsDropdownControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.propGridViewDropdown = new System.Windows.Forms.PropertyGrid();
            this.textViewsDropdownLog = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.radioViewDropdownShowProps = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.radioAttribDropdownShowView = new System.Windows.Forms.RadioButton();
            this.tabPageGlobalOptSets = new System.Windows.Forms.TabPage();
            this.splitterGlobalOptsList = new System.Windows.Forms.SplitContainer();
            this.GlobalOptionSetList = new xrmtb.XrmToolBox.Controls.GlobalOptionSetListControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.radioGlobalOptsListShowProps = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.radioEntDropdownShowOptionSet = new System.Windows.Forms.RadioButton();
            this.propGridGlobalOptsList = new System.Windows.Forms.PropertyGrid();
            this.textGlobalOptsListLog = new System.Windows.Forms.TextBox();
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
            this.tabPageViewsDropdown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitterViewDropdown)).BeginInit();
            this.splitterViewDropdown.Panel1.SuspendLayout();
            this.splitterViewDropdown.Panel2.SuspendLayout();
            this.splitterViewDropdown.SuspendLayout();
            this.tableViewDropdown.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabPageGlobalOptSets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitterGlobalOptsList)).BeginInit();
            this.splitterGlobalOptsList.Panel1.SuspendLayout();
            this.splitterGlobalOptsList.Panel2.SuspendLayout();
            this.splitterGlobalOptsList.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel7.SuspendLayout();
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
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripMenu.Size = new System.Drawing.Size(1670, 39);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(171, 36);
            this.tsbClose.Text = "Close this tool";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 39);
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
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(274, 36);
            this.toolStripDropDownButton1.Text = "Call External Method...";
            // 
            // toolButton_LoadData
            // 
            this.toolButton_LoadData.Name = "toolButton_LoadData";
            this.toolButton_LoadData.Size = new System.Drawing.Size(328, 38);
            this.toolButton_LoadData.Text = "LoadData()";
            this.toolButton_LoadData.Click += new System.EventHandler(this.ToolButtonLoadData_Click);
            // 
            // toolButton_ClearData
            // 
            this.toolButton_ClearData.Name = "toolButton_ClearData";
            this.toolButton_ClearData.Size = new System.Drawing.Size(328, 38);
            this.toolButton_ClearData.Text = "ClearData()";
            this.toolButton_ClearData.Click += new System.EventHandler(this.ToolButtonClearData_Click);
            // 
            // toolButton_UpdateConnection
            // 
            this.toolButton_UpdateConnection.Name = "toolButton_UpdateConnection";
            this.toolButton_UpdateConnection.Size = new System.Drawing.Size(328, 38);
            this.toolButton_UpdateConnection.Text = "UpdateConnection()";
            this.toolButton_UpdateConnection.Click += new System.EventHandler(this.ToolButtonUpdateConnection_Click);
            // 
            // toolButton_Close
            // 
            this.toolButton_Close.Name = "toolButton_Close";
            this.toolButton_Close.Size = new System.Drawing.Size(328, 38);
            this.toolButton_Close.Text = "Close()";
            this.toolButton_Close.Click += new System.EventHandler(this.ToolButtonClose_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabelFilter
            // 
            this.toolStripLabelFilter.Name = "toolStripLabelFilter";
            this.toolStripLabelFilter.Size = new System.Drawing.Size(166, 36);
            this.toolStripLabelFilter.Text = "Filter ListView:";
            // 
            // toolStripTextFilter
            // 
            this.toolStripTextFilter.Name = "toolStripTextFilter";
            this.toolStripTextFilter.Size = new System.Drawing.Size(200, 39);
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
            this.tabControlMain.Controls.Add(this.tabPageViewsDropdown);
            this.tabControlMain.Controls.Add(this.tabPageGlobalOptSets);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.ItemSize = new System.Drawing.Size(175, 30);
            this.tabControlMain.Location = new System.Drawing.Point(0, 39);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1670, 1167);
            this.tabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlMain.TabIndex = 7;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabPageEntList
            // 
            this.tabPageEntList.Controls.Add(this.splitterEntityList);
            this.tabPageEntList.Location = new System.Drawing.Point(4, 34);
            this.tabPageEntList.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageEntList.Name = "tabPageEntList";
            this.tabPageEntList.Padding = new System.Windows.Forms.Padding(6);
            this.tabPageEntList.Size = new System.Drawing.Size(1662, 1129);
            this.tabPageEntList.TabIndex = 0;
            this.tabPageEntList.Text = "Entity List Control";
            // 
            // splitterEntityList
            // 
            this.splitterEntityList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitterEntityList.Location = new System.Drawing.Point(6, 6);
            this.splitterEntityList.Margin = new System.Windows.Forms.Padding(4);
            this.splitterEntityList.Name = "splitterEntityList";
            // 
            // splitterEntityList.Panel1
            // 
            this.splitterEntityList.Panel1.Controls.Add(this.EntityListControl);
            // 
            // splitterEntityList.Panel2
            // 
            this.splitterEntityList.Panel2.Controls.Add(this.tableEntListDetails);
            this.splitterEntityList.Size = new System.Drawing.Size(1650, 1117);
            this.splitterEntityList.SplitterDistance = 548;
            this.splitterEntityList.SplitterWidth = 20;
            this.splitterEntityList.TabIndex = 0;
            // 
            // EntityListControl
            // 
            this.EntityListControl.AutoLoadData = false;
            this.EntityListControl.AutosizeColumns = System.Windows.Forms.ColumnHeaderAutoResizeStyle.None;
            this.EntityListControl.Checkboxes = true;
            this.EntityListControl.DisplaySolutionDropdown = false;
            this.EntityListControl.DisplayToolbar = false;
            this.EntityListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EntityListControl.EntityTypes = xrmtb.XrmToolBox.Controls.EnumEntityTypes.BothCustomAndSystem;
            this.EntityListControl.LanguageCode = 1033;
            this.EntityListControl.ListViewColDefs = new xrmtb.XrmToolBox.Controls.ListViewColumnDef[] {
        ((xrmtb.XrmToolBox.Controls.ListViewColumnDef)(resources.GetObject("EntityListControl.ListViewColDefs"))),
        ((xrmtb.XrmToolBox.Controls.ListViewColumnDef)(resources.GetObject("EntityListControl.ListViewColDefs1"))),
        ((xrmtb.XrmToolBox.Controls.ListViewColumnDef)(resources.GetObject("EntityListControl.ListViewColDefs2"))),
        ((xrmtb.XrmToolBox.Controls.ListViewColumnDef)(resources.GetObject("EntityListControl.ListViewColDefs3"))),
        ((xrmtb.XrmToolBox.Controls.ListViewColumnDef)(resources.GetObject("EntityListControl.ListViewColDefs4")))};
            this.EntityListControl.Location = new System.Drawing.Point(0, 0);
            this.EntityListControl.Margin = new System.Windows.Forms.Padding(12);
            this.EntityListControl.Name = "EntityListControl";
            this.EntityListControl.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.EntityListControl.RetrieveAsIfPublished = true;
            this.EntityListControl.Service = null;
            this.EntityListControl.Size = new System.Drawing.Size(548, 1117);
            this.EntityListControl.SolutionFilter = null;
            this.EntityListControl.TabIndex = 13;
            this.EntityListControl.SelectedItemChanged += new System.EventHandler(this.EntitiesListControl_SelectedItemChanged);
            this.EntityListControl.CheckedItemsChanged += new System.EventHandler(this.EntitiesListControl_CheckedItemsChanged);
            this.EntityListControl.ProgressChanged += new System.EventHandler<System.ComponentModel.ProgressChangedEventArgs>(this.EntitiesListControl_ProgressChanged);
            this.EntityListControl.LoadDataComplete += new System.EventHandler(this.EntitiesListControl_LoadDataComplete);
            this.EntityListControl.ClearDataComplete += new System.EventHandler(this.EntitiesListControl_ClearDataComplete);
            this.EntityListControl.CloseComplete += new System.EventHandler(this.EntitiesListControl_CloseComplete);
            this.EntityListControl.NotificationMessage += new System.EventHandler<xrmtb.XrmToolBox.Controls.NotificationEventArgs>(this.AllControls_NotificationMessage);
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
            this.tableEntListDetails.Margin = new System.Windows.Forms.Padding(4);
            this.tableEntListDetails.Name = "tableEntListDetails";
            this.tableEntListDetails.RowCount = 2;
            this.tableEntListDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableEntListDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableEntListDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableEntListDetails.Size = new System.Drawing.Size(1082, 1117);
            this.tableEntListDetails.TabIndex = 20;
            // 
            // panel1
            // 
            this.tableEntListDetails.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.radioEntListShowProps);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioEntListShowEnt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 1008);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 106);
            this.panel1.TabIndex = 16;
            // 
            // radioEntListShowProps
            // 
            this.radioEntListShowProps.AutoSize = true;
            this.radioEntListShowProps.Checked = true;
            this.radioEntListShowProps.Location = new System.Drawing.Point(20, 52);
            this.radioEntListShowProps.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.radioEntListShowProps.Name = "radioEntListShowProps";
            this.radioEntListShowProps.Size = new System.Drawing.Size(258, 29);
            this.radioEntListShowProps.TabIndex = 3;
            this.radioEntListShowProps.TabStop = true;
            this.radioEntListShowProps.Text = "Entity ListView Control";
            this.radioEntListShowProps.UseVisualStyleBackColor = true;
            this.radioEntListShowProps.CheckedChanged += new System.EventHandler(this.RadioEntitiesList_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1076, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose what displays in the property control";
            // 
            // radioEntListShowEnt
            // 
            this.radioEntListShowEnt.AutoSize = true;
            this.radioEntListShowEnt.Location = new System.Drawing.Point(300, 52);
            this.radioEntListShowEnt.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.radioEntListShowEnt.Name = "radioEntListShowEnt";
            this.radioEntListShowEnt.Size = new System.Drawing.Size(187, 29);
            this.radioEntListShowEnt.TabIndex = 2;
            this.radioEntListShowEnt.TabStop = true;
            this.radioEntListShowEnt.Text = "Selected Entity";
            this.radioEntListShowEnt.UseVisualStyleBackColor = true;
            this.radioEntListShowEnt.CheckedChanged += new System.EventHandler(this.RadioEntitiesList_CheckedChanged);
            // 
            // propGridEntList
            // 
            this.propGridEntList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propGridEntList.Location = new System.Drawing.Point(8, 6);
            this.propGridEntList.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.propGridEntList.Name = "propGridEntList";
            this.propGridEntList.Size = new System.Drawing.Size(525, 993);
            this.propGridEntList.TabIndex = 8;
            // 
            // textEntListLog
            // 
            this.textEntListLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEntListLog.Location = new System.Drawing.Point(549, 6);
            this.textEntListLog.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.textEntListLog.Multiline = true;
            this.textEntListLog.Name = "textEntListLog";
            this.textEntListLog.ReadOnly = true;
            this.textEntListLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textEntListLog.Size = new System.Drawing.Size(525, 993);
            this.textEntListLog.TabIndex = 7;
            // 
            // tabPageEntDropdown
            // 
            this.tabPageEntDropdown.Controls.Add(this.splitterEntDropdown);
            this.tabPageEntDropdown.Location = new System.Drawing.Point(4, 34);
            this.tabPageEntDropdown.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageEntDropdown.Name = "tabPageEntDropdown";
            this.tabPageEntDropdown.Padding = new System.Windows.Forms.Padding(6);
            this.tabPageEntDropdown.Size = new System.Drawing.Size(1662, 1129);
            this.tabPageEntDropdown.TabIndex = 1;
            this.tabPageEntDropdown.Text = "Entity Dropdown Control";
            this.tabPageEntDropdown.UseVisualStyleBackColor = true;
            // 
            // splitterEntDropdown
            // 
            this.splitterEntDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitterEntDropdown.Location = new System.Drawing.Point(6, 6);
            this.splitterEntDropdown.Margin = new System.Windows.Forms.Padding(4);
            this.splitterEntDropdown.Name = "splitterEntDropdown";
            // 
            // splitterEntDropdown.Panel1
            // 
            this.splitterEntDropdown.Panel1.Controls.Add(this.tableEntDropdown);
            // 
            // splitterEntDropdown.Panel2
            // 
            this.splitterEntDropdown.Panel2.Controls.Add(this.tableEntDropdownDetail);
            this.splitterEntDropdown.Size = new System.Drawing.Size(1650, 1117);
            this.splitterEntDropdown.SplitterDistance = 548;
            this.splitterEntDropdown.SplitterWidth = 20;
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
            this.tableEntDropdown.Margin = new System.Windows.Forms.Padding(4);
            this.tableEntDropdown.Name = "tableEntDropdown";
            this.tableEntDropdown.RowCount = 4;
            this.tableEntDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableEntDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableEntDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableEntDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableEntDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableEntDropdown.Size = new System.Drawing.Size(548, 1117);
            this.tableEntDropdown.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(6, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(536, 44);
            this.label7.TabIndex = 21;
            this.label7.Text = "Full list of Entities";
            // 
            // EntityDropdown
            // 
            this.EntityDropdown.AutoLoadData = false;
            this.EntityDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EntityDropdown.LanguageCode = 1033;
            this.EntityDropdown.Location = new System.Drawing.Point(8, 56);
            this.EntityDropdown.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.EntityDropdown.Name = "EntityDropdown";
            this.EntityDropdown.Service = null;
            this.EntityDropdown.Size = new System.Drawing.Size(532, 57);
            this.EntityDropdown.SolutionFilter = null;
            this.EntityDropdown.TabIndex = 15;
            this.EntityDropdown.SelectedItemChanged += new System.EventHandler(this.EntityDropdown_SelectedItemChanged);
            this.EntityDropdown.ProgressChanged += new System.EventHandler<System.ComponentModel.ProgressChangedEventArgs>(this.EntityDropdown_ProgressChanged);
            this.EntityDropdown.BeginLoadData += new System.EventHandler(this.EntityDropdown_BeginLoadData);
            this.EntityDropdown.LoadDataComplete += new System.EventHandler(this.EntityDropdown_LoadDataComplete);
            this.EntityDropdown.BeginClearData += new System.EventHandler(this.EntityDropdown_BeginClearData);
            this.EntityDropdown.ClearDataComplete += new System.EventHandler(this.EntityDropdown_ClearDataComplete);
            this.EntityDropdown.NotificationMessage += new System.EventHandler<xrmtb.XrmToolBox.Controls.NotificationEventArgs>(this.AllControls_NotificationMessage);
            // 
            // labelEntityDropdown
            // 
            this.labelEntityDropdown.Location = new System.Drawing.Point(4, 0);
            this.labelEntityDropdown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEntityDropdown.Name = "labelEntityDropdown";
            this.labelEntityDropdown.Size = new System.Drawing.Size(520, 29);
            this.labelEntityDropdown.TabIndex = 0;
            this.labelEntityDropdown.Text = "Entity Dropdown Control";
            // 
            // listBoxEntities
            // 
            this.listBoxEntities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxEntities.FormattingEnabled = true;
            this.listBoxEntities.ItemHeight = 25;
            this.listBoxEntities.Location = new System.Drawing.Point(6, 175);
            this.listBoxEntities.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxEntities.Name = "listBoxEntities";
            this.listBoxEntities.Size = new System.Drawing.Size(536, 937);
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
            this.tableEntDropdownDetail.Margin = new System.Windows.Forms.Padding(4);
            this.tableEntDropdownDetail.Name = "tableEntDropdownDetail";
            this.tableEntDropdownDetail.RowCount = 2;
            this.tableEntDropdownDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableEntDropdownDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableEntDropdownDetail.Size = new System.Drawing.Size(1082, 1117);
            this.tableEntDropdownDetail.TabIndex = 21;
            // 
            // propGridEntDropdown
            // 
            this.propGridEntDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propGridEntDropdown.Location = new System.Drawing.Point(8, 6);
            this.propGridEntDropdown.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.propGridEntDropdown.Name = "propGridEntDropdown";
            this.propGridEntDropdown.Size = new System.Drawing.Size(525, 993);
            this.propGridEntDropdown.TabIndex = 8;
            // 
            // textEntDropdownLog
            // 
            this.textEntDropdownLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEntDropdownLog.Location = new System.Drawing.Point(549, 6);
            this.textEntDropdownLog.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.textEntDropdownLog.Multiline = true;
            this.textEntDropdownLog.Name = "textEntDropdownLog";
            this.textEntDropdownLog.ReadOnly = true;
            this.textEntDropdownLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textEntDropdownLog.Size = new System.Drawing.Size(525, 993);
            this.textEntDropdownLog.TabIndex = 7;
            // 
            // panel3
            // 
            this.tableEntDropdownDetail.SetColumnSpan(this.panel3, 2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.radioEntDropdownShowEnt);
            this.panel3.Controls.Add(this.radioEntDropdownShowProps);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 1009);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1074, 104);
            this.panel3.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1074, 48);
            this.label3.TabIndex = 4;
            this.label3.Text = "Choose what displays in the property control";
            // 
            // radioEntDropdownShowEnt
            // 
            this.radioEntDropdownShowEnt.Location = new System.Drawing.Point(340, 38);
            this.radioEntDropdownShowEnt.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.radioEntDropdownShowEnt.Name = "radioEntDropdownShowEnt";
            this.radioEntDropdownShowEnt.Size = new System.Drawing.Size(270, 44);
            this.radioEntDropdownShowEnt.TabIndex = 2;
            this.radioEntDropdownShowEnt.TabStop = true;
            this.radioEntDropdownShowEnt.Text = "Selected Entity";
            this.radioEntDropdownShowEnt.UseVisualStyleBackColor = true;
            this.radioEntDropdownShowEnt.CheckedChanged += new System.EventHandler(this.RadioEntDropdown_CheckedChanged);
            // 
            // radioEntDropdownShowProps
            // 
            this.radioEntDropdownShowProps.Checked = true;
            this.radioEntDropdownShowProps.Location = new System.Drawing.Point(28, 38);
            this.radioEntDropdownShowProps.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.radioEntDropdownShowProps.Name = "radioEntDropdownShowProps";
            this.radioEntDropdownShowProps.Size = new System.Drawing.Size(296, 44);
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
            this.tabPageAttrList.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageAttrList.Name = "tabPageAttrList";
            this.tabPageAttrList.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageAttrList.Size = new System.Drawing.Size(1662, 1129);
            this.tabPageAttrList.TabIndex = 4;
            this.tabPageAttrList.Text = "Attribute List Control";
            this.tabPageAttrList.UseVisualStyleBackColor = true;
            // 
            // splitterAttribList
            // 
            this.splitterAttribList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitterAttribList.Location = new System.Drawing.Point(4, 4);
            this.splitterAttribList.Margin = new System.Windows.Forms.Padding(4);
            this.splitterAttribList.Name = "splitterAttribList";
            // 
            // splitterAttribList.Panel1
            // 
            this.splitterAttribList.Panel1.Controls.Add(this.tableAttribList);
            // 
            // splitterAttribList.Panel2
            // 
            this.splitterAttribList.Panel2.Controls.Add(this.tableAttribListDetail);
            this.splitterAttribList.Size = new System.Drawing.Size(1654, 1121);
            this.splitterAttribList.SplitterDistance = 548;
            this.splitterAttribList.SplitterWidth = 20;
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
            this.tableAttribList.Margin = new System.Windows.Forms.Padding(4);
            this.tableAttribList.Name = "tableAttribList";
            this.tableAttribList.RowCount = 4;
            this.tableAttribList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableAttribList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableAttribList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableAttribList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableAttribList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableAttribList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableAttribList.Size = new System.Drawing.Size(548, 1121);
            this.tableAttribList.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(4, 119);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(540, 50);
            this.label10.TabIndex = 18;
            this.label10.Text = "Attributes List";
            // 
            // EntityDropdownAttribList
            // 
            this.EntityDropdownAttribList.AutoLoadData = false;
            this.EntityDropdownAttribList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EntityDropdownAttribList.LanguageCode = 1033;
            this.EntityDropdownAttribList.Location = new System.Drawing.Point(8, 56);
            this.EntityDropdownAttribList.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.EntityDropdownAttribList.Name = "EntityDropdownAttribList";
            this.EntityDropdownAttribList.Service = null;
            this.EntityDropdownAttribList.Size = new System.Drawing.Size(532, 57);
            this.EntityDropdownAttribList.SolutionFilter = null;
            this.EntityDropdownAttribList.TabIndex = 15;
            this.EntityDropdownAttribList.SelectedItemChanged += new System.EventHandler(this.EntityDropdownAttribList_SelectedItemChanged);
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(4, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(540, 50);
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
            this.AttribListControl.ListViewColDefs = new xrmtb.XrmToolBox.Controls.ListViewColumnDef[] {
        ((xrmtb.XrmToolBox.Controls.ListViewColumnDef)(resources.GetObject("AttribListControl.ListViewColDefs"))),
        ((xrmtb.XrmToolBox.Controls.ListViewColumnDef)(resources.GetObject("AttribListControl.ListViewColDefs1"))),
        ((xrmtb.XrmToolBox.Controls.ListViewColumnDef)(resources.GetObject("AttribListControl.ListViewColDefs2"))),
        ((xrmtb.XrmToolBox.Controls.ListViewColumnDef)(resources.GetObject("AttribListControl.ListViewColDefs3"))),
        ((xrmtb.XrmToolBox.Controls.ListViewColumnDef)(resources.GetObject("AttribListControl.ListViewColDefs4"))),
        ((xrmtb.XrmToolBox.Controls.ListViewColumnDef)(resources.GetObject("AttribListControl.ListViewColDefs5"))),
        ((xrmtb.XrmToolBox.Controls.ListViewColumnDef)(resources.GetObject("AttribListControl.ListViewColDefs6")))};
            this.AttribListControl.Location = new System.Drawing.Point(0, 171);
            this.AttribListControl.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.AttribListControl.Name = "AttribListControl";
            this.AttribListControl.ParentEntity = null;
            this.AttribListControl.ParentEntityLogicalName = null;
            this.AttribListControl.Service = null;
            this.AttribListControl.Size = new System.Drawing.Size(548, 952);
            this.AttribListControl.TabIndex = 19;
            this.AttribListControl.SelectedItemChanged += new System.EventHandler(this.AttribListControl_SelectedItemChanged);
            this.AttribListControl.CheckedItemsChanged += new System.EventHandler(this.AttribListControl_CheckedItemsChanged);
            this.AttribListControl.FilterListComplete += new System.EventHandler(this.AttribListControl_FilterListComplete);
            this.AttribListControl.ProgressChanged += new System.EventHandler<System.ComponentModel.ProgressChangedEventArgs>(this.AttribListControl_ProgressChanged);
            this.AttribListControl.LoadDataComplete += new System.EventHandler(this.AttribListControl_LoadDataComplete);
            this.AttribListControl.NotificationMessage += new System.EventHandler<xrmtb.XrmToolBox.Controls.NotificationEventArgs>(this.AllControls_NotificationMessage);
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
            this.tableAttribListDetail.Margin = new System.Windows.Forms.Padding(4);
            this.tableAttribListDetail.Name = "tableAttribListDetail";
            this.tableAttribListDetail.RowCount = 2;
            this.tableAttribListDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableAttribListDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableAttribListDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableAttribListDetail.Size = new System.Drawing.Size(1086, 1121);
            this.tableAttribListDetail.TabIndex = 21;
            // 
            // propGridAttrList
            // 
            this.propGridAttrList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propGridAttrList.Location = new System.Drawing.Point(8, 6);
            this.propGridAttrList.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.propGridAttrList.Name = "propGridAttrList";
            this.propGridAttrList.Size = new System.Drawing.Size(527, 996);
            this.propGridAttrList.TabIndex = 8;
            // 
            // textAttribListLog
            // 
            this.textAttribListLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textAttribListLog.Location = new System.Drawing.Point(551, 6);
            this.textAttribListLog.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.textAttribListLog.Multiline = true;
            this.textAttribListLog.Name = "textAttribListLog";
            this.textAttribListLog.ReadOnly = true;
            this.textAttribListLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textAttribListLog.Size = new System.Drawing.Size(527, 996);
            this.textAttribListLog.TabIndex = 7;
            // 
            // panel5
            // 
            this.tableAttribListDetail.SetColumnSpan(this.panel5, 2);
            this.panel5.Controls.Add(this.radioAttribListShowProps);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.radioAttribListShowAttrib);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(4, 1012);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1078, 105);
            this.panel5.TabIndex = 16;
            // 
            // radioAttribListShowProps
            // 
            this.radioAttribListShowProps.AutoSize = true;
            this.radioAttribListShowProps.Checked = true;
            this.radioAttribListShowProps.Location = new System.Drawing.Point(28, 38);
            this.radioAttribListShowProps.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.radioAttribListShowProps.Name = "radioAttribListShowProps";
            this.radioAttribListShowProps.Size = new System.Drawing.Size(238, 29);
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
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1078, 35);
            this.label13.TabIndex = 4;
            this.label13.Text = "Choose what displays in the property control";
            // 
            // radioAttribListShowAttrib
            // 
            this.radioAttribListShowAttrib.AutoSize = true;
            this.radioAttribListShowAttrib.Location = new System.Drawing.Point(340, 38);
            this.radioAttribListShowAttrib.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.radioAttribListShowAttrib.Name = "radioAttribListShowAttrib";
            this.radioAttribListShowAttrib.Size = new System.Drawing.Size(213, 29);
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
            this.tabPageAttrDropDown.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageAttrDropDown.Name = "tabPageAttrDropDown";
            this.tabPageAttrDropDown.Padding = new System.Windows.Forms.Padding(6);
            this.tabPageAttrDropDown.Size = new System.Drawing.Size(1662, 1129);
            this.tabPageAttrDropDown.TabIndex = 2;
            this.tabPageAttrDropDown.Text = "Attributes Dropdown";
            this.tabPageAttrDropDown.UseVisualStyleBackColor = true;
            // 
            // splitterAttribDropdown
            // 
            this.splitterAttribDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitterAttribDropdown.Location = new System.Drawing.Point(6, 6);
            this.splitterAttribDropdown.Margin = new System.Windows.Forms.Padding(4);
            this.splitterAttribDropdown.Name = "splitterAttribDropdown";
            // 
            // splitterAttribDropdown.Panel1
            // 
            this.splitterAttribDropdown.Panel1.Controls.Add(this.tableAttribDropdown);
            // 
            // splitterAttribDropdown.Panel2
            // 
            this.splitterAttribDropdown.Panel2.Controls.Add(this.tableAttribDropdownDetail);
            this.splitterAttribDropdown.Size = new System.Drawing.Size(1650, 1117);
            this.splitterAttribDropdown.SplitterDistance = 548;
            this.splitterAttribDropdown.SplitterWidth = 20;
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
            this.tableAttribDropdown.Margin = new System.Windows.Forms.Padding(4);
            this.tableAttribDropdown.Name = "tableAttribDropdown";
            this.tableAttribDropdown.RowCount = 6;
            this.tableAttribDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableAttribDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableAttribDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableAttribDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableAttribDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableAttribDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableAttribDropdown.Size = new System.Drawing.Size(548, 1117);
            this.tableAttribDropdown.TabIndex = 19;
            // 
            // AttributeDropdown
            // 
            this.AttributeDropdown.AutoLoadData = false;
            this.AttributeDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AttributeDropdown.LanguageCode = 1033;
            this.AttributeDropdown.Location = new System.Drawing.Point(0, 171);
            this.AttributeDropdown.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.AttributeDropdown.Name = "AttributeDropdown";
            this.AttributeDropdown.ParentEntity = null;
            this.AttributeDropdown.ParentEntityLogicalName = null;
            this.AttributeDropdown.Service = null;
            this.AttributeDropdown.Size = new System.Drawing.Size(548, 65);
            this.AttributeDropdown.TabIndex = 17;
            this.AttributeDropdown.SelectedItemChanged += new System.EventHandler(this.AttributeDropdown_SelectedItemChanged);
            this.AttributeDropdown.ProgressChanged += new System.EventHandler<System.ComponentModel.ProgressChangedEventArgs>(this.AttributeDropdown_ProgressChanged);
            this.AttributeDropdown.BeginLoadData += new System.EventHandler(this.AttributeDropdown_BeginLoadData);
            this.AttributeDropdown.LoadDataComplete += new System.EventHandler(this.AttributeDropdown_LoadDataComplete);
            this.AttributeDropdown.BeginClearData += new System.EventHandler(this.AttributeDropdown_BeginClearData);
            this.AttributeDropdown.ClearDataComplete += new System.EventHandler(this.AttributeDropdown_ClearDataComplete);
            this.AttributeDropdown.NotificationMessage += new System.EventHandler<xrmtb.XrmToolBox.Controls.NotificationEventArgs>(this.AllControls_NotificationMessage);
            // 
            // labelAttributes
            // 
            this.labelAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAttributes.Location = new System.Drawing.Point(4, 119);
            this.labelAttributes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAttributes.Name = "labelAttributes";
            this.labelAttributes.Size = new System.Drawing.Size(540, 50);
            this.labelAttributes.TabIndex = 18;
            this.labelAttributes.Text = "Attributes Dropdown";
            // 
            // EntityDropdownAttribs
            // 
            this.EntityDropdownAttribs.AutoLoadData = false;
            this.EntityDropdownAttribs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EntityDropdownAttribs.LanguageCode = 1033;
            this.EntityDropdownAttribs.Location = new System.Drawing.Point(8, 56);
            this.EntityDropdownAttribs.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.EntityDropdownAttribs.Name = "EntityDropdownAttribs";
            this.EntityDropdownAttribs.Service = null;
            this.EntityDropdownAttribs.Size = new System.Drawing.Size(532, 57);
            this.EntityDropdownAttribs.SolutionFilter = null;
            this.EntityDropdownAttribs.TabIndex = 15;
            this.EntityDropdownAttribs.SelectedItemChanged += new System.EventHandler(this.EntityDropdownAttribs_SelectedItemChanged);
            this.EntityDropdownAttribs.ProgressChanged += new System.EventHandler<System.ComponentModel.ProgressChangedEventArgs>(this.EntityDropdownAttribs_ProgressChanged);
            this.EntityDropdownAttribs.BeginLoadData += new System.EventHandler(this.EntityDropdownAttribs_BeginLoadData);
            this.EntityDropdownAttribs.LoadDataComplete += new System.EventHandler(this.EntityDropdownAttribs_LoadDataComplete);
            this.EntityDropdownAttribs.NotificationMessage += new System.EventHandler<xrmtb.XrmToolBox.Controls.NotificationEventArgs>(this.AllControls_NotificationMessage);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(4, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(540, 50);
            this.label4.TabIndex = 0;
            this.label4.Text = "Entity Dropdown Control";
            // 
            // listBoxAttributes
            // 
            this.listBoxAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxAttributes.FormattingEnabled = true;
            this.listBoxAttributes.ItemHeight = 25;
            this.listBoxAttributes.Location = new System.Drawing.Point(6, 294);
            this.listBoxAttributes.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxAttributes.Name = "listBoxAttributes";
            this.listBoxAttributes.Size = new System.Drawing.Size(536, 817);
            this.listBoxAttributes.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(6, 238);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(536, 44);
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
            this.tableAttribDropdownDetail.Margin = new System.Windows.Forms.Padding(4);
            this.tableAttribDropdownDetail.Name = "tableAttribDropdownDetail";
            this.tableAttribDropdownDetail.RowCount = 2;
            this.tableAttribDropdownDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableAttribDropdownDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableAttribDropdownDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableAttribDropdownDetail.Size = new System.Drawing.Size(1082, 1117);
            this.tableAttribDropdownDetail.TabIndex = 21;
            // 
            // propGridAttribDropdown
            // 
            this.propGridAttribDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propGridAttribDropdown.Location = new System.Drawing.Point(8, 6);
            this.propGridAttribDropdown.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.propGridAttribDropdown.Name = "propGridAttribDropdown";
            this.propGridAttribDropdown.Size = new System.Drawing.Size(525, 993);
            this.propGridAttribDropdown.TabIndex = 8;
            // 
            // textAttribDropdownLog
            // 
            this.textAttribDropdownLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textAttribDropdownLog.Location = new System.Drawing.Point(549, 6);
            this.textAttribDropdownLog.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.textAttribDropdownLog.Multiline = true;
            this.textAttribDropdownLog.Name = "textAttribDropdownLog";
            this.textAttribDropdownLog.ReadOnly = true;
            this.textAttribDropdownLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textAttribDropdownLog.Size = new System.Drawing.Size(525, 993);
            this.textAttribDropdownLog.TabIndex = 7;
            // 
            // panel2
            // 
            this.tableAttribDropdownDetail.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.radioAttribDropdownShowProps);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.radioAttribDropdownShowAttrib);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 1008);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1076, 106);
            this.panel2.TabIndex = 16;
            // 
            // radioAttribDropdownShowProps
            // 
            this.radioAttribDropdownShowProps.AutoSize = true;
            this.radioAttribDropdownShowProps.Checked = true;
            this.radioAttribDropdownShowProps.Location = new System.Drawing.Point(28, 38);
            this.radioAttribDropdownShowProps.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.radioAttribDropdownShowProps.Name = "radioAttribDropdownShowProps";
            this.radioAttribDropdownShowProps.Size = new System.Drawing.Size(301, 29);
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
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1076, 35);
            this.label5.TabIndex = 4;
            this.label5.Text = "Choose what displays in the property control";
            // 
            // radioAttribDropdownShowAttrib
            // 
            this.radioAttribDropdownShowAttrib.AutoSize = true;
            this.radioAttribDropdownShowAttrib.Location = new System.Drawing.Point(340, 38);
            this.radioAttribDropdownShowAttrib.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.radioAttribDropdownShowAttrib.Name = "radioAttribDropdownShowAttrib";
            this.radioAttribDropdownShowAttrib.Size = new System.Drawing.Size(213, 29);
            this.radioAttribDropdownShowAttrib.TabIndex = 2;
            this.radioAttribDropdownShowAttrib.TabStop = true;
            this.radioAttribDropdownShowAttrib.Text = "Selected Attribute";
            this.radioAttribDropdownShowAttrib.UseVisualStyleBackColor = true;
            // 
            // tabPageSolution
            // 
            this.tabPageSolution.Controls.Add(this.splitterSolnDropdown);
            this.tabPageSolution.Location = new System.Drawing.Point(4, 34);
            this.tabPageSolution.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageSolution.Name = "tabPageSolution";
            this.tabPageSolution.Padding = new System.Windows.Forms.Padding(6);
            this.tabPageSolution.Size = new System.Drawing.Size(1662, 1129);
            this.tabPageSolution.TabIndex = 3;
            this.tabPageSolution.Text = "Solutions Dropdown";
            this.tabPageSolution.UseVisualStyleBackColor = true;
            // 
            // splitterSolnDropdown
            // 
            this.splitterSolnDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitterSolnDropdown.Location = new System.Drawing.Point(6, 6);
            this.splitterSolnDropdown.Margin = new System.Windows.Forms.Padding(4);
            this.splitterSolnDropdown.Name = "splitterSolnDropdown";
            // 
            // splitterSolnDropdown.Panel1
            // 
            this.splitterSolnDropdown.Panel1.Controls.Add(this.tableSolnDropdown);
            // 
            // splitterSolnDropdown.Panel2
            // 
            this.splitterSolnDropdown.Panel2.Controls.Add(this.tableSolnDropdownDetail);
            this.splitterSolnDropdown.Size = new System.Drawing.Size(1650, 1117);
            this.splitterSolnDropdown.SplitterDistance = 548;
            this.splitterSolnDropdown.SplitterWidth = 20;
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
            this.tableSolnDropdown.Margin = new System.Windows.Forms.Padding(4);
            this.tableSolnDropdown.Name = "tableSolnDropdown";
            this.tableSolnDropdown.RowCount = 4;
            this.tableSolnDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableSolnDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableSolnDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableSolnDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableSolnDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableSolnDropdown.Size = new System.Drawing.Size(548, 1117);
            this.tableSolnDropdown.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Location = new System.Drawing.Point(4, 119);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(540, 50);
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
            this.SolutionDropdown.Location = new System.Drawing.Point(0, 52);
            this.SolutionDropdown.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.SolutionDropdown.Name = "SolutionDropdown";
            this.SolutionDropdown.Service = null;
            this.SolutionDropdown.Size = new System.Drawing.Size(548, 65);
            this.SolutionDropdown.TabIndex = 19;
            this.SolutionDropdown.SelectedItemChanged += new System.EventHandler(this.SolutionDropdown_SelectedItemChanged);
            this.SolutionDropdown.ProgressChanged += new System.EventHandler<System.ComponentModel.ProgressChangedEventArgs>(this.SolutionDropdown_ProgressChanged);
            this.SolutionDropdown.BeginLoadData += new System.EventHandler(this.SolutionDropdown_BeginLoadData);
            this.SolutionDropdown.LoadDataComplete += new System.EventHandler(this.SolutionsDropdown_LoadDataComplete);
            this.SolutionDropdown.BeginClearData += new System.EventHandler(this.SolutionDropdown_BeginClearData);
            this.SolutionDropdown.ClearDataComplete += new System.EventHandler(this.SolutionDropdown_ClearDataComplete);
            this.SolutionDropdown.NotificationMessage += new System.EventHandler<xrmtb.XrmToolBox.Controls.NotificationEventArgs>(this.AllControls_NotificationMessage);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(540, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "Solutions Dropdown Control";
            // 
            // listBoxSolutions
            // 
            this.listBoxSolutions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSolutions.FormattingEnabled = true;
            this.listBoxSolutions.ItemHeight = 25;
            this.listBoxSolutions.Location = new System.Drawing.Point(6, 175);
            this.listBoxSolutions.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxSolutions.Name = "listBoxSolutions";
            this.listBoxSolutions.Size = new System.Drawing.Size(536, 937);
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
            this.tableSolnDropdownDetail.Margin = new System.Windows.Forms.Padding(4);
            this.tableSolnDropdownDetail.Name = "tableSolnDropdownDetail";
            this.tableSolnDropdownDetail.RowCount = 2;
            this.tableSolnDropdownDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableSolnDropdownDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableSolnDropdownDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableSolnDropdownDetail.Size = new System.Drawing.Size(1082, 1117);
            this.tableSolnDropdownDetail.TabIndex = 20;
            // 
            // propGridSolutions
            // 
            this.propGridSolutions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propGridSolutions.Location = new System.Drawing.Point(8, 6);
            this.propGridSolutions.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.propGridSolutions.Name = "propGridSolutions";
            this.propGridSolutions.Size = new System.Drawing.Size(525, 993);
            this.propGridSolutions.TabIndex = 8;
            // 
            // textSolnDropdownLog
            // 
            this.textSolnDropdownLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textSolnDropdownLog.Location = new System.Drawing.Point(549, 6);
            this.textSolnDropdownLog.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.textSolnDropdownLog.Multiline = true;
            this.textSolnDropdownLog.Name = "textSolnDropdownLog";
            this.textSolnDropdownLog.ReadOnly = true;
            this.textSolnDropdownLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textSolnDropdownLog.Size = new System.Drawing.Size(525, 993);
            this.textSolnDropdownLog.TabIndex = 7;
            // 
            // panel4
            // 
            this.tableSolnDropdownDetail.SetColumnSpan(this.panel4, 2);
            this.panel4.Controls.Add(this.radioSolnDropdownShowProps);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.radioSolnDropdownShowSoln);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(4, 1009);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1074, 104);
            this.panel4.TabIndex = 16;
            // 
            // radioSolnDropdownShowProps
            // 
            this.radioSolnDropdownShowProps.AutoSize = true;
            this.radioSolnDropdownShowProps.Checked = true;
            this.radioSolnDropdownShowProps.Location = new System.Drawing.Point(28, 38);
            this.radioSolnDropdownShowProps.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.radioSolnDropdownShowProps.Name = "radioSolnDropdownShowProps";
            this.radioSolnDropdownShowProps.Size = new System.Drawing.Size(301, 29);
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
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1074, 35);
            this.label8.TabIndex = 4;
            this.label8.Text = "Choose what displays in the property control";
            // 
            // radioSolnDropdownShowSoln
            // 
            this.radioSolnDropdownShowSoln.AutoSize = true;
            this.radioSolnDropdownShowSoln.Location = new System.Drawing.Point(340, 38);
            this.radioSolnDropdownShowSoln.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.radioSolnDropdownShowSoln.Name = "radioSolnDropdownShowSoln";
            this.radioSolnDropdownShowSoln.Size = new System.Drawing.Size(187, 29);
            this.radioSolnDropdownShowSoln.TabIndex = 2;
            this.radioSolnDropdownShowSoln.TabStop = true;
            this.radioSolnDropdownShowSoln.Text = "Selected Entity";
            this.radioSolnDropdownShowSoln.UseVisualStyleBackColor = true;
            // 
            // tabPageViewsDropdown
            // 
            this.tabPageViewsDropdown.Controls.Add(this.splitterViewDropdown);
            this.tabPageViewsDropdown.Location = new System.Drawing.Point(4, 34);
            this.tabPageViewsDropdown.Name = "tabPageViewsDropdown";
            this.tabPageViewsDropdown.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageViewsDropdown.Size = new System.Drawing.Size(1662, 1129);
            this.tabPageViewsDropdown.TabIndex = 5;
            this.tabPageViewsDropdown.Text = "Views Dropdown";
            this.tabPageViewsDropdown.UseVisualStyleBackColor = true;
            // 
            // splitterViewDropdown
            // 
            this.splitterViewDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitterViewDropdown.Location = new System.Drawing.Point(3, 3);
            this.splitterViewDropdown.Margin = new System.Windows.Forms.Padding(4);
            this.splitterViewDropdown.Name = "splitterViewDropdown";
            // 
            // splitterViewDropdown.Panel1
            // 
            this.splitterViewDropdown.Panel1.Controls.Add(this.tableViewDropdown);
            // 
            // splitterViewDropdown.Panel2
            // 
            this.splitterViewDropdown.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitterViewDropdown.Size = new System.Drawing.Size(1656, 1123);
            this.splitterViewDropdown.SplitterDistance = 549;
            this.splitterViewDropdown.SplitterWidth = 20;
            this.splitterViewDropdown.TabIndex = 20;
            // 
            // tableViewDropdown
            // 
            this.tableViewDropdown.ColumnCount = 1;
            this.tableViewDropdown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableViewDropdown.Controls.Add(this.label12, 0, 2);
            this.tableViewDropdown.Controls.Add(this.EntityDropdownViews, 0, 1);
            this.tableViewDropdown.Controls.Add(this.label14, 0, 0);
            this.tableViewDropdown.Controls.Add(this.listBoxViews, 0, 5);
            this.tableViewDropdown.Controls.Add(this.label15, 0, 4);
            this.tableViewDropdown.Controls.Add(this.ViewDropdown, 0, 3);
            this.tableViewDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableViewDropdown.Location = new System.Drawing.Point(0, 0);
            this.tableViewDropdown.Margin = new System.Windows.Forms.Padding(4);
            this.tableViewDropdown.Name = "tableViewDropdown";
            this.tableViewDropdown.RowCount = 6;
            this.tableViewDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableViewDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableViewDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableViewDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableViewDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableViewDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableViewDropdown.Size = new System.Drawing.Size(549, 1123);
            this.tableViewDropdown.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(4, 119);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(541, 50);
            this.label12.TabIndex = 18;
            this.label12.Text = "Views Dropdown";
            // 
            // EntityDropdownViews
            // 
            this.EntityDropdownViews.AutoLoadData = false;
            this.EntityDropdownViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EntityDropdownViews.LanguageCode = 1033;
            this.EntityDropdownViews.Location = new System.Drawing.Point(8, 56);
            this.EntityDropdownViews.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.EntityDropdownViews.Name = "EntityDropdownViews";
            this.EntityDropdownViews.Service = null;
            this.EntityDropdownViews.Size = new System.Drawing.Size(533, 57);
            this.EntityDropdownViews.SolutionFilter = null;
            this.EntityDropdownViews.TabIndex = 15;
            this.EntityDropdownViews.SelectedItemChanged += new System.EventHandler(this.EntityDropdownViews_SelectedItemChanged);
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(4, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(541, 50);
            this.label14.TabIndex = 0;
            this.label14.Text = "Entity Dropdown Control";
            // 
            // listBoxViews
            // 
            this.listBoxViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxViews.FormattingEnabled = true;
            this.listBoxViews.ItemHeight = 25;
            this.listBoxViews.Location = new System.Drawing.Point(6, 294);
            this.listBoxViews.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxViews.Name = "listBoxViews";
            this.listBoxViews.Size = new System.Drawing.Size(537, 823);
            this.listBoxViews.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Location = new System.Drawing.Point(6, 238);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(537, 44);
            this.label15.TabIndex = 20;
            this.label15.Text = "Full list of Views";
            // 
            // ViewDropdown
            // 
            this.ViewDropdown.AutoLoadData = false;
            this.ViewDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewDropdown.IncludePersonalViews = false;
            this.ViewDropdown.LanguageCode = 1033;
            this.ViewDropdown.Location = new System.Drawing.Point(3, 172);
            this.ViewDropdown.Name = "ViewDropdown";
            this.ViewDropdown.ParentEntity = null;
            this.ViewDropdown.ParentEntityLogicalName = null;
            this.ViewDropdown.Service = null;
            this.ViewDropdown.Size = new System.Drawing.Size(543, 63);
            this.ViewDropdown.TabIndex = 21;
            this.ViewDropdown.SelectedItemChanged += new System.EventHandler(this.ViewDropdown_SelectedItemChanged);
            this.ViewDropdown.BeginLoadData += new System.EventHandler(this.ViewDropdown_BeginLoadData);
            this.ViewDropdown.LoadDataComplete += new System.EventHandler(this.ViewDropdown_LoadDataComplete);
            this.ViewDropdown.BeginClearData += new System.EventHandler(this.ViewDropdown_BeginClearData);
            this.ViewDropdown.ClearDataComplete += new System.EventHandler(this.ViewDropdown_ClearDataComplete);
            this.ViewDropdown.NotificationMessage += new System.EventHandler<xrmtb.XrmToolBox.Controls.NotificationEventArgs>(this.AllControls_NotificationMessage);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.propGridViewDropdown, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textViewsDropdownLog, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1087, 1123);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // propGridViewDropdown
            // 
            this.propGridViewDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propGridViewDropdown.Location = new System.Drawing.Point(8, 6);
            this.propGridViewDropdown.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.propGridViewDropdown.Name = "propGridViewDropdown";
            this.propGridViewDropdown.Size = new System.Drawing.Size(527, 998);
            this.propGridViewDropdown.TabIndex = 8;
            // 
            // textViewsDropdownLog
            // 
            this.textViewsDropdownLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textViewsDropdownLog.Location = new System.Drawing.Point(551, 6);
            this.textViewsDropdownLog.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.textViewsDropdownLog.Multiline = true;
            this.textViewsDropdownLog.Name = "textViewsDropdownLog";
            this.textViewsDropdownLog.ReadOnly = true;
            this.textViewsDropdownLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textViewsDropdownLog.Size = new System.Drawing.Size(528, 998);
            this.textViewsDropdownLog.TabIndex = 7;
            // 
            // panel6
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.panel6, 2);
            this.panel6.Controls.Add(this.radioViewDropdownShowProps);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.radioAttribDropdownShowView);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(4, 1014);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1079, 105);
            this.panel6.TabIndex = 16;
            // 
            // radioViewDropdownShowProps
            // 
            this.radioViewDropdownShowProps.AutoSize = true;
            this.radioViewDropdownShowProps.Checked = true;
            this.radioViewDropdownShowProps.Location = new System.Drawing.Point(28, 38);
            this.radioViewDropdownShowProps.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.radioViewDropdownShowProps.Name = "radioViewDropdownShowProps";
            this.radioViewDropdownShowProps.Size = new System.Drawing.Size(267, 29);
            this.radioViewDropdownShowProps.TabIndex = 3;
            this.radioViewDropdownShowProps.TabStop = true;
            this.radioViewDropdownShowProps.Text = "View Dropdown Control";
            this.radioViewDropdownShowProps.UseVisualStyleBackColor = true;
            this.radioViewDropdownShowProps.CheckedChanged += new System.EventHandler(this.RadioViewsDropdown_CheckedChanged);
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Top;
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(1079, 35);
            this.label16.TabIndex = 4;
            this.label16.Text = "Choose what displays in the property control";
            // 
            // radioAttribDropdownShowView
            // 
            this.radioAttribDropdownShowView.AutoSize = true;
            this.radioAttribDropdownShowView.Location = new System.Drawing.Point(340, 38);
            this.radioAttribDropdownShowView.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.radioAttribDropdownShowView.Name = "radioAttribDropdownShowView";
            this.radioAttribDropdownShowView.Size = new System.Drawing.Size(179, 29);
            this.radioAttribDropdownShowView.TabIndex = 2;
            this.radioAttribDropdownShowView.TabStop = true;
            this.radioAttribDropdownShowView.Text = "Selected View";
            this.radioAttribDropdownShowView.UseVisualStyleBackColor = true;
            this.radioAttribDropdownShowView.CheckedChanged += new System.EventHandler(this.RadioViewsDropdown_CheckedChanged);
            // 
            // tabPageGlobalOptSets
            // 
            this.tabPageGlobalOptSets.Controls.Add(this.splitterGlobalOptsList);
            this.tabPageGlobalOptSets.Location = new System.Drawing.Point(4, 34);
            this.tabPageGlobalOptSets.Name = "tabPageGlobalOptSets";
            this.tabPageGlobalOptSets.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGlobalOptSets.Size = new System.Drawing.Size(1662, 1129);
            this.tabPageGlobalOptSets.TabIndex = 6;
            this.tabPageGlobalOptSets.Text = "Global OptionSet ListView";
            this.tabPageGlobalOptSets.UseVisualStyleBackColor = true;
            // 
            // splitterGlobalOptsList
            // 
            this.splitterGlobalOptsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitterGlobalOptsList.Location = new System.Drawing.Point(3, 3);
            this.splitterGlobalOptsList.Margin = new System.Windows.Forms.Padding(4);
            this.splitterGlobalOptsList.Name = "splitterGlobalOptsList";
            // 
            // splitterGlobalOptsList.Panel1
            // 
            this.splitterGlobalOptsList.Panel1.Controls.Add(this.GlobalOptionSetList);
            // 
            // splitterGlobalOptsList.Panel2
            // 
            this.splitterGlobalOptsList.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitterGlobalOptsList.Size = new System.Drawing.Size(1656, 1123);
            this.splitterGlobalOptsList.SplitterDistance = 549;
            this.splitterGlobalOptsList.SplitterWidth = 20;
            this.splitterGlobalOptsList.TabIndex = 1;
            // 
            // GlobalOptionSetList
            // 
            this.GlobalOptionSetList.AutoLoadData = false;
            this.GlobalOptionSetList.AutosizeColumns = System.Windows.Forms.ColumnHeaderAutoResizeStyle.None;
            this.GlobalOptionSetList.Checkboxes = true;
            this.GlobalOptionSetList.DisplayToolbar = false;
            this.GlobalOptionSetList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobalOptionSetList.LanguageCode = 1033;
            this.GlobalOptionSetList.ListViewColDefs = new xrmtb.XrmToolBox.Controls.ListViewColumnDef[] {
        ((xrmtb.XrmToolBox.Controls.ListViewColumnDef)(resources.GetObject("GlobalOptionSetList.ListViewColDefs"))),
        ((xrmtb.XrmToolBox.Controls.ListViewColumnDef)(resources.GetObject("GlobalOptionSetList.ListViewColDefs1"))),
        ((xrmtb.XrmToolBox.Controls.ListViewColumnDef)(resources.GetObject("GlobalOptionSetList.ListViewColDefs2"))),
        ((xrmtb.XrmToolBox.Controls.ListViewColumnDef)(resources.GetObject("GlobalOptionSetList.ListViewColDefs3"))),
        ((xrmtb.XrmToolBox.Controls.ListViewColumnDef)(resources.GetObject("GlobalOptionSetList.ListViewColDefs4")))};
            this.GlobalOptionSetList.Location = new System.Drawing.Point(0, 0);
            this.GlobalOptionSetList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GlobalOptionSetList.Name = "GlobalOptionSetList";
            this.GlobalOptionSetList.RetrieveAsIfPublished = false;
            this.GlobalOptionSetList.Service = null;
            this.GlobalOptionSetList.Size = new System.Drawing.Size(549, 1123);
            this.GlobalOptionSetList.TabIndex = 0;
            this.GlobalOptionSetList.SelectedItemChanged += new System.EventHandler(this.GlobalOptionSetList_SelectedItemChanged);
            this.GlobalOptionSetList.CheckedItemsChanged += new System.EventHandler(this.GlobalOptionSetList_CheckedItemsChanged);
            this.GlobalOptionSetList.ProgressChanged += new System.EventHandler<System.ComponentModel.ProgressChangedEventArgs>(this.GlobalOptionSetList_ProgressChanged);
            this.GlobalOptionSetList.BeginLoadData += new System.EventHandler(this.SolutionDropdown_BeginLoadData);
            this.GlobalOptionSetList.LoadDataComplete += new System.EventHandler(this.GlobalOptionSetList_LoadDataComplete);
            this.GlobalOptionSetList.ClearDataComplete += new System.EventHandler(this.GlobalOptionSetList_ClearDataComplete);
            this.GlobalOptionSetList.CloseComplete += new System.EventHandler(this.GlobalOptionSetList_CloseComplete);
            this.GlobalOptionSetList.NotificationMessage += new System.EventHandler<xrmtb.XrmToolBox.Controls.NotificationEventArgs>(this.AllControls_NotificationMessage);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.propGridGlobalOptsList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textGlobalOptsListLog, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1087, 1123);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // panel7
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel7, 2);
            this.panel7.Controls.Add(this.radioGlobalOptsListShowProps);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.radioEntDropdownShowOptionSet);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(4, 1014);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1079, 105);
            this.panel7.TabIndex = 16;
            // 
            // radioGlobalOptsListShowProps
            // 
            this.radioGlobalOptsListShowProps.AutoSize = true;
            this.radioGlobalOptsListShowProps.Checked = true;
            this.radioGlobalOptsListShowProps.Location = new System.Drawing.Point(20, 52);
            this.radioGlobalOptsListShowProps.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.radioGlobalOptsListShowProps.Name = "radioGlobalOptsListShowProps";
            this.radioGlobalOptsListShowProps.Size = new System.Drawing.Size(367, 29);
            this.radioGlobalOptsListShowProps.TabIndex = 3;
            this.radioGlobalOptsListShowProps.TabStop = true;
            this.radioGlobalOptsListShowProps.Text = "Global OptionSet ListView Control";
            this.radioGlobalOptsListShowProps.UseVisualStyleBackColor = true;
            this.radioGlobalOptsListShowProps.CheckedChanged += new System.EventHandler(this.RadioGlobalOptionSetList_CheckedChanged);
            // 
            // label17
            // 
            this.label17.Dock = System.Windows.Forms.DockStyle.Top;
            this.label17.Location = new System.Drawing.Point(0, 0);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(1079, 44);
            this.label17.TabIndex = 4;
            this.label17.Text = "Choose what displays in the property control";
            // 
            // radioEntDropdownShowOptionSet
            // 
            this.radioEntDropdownShowOptionSet.AutoSize = true;
            this.radioEntDropdownShowOptionSet.Location = new System.Drawing.Point(407, 52);
            this.radioEntDropdownShowOptionSet.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.radioEntDropdownShowOptionSet.Name = "radioEntDropdownShowOptionSet";
            this.radioEntDropdownShowOptionSet.Size = new System.Drawing.Size(296, 29);
            this.radioEntDropdownShowOptionSet.TabIndex = 2;
            this.radioEntDropdownShowOptionSet.TabStop = true;
            this.radioEntDropdownShowOptionSet.Text = "Selected Global OptionSet";
            this.radioEntDropdownShowOptionSet.UseVisualStyleBackColor = true;
            this.radioEntDropdownShowOptionSet.CheckedChanged += new System.EventHandler(this.RadioGlobalOptionSetList_CheckedChanged);
            // 
            // propGridGlobalOptsList
            // 
            this.propGridGlobalOptsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propGridGlobalOptsList.Location = new System.Drawing.Point(8, 6);
            this.propGridGlobalOptsList.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.propGridGlobalOptsList.Name = "propGridGlobalOptsList";
            this.propGridGlobalOptsList.Size = new System.Drawing.Size(527, 998);
            this.propGridGlobalOptsList.TabIndex = 8;
            // 
            // textGlobalOptsListLog
            // 
            this.textGlobalOptsListLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textGlobalOptsListLog.Location = new System.Drawing.Point(551, 6);
            this.textGlobalOptsListLog.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.textGlobalOptsListLog.Multiline = true;
            this.textGlobalOptsListLog.Name = "textGlobalOptsListLog";
            this.textGlobalOptsListLog.ReadOnly = true;
            this.textGlobalOptsListLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textGlobalOptsListLog.Size = new System.Drawing.Size(528, 998);
            this.textGlobalOptsListLog.TabIndex = 7;
            // 
            // ControlTesterPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "ControlTesterPluginControl";
            this.Size = new System.Drawing.Size(1670, 1206);
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
            this.tabPageViewsDropdown.ResumeLayout(false);
            this.splitterViewDropdown.Panel1.ResumeLayout(false);
            this.splitterViewDropdown.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitterViewDropdown)).EndInit();
            this.splitterViewDropdown.ResumeLayout(false);
            this.tableViewDropdown.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tabPageGlobalOptSets.ResumeLayout(false);
            this.splitterGlobalOptsList.Panel1.ResumeLayout(false);
            this.splitterGlobalOptsList.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitterGlobalOptsList)).EndInit();
            this.splitterGlobalOptsList.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPageViewsDropdown;
        private System.Windows.Forms.SplitContainer splitterViewDropdown;
        private System.Windows.Forms.TableLayoutPanel tableViewDropdown;
        private System.Windows.Forms.Label label12;
        private EntitiesDropdownControl EntityDropdownViews;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox listBoxViews;
        private System.Windows.Forms.Label label15;
        private Controls.ViewsDropdownControl ViewDropdown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PropertyGrid propGridViewDropdown;
        private System.Windows.Forms.TextBox textViewsDropdownLog;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton radioViewDropdownShowProps;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton radioAttribDropdownShowView;
        private System.Windows.Forms.TabPage tabPageGlobalOptSets;
        private System.Windows.Forms.SplitContainer splitterGlobalOptsList;
        private GlobalOptionSetListControl GlobalOptionSetList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RadioButton radioGlobalOptsListShowProps;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton radioEntDropdownShowOptionSet;
        private System.Windows.Forms.PropertyGrid propGridGlobalOptsList;
        private System.Windows.Forms.TextBox textGlobalOptsListLog;
    }
}
