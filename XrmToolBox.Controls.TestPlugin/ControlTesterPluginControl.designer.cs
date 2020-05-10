using System.ComponentModel;

namespace Sample.XrmToolBox.TestPlugin
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
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlTesterPluginControl));
            xrmtb.XrmToolBox.Controls.XMLViewerSettings xmlViewerSettings1 = new xrmtb.XrmToolBox.Controls.XMLViewerSettings();
            xrmtb.XrmToolBox.Controls.XMLViewerSettings xmlViewerSettings2 = new xrmtb.XrmToolBox.Controls.XMLViewerSettings();
            xrmtb.XrmToolBox.Controls.XMLViewerSettings xmlViewerSettings3 = new xrmtb.XrmToolBox.Controls.XMLViewerSettings();
            xrmtb.XrmToolBox.Controls.XMLViewerSettings xmlViewerSettings4 = new xrmtb.XrmToolBox.Controls.XMLViewerSettings();
            xrmtb.XrmToolBox.Controls.XMLViewerSettings xmlViewerSettings5 = new xrmtb.XrmToolBox.Controls.XMLViewerSettings();
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
            this.tabPageEntListViewBase = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.EntityListViewBase = new xrmtb.XrmToolBox.Controls.EntityListViewBaseControl();
            this.flowLayoutPanelToolbar = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonLoadItems = new System.Windows.Forms.Button();
            this.checkBoxCheckAllNone = new System.Windows.Forms.CheckBox();
            this.labelFilter = new System.Windows.Forms.Label();
            this.textFilterList = new System.Windows.Forms.TextBox();
            this.buttonClearFilter = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.radioEntLVBaseShowProps = new System.Windows.Forms.RadioButton();
            this.label20 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.propGridEntLVBase = new System.Windows.Forms.PropertyGrid();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.labelAttributes = new System.Windows.Forms.Label();
            this.EntityDropdownAttribs = new xrmtb.XrmToolBox.Controls.EntitiesDropdownControl();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxAttributes = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelAttrDropdown = new System.Windows.Forms.Panel();
            this.AttributeDropdownBase = new xrmtb.XrmToolBox.Controls.AttributeDropdownBaseControl();
            this.buttonReload = new System.Windows.Forms.Button();
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
            this.ViewDropdown = new xrmtb.XrmToolBox.Controls.ViewsDropdownControl();
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
            this.tabPageCRMGridView = new System.Windows.Forms.TabPage();
            this.splitterCRMGridView = new System.Windows.Forms.SplitContainer();
            this.tableCRMGridView = new System.Windows.Forms.TableLayoutPanel();
            this.panelCrmGridViewControls = new System.Windows.Forms.Panel();
            this.dataGridViewGrouperControl1 = new Subro.Controls.DataGridViewGrouperControl();
            this.CrmGridView = new xrmtb.XrmToolBox.Controls.CRMGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelExecFetch = new System.Windows.Forms.Label();
            this.buttonExecFetch = new System.Windows.Forms.Button();
            this.XmlViewerCRMDataGrid = new xrmtb.XrmToolBox.Controls.XMLViewer();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.radioCRMGridViewRightShowProps = new System.Windows.Forms.RadioButton();
            this.radioCRMGridViewShowProps = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.radioCRMGridViewSelEntity = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textCdsDataComboBoxFormat = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cdsDataComboBox = new xrmtb.XrmToolBox.Controls.Controls.CDSDataComboBox();
            this.propCRMGridView = new System.Windows.Forms.PropertyGrid();
            this.panel11 = new System.Windows.Forms.Panel();
            this.CrmGridViewDesignedCols = new xrmtb.XrmToolBox.Controls.CRMGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonExecPredefinedCrmGridViewQuery = new System.Windows.Forms.Button();
            this.tabPageXrmViewer = new System.Windows.Forms.TabPage();
            this.TableXmlViewers = new System.Windows.Forms.TableLayoutPanel();
            this.splitterXmlViewerControl = new System.Windows.Forms.SplitContainer();
            this.XmlViewerControl = new xrmtb.XrmToolBox.Controls.XmlViewerControl();
            this.propGridXmlViewerControl = new System.Windows.Forms.PropertyGrid();
            this.splitterXmlViewer = new System.Windows.Forms.SplitContainer();
            this.XmlViewer = new xrmtb.XrmToolBox.Controls.XMLViewer();
            this.propGridXmlViewer = new System.Windows.Forms.PropertyGrid();
            this.labelXmlViewerControlTitle = new System.Windows.Forms.Label();
            this.labelXmlViewerTitle = new System.Windows.Forms.Label();
            this.tabPageBoundListIVew = new System.Windows.Forms.TabPage();
            this.splitterBoundListView = new System.Windows.Forms.SplitContainer();
            this.splitterEntList = new System.Windows.Forms.Splitter();
            this.listViewEntCollection = new xrmtb.XrmToolBox.Controls.EntitiesCollectionListView();
            this.xmlViewerEntColl = new xrmtb.XrmToolBox.Controls.XMLViewer();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelExecFetchBoundList = new System.Windows.Forms.Label();
            this.buttonExecFetchBoundList = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.radioBoundListShowProps = new System.Windows.Forms.RadioButton();
            this.label19 = new System.Windows.Forms.Label();
            this.radioEntListShowObj = new System.Windows.Forms.RadioButton();
            this.propGridBoundListView = new System.Windows.Forms.PropertyGrid();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPageCDSDataComboBox = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.xmlViewerFetchCDSCombo = new xrmtb.XrmToolBox.Controls.XmlViewerControl();
            this.textBoxCDSComboProgress = new System.Windows.Forms.TextBox();
            this.panelCDSComboRetrieve = new System.Windows.Forms.FlowLayoutPanel();
            this.cdsDataComboRetrieve = new xrmtb.XrmToolBox.Controls.Controls.CDSDataComboBox();
            this.buttonCDSComboRetrieve = new System.Windows.Forms.Button();
            this.toolStripMenu.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageEntList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitterEntityList)).BeginInit();
            this.splitterEntityList.Panel1.SuspendLayout();
            this.splitterEntityList.Panel2.SuspendLayout();
            this.splitterEntityList.SuspendLayout();
            this.tableEntListDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageEntListViewBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanelToolbar.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel10.SuspendLayout();
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
            this.panelAttrDropdown.SuspendLayout();
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
            this.tabPageCRMGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitterCRMGridView)).BeginInit();
            this.splitterCRMGridView.Panel1.SuspendLayout();
            this.splitterCRMGridView.Panel2.SuspendLayout();
            this.splitterCRMGridView.SuspendLayout();
            this.tableCRMGridView.SuspendLayout();
            this.panelCrmGridViewControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CrmGridView)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CrmGridViewDesignedCols)).BeginInit();
            this.tabPageXrmViewer.SuspendLayout();
            this.TableXmlViewers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitterXmlViewerControl)).BeginInit();
            this.splitterXmlViewerControl.Panel1.SuspendLayout();
            this.splitterXmlViewerControl.Panel2.SuspendLayout();
            this.splitterXmlViewerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitterXmlViewer)).BeginInit();
            this.splitterXmlViewer.Panel1.SuspendLayout();
            this.splitterXmlViewer.Panel2.SuspendLayout();
            this.splitterXmlViewer.SuspendLayout();
            this.tabPageBoundListIVew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitterBoundListView)).BeginInit();
            this.splitterBoundListView.Panel1.SuspendLayout();
            this.splitterBoundListView.Panel2.SuspendLayout();
            this.splitterBoundListView.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tabPageCDSDataComboBox.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panelCDSComboRetrieve.SuspendLayout();
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
            this.toolStripMenu.Size = new System.Drawing.Size(915, 25);
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
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(139, 22);
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
            this.toolStripTextFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextFilter.Name = "toolStripTextFilter";
            this.toolStripTextFilter.Size = new System.Drawing.Size(102, 25);
            this.toolStripTextFilter.TextChanged += new System.EventHandler(this.toolStripTextFilter_TextChanged);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlMain.Controls.Add(this.tabPageEntList);
            this.tabControlMain.Controls.Add(this.tabPageEntListViewBase);
            this.tabControlMain.Controls.Add(this.tabPageEntDropdown);
            this.tabControlMain.Controls.Add(this.tabPageAttrList);
            this.tabControlMain.Controls.Add(this.tabPageAttrDropDown);
            this.tabControlMain.Controls.Add(this.tabPageSolution);
            this.tabControlMain.Controls.Add(this.tabPageViewsDropdown);
            this.tabControlMain.Controls.Add(this.tabPageGlobalOptSets);
            this.tabControlMain.Controls.Add(this.tabPageCRMGridView);
            this.tabControlMain.Controls.Add(this.tabPageXrmViewer);
            this.tabControlMain.Controls.Add(this.tabPageBoundListIVew);
            this.tabControlMain.Controls.Add(this.tabPageCDSDataComboBox);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.ItemSize = new System.Drawing.Size(150, 30);
            this.tabControlMain.Location = new System.Drawing.Point(0, 25);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(915, 602);
            this.tabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlMain.TabIndex = 7;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabPageEntList
            // 
            this.tabPageEntList.Controls.Add(this.splitterEntityList);
            this.tabPageEntList.Location = new System.Drawing.Point(4, 34);
            this.tabPageEntList.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageEntList.Name = "tabPageEntList";
            this.tabPageEntList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEntList.Size = new System.Drawing.Size(907, 564);
            this.tabPageEntList.TabIndex = 0;
            this.tabPageEntList.Text = "Entity List Control";
            // 
            // splitterEntityList
            // 
            this.splitterEntityList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitterEntityList.Location = new System.Drawing.Point(3, 3);
            this.splitterEntityList.Margin = new System.Windows.Forms.Padding(2);
            this.splitterEntityList.Name = "splitterEntityList";
            // 
            // splitterEntityList.Panel1
            // 
            this.splitterEntityList.Panel1.Controls.Add(this.EntityListControl);
            // 
            // splitterEntityList.Panel2
            // 
            this.splitterEntityList.Panel2.Controls.Add(this.tableEntListDetails);
            this.splitterEntityList.Size = new System.Drawing.Size(901, 558);
            this.splitterEntityList.SplitterDistance = 295;
            this.splitterEntityList.SplitterWidth = 10;
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
            this.EntityListControl.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.EntityListControl.Name = "EntityListControl";
            this.EntityListControl.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EntityListControl.RetrieveAsIfPublished = true;
            this.EntityListControl.Service = null;
            this.EntityListControl.Size = new System.Drawing.Size(295, 558);
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
            this.tableEntListDetails.Margin = new System.Windows.Forms.Padding(2);
            this.tableEntListDetails.Name = "tableEntListDetails";
            this.tableEntListDetails.RowCount = 2;
            this.tableEntListDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableEntListDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableEntListDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableEntListDetails.Size = new System.Drawing.Size(596, 558);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 52);
            this.panel1.TabIndex = 16;
            // 
            // radioEntListShowProps
            // 
            this.radioEntListShowProps.AutoSize = true;
            this.radioEntListShowProps.Checked = true;
            this.radioEntListShowProps.Location = new System.Drawing.Point(10, 27);
            this.radioEntListShowProps.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioEntListShowProps.Name = "radioEntListShowProps";
            this.radioEntListShowProps.Size = new System.Drawing.Size(129, 17);
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
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 23);
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
            this.propGridEntList.Size = new System.Drawing.Size(290, 496);
            this.propGridEntList.TabIndex = 8;
            // 
            // textEntListLog
            // 
            this.textEntListLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEntListLog.Location = new System.Drawing.Point(302, 3);
            this.textEntListLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textEntListLog.Multiline = true;
            this.textEntListLog.Name = "textEntListLog";
            this.textEntListLog.ReadOnly = true;
            this.textEntListLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textEntListLog.Size = new System.Drawing.Size(290, 496);
            this.textEntListLog.TabIndex = 7;
            // 
            // tabPageEntListViewBase
            // 
            this.tabPageEntListViewBase.Controls.Add(this.splitContainer1);
            this.tabPageEntListViewBase.Location = new System.Drawing.Point(4, 34);
            this.tabPageEntListViewBase.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageEntListViewBase.Name = "tabPageEntListViewBase";
            this.tabPageEntListViewBase.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageEntListViewBase.Size = new System.Drawing.Size(907, 564);
            this.tabPageEntListViewBase.TabIndex = 10;
            this.tabPageEntListViewBase.Text = "Entity ListView Base";
            this.tabPageEntListViewBase.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(2, 2);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.EntityListViewBase);
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanelToolbar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel5);
            this.splitContainer1.Size = new System.Drawing.Size(903, 560);
            this.splitContainer1.SplitterDistance = 295;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 1;
            // 
            // EntityListViewBase
            // 
            this.EntityListViewBase.AutoLoadData = false;
            this.EntityListViewBase.AutosizeColumns = System.Windows.Forms.ColumnHeaderAutoResizeStyle.None;
            this.EntityListViewBase.CheckBoxes = true;
            this.EntityListViewBase.DisplayCheckBoxes = true;
            this.EntityListViewBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EntityListViewBase.HideSelection = false;
            this.EntityListViewBase.LanguageCode = 1033;
            this.EntityListViewBase.ListViewColDefs = new xrmtb.XrmToolBox.Controls.ListViewColumnDef[] {
        ((xrmtb.XrmToolBox.Controls.ListViewColumnDef)(resources.GetObject("EntityListViewBase.ListViewColDefs"))),
        ((xrmtb.XrmToolBox.Controls.ListViewColumnDef)(resources.GetObject("EntityListViewBase.ListViewColDefs1"))),
        ((xrmtb.XrmToolBox.Controls.ListViewColumnDef)(resources.GetObject("EntityListViewBase.ListViewColDefs2"))),
        ((xrmtb.XrmToolBox.Controls.ListViewColumnDef)(resources.GetObject("EntityListViewBase.ListViewColDefs3"))),
        ((xrmtb.XrmToolBox.Controls.ListViewColumnDef)(resources.GetObject("EntityListViewBase.ListViewColDefs4")))};
            this.EntityListViewBase.Location = new System.Drawing.Point(0, 30);
            this.EntityListViewBase.Margin = new System.Windows.Forms.Padding(2);
            this.EntityListViewBase.Name = "EntityListViewBase";
            this.EntityListViewBase.RetrieveAsIfPublished = true;
            this.EntityListViewBase.Service = null;
            this.EntityListViewBase.Size = new System.Drawing.Size(295, 530);
            this.EntityListViewBase.SolutionFilter = null;
            this.EntityListViewBase.TabIndex = 0;
            this.EntityListViewBase.UseCompatibleStateImageBehavior = false;
            this.EntityListViewBase.View = System.Windows.Forms.View.Details;
            this.EntityListViewBase.SelectedItemChanged += new System.EventHandler(this.EntityListViewBase_SelectedItemChanged);
            // 
            // flowLayoutPanelToolbar
            // 
            this.flowLayoutPanelToolbar.Controls.Add(this.buttonLoadItems);
            this.flowLayoutPanelToolbar.Controls.Add(this.checkBoxCheckAllNone);
            this.flowLayoutPanelToolbar.Controls.Add(this.labelFilter);
            this.flowLayoutPanelToolbar.Controls.Add(this.textFilterList);
            this.flowLayoutPanelToolbar.Controls.Add(this.buttonClearFilter);
            this.flowLayoutPanelToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelToolbar.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelToolbar.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelToolbar.Name = "flowLayoutPanelToolbar";
            this.flowLayoutPanelToolbar.Size = new System.Drawing.Size(295, 30);
            this.flowLayoutPanelToolbar.TabIndex = 9;
            this.flowLayoutPanelToolbar.WrapContents = false;
            // 
            // buttonLoadItems
            // 
            this.buttonLoadItems.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLoadItems.Image = ((System.Drawing.Image)(resources.GetObject("buttonLoadItems.Image")));
            this.buttonLoadItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLoadItems.Location = new System.Drawing.Point(0, 0);
            this.buttonLoadItems.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLoadItems.MinimumSize = new System.Drawing.Size(75, 14);
            this.buttonLoadItems.Name = "buttonLoadItems";
            this.buttonLoadItems.Size = new System.Drawing.Size(75, 27);
            this.buttonLoadItems.TabIndex = 0;
            this.buttonLoadItems.Text = "Load Items";
            this.buttonLoadItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLoadItems.UseVisualStyleBackColor = true;
            this.buttonLoadItems.Click += new System.EventHandler(this.EntLVBaseLoadItems_Click);
            // 
            // checkBoxCheckAllNone
            // 
            this.checkBoxCheckAllNone.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBoxCheckAllNone.FlatAppearance.BorderSize = 0;
            this.checkBoxCheckAllNone.Location = new System.Drawing.Point(85, 2);
            this.checkBoxCheckAllNone.Margin = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.checkBoxCheckAllNone.Name = "checkBoxCheckAllNone";
            this.checkBoxCheckAllNone.Size = new System.Drawing.Size(103, 23);
            this.checkBoxCheckAllNone.TabIndex = 6;
            this.checkBoxCheckAllNone.Text = "Check All/None";
            this.checkBoxCheckAllNone.UseVisualStyleBackColor = true;
            // 
            // labelFilter
            // 
            this.labelFilter.Location = new System.Drawing.Point(200, 0);
            this.labelFilter.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(38, 27);
            this.labelFilter.TabIndex = 3;
            this.labelFilter.Text = "Filter:";
            this.labelFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textFilterList
            // 
            this.textFilterList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textFilterList.Location = new System.Drawing.Point(241, 0);
            this.textFilterList.Margin = new System.Windows.Forms.Padding(0);
            this.textFilterList.MaxLength = 100;
            this.textFilterList.MinimumSize = new System.Drawing.Size(90, 46);
            this.textFilterList.Name = "textFilterList";
            this.textFilterList.Size = new System.Drawing.Size(121, 20);
            this.textFilterList.TabIndex = 4;
            this.textFilterList.WordWrap = false;
            // 
            // buttonClearFilter
            // 
            this.buttonClearFilter.AutoSize = true;
            this.buttonClearFilter.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonClearFilter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.125F);
            this.buttonClearFilter.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonClearFilter.Location = new System.Drawing.Point(362, 0);
            this.buttonClearFilter.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClearFilter.Name = "buttonClearFilter";
            this.buttonClearFilter.Size = new System.Drawing.Size(35, 38);
            this.buttonClearFilter.TabIndex = 5;
            this.buttonClearFilter.Text = "x";
            this.buttonClearFilter.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.panel10, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.propGridEntLVBase, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBox2, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(598, 560);
            this.tableLayoutPanel5.TabIndex = 20;
            // 
            // panel10
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.panel10, 2);
            this.panel10.Controls.Add(this.radioEntLVBaseShowProps);
            this.panel10.Controls.Add(this.label20);
            this.panel10.Controls.Add(this.radioButton2);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(2, 506);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(594, 52);
            this.panel10.TabIndex = 16;
            // 
            // radioEntLVBaseShowProps
            // 
            this.radioEntLVBaseShowProps.AutoSize = true;
            this.radioEntLVBaseShowProps.Checked = true;
            this.radioEntLVBaseShowProps.Location = new System.Drawing.Point(10, 27);
            this.radioEntLVBaseShowProps.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioEntLVBaseShowProps.Name = "radioEntLVBaseShowProps";
            this.radioEntLVBaseShowProps.Size = new System.Drawing.Size(156, 17);
            this.radioEntLVBaseShowProps.TabIndex = 3;
            this.radioEntLVBaseShowProps.TabStop = true;
            this.radioEntLVBaseShowProps.Text = "Entity ListView Base Control";
            this.radioEntLVBaseShowProps.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.Dock = System.Windows.Forms.DockStyle.Top;
            this.label20.Location = new System.Drawing.Point(0, 0);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(594, 23);
            this.label20.TabIndex = 4;
            this.label20.Text = "Choose what displays in the property control";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(175, 27);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(96, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Selected Entity";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // propGridEntLVBase
            // 
            this.propGridEntLVBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propGridEntLVBase.Location = new System.Drawing.Point(4, 3);
            this.propGridEntLVBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.propGridEntLVBase.Name = "propGridEntLVBase";
            this.propGridEntLVBase.Size = new System.Drawing.Size(291, 498);
            this.propGridEntLVBase.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(303, 3);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(291, 498);
            this.textBox2.TabIndex = 7;
            // 
            // tabPageEntDropdown
            // 
            this.tabPageEntDropdown.Controls.Add(this.splitterEntDropdown);
            this.tabPageEntDropdown.Location = new System.Drawing.Point(4, 34);
            this.tabPageEntDropdown.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageEntDropdown.Name = "tabPageEntDropdown";
            this.tabPageEntDropdown.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEntDropdown.Size = new System.Drawing.Size(907, 564);
            this.tabPageEntDropdown.TabIndex = 1;
            this.tabPageEntDropdown.Text = "Entity Dropdown Control";
            this.tabPageEntDropdown.UseVisualStyleBackColor = true;
            // 
            // splitterEntDropdown
            // 
            this.splitterEntDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitterEntDropdown.Location = new System.Drawing.Point(3, 3);
            this.splitterEntDropdown.Margin = new System.Windows.Forms.Padding(2);
            this.splitterEntDropdown.Name = "splitterEntDropdown";
            // 
            // splitterEntDropdown.Panel1
            // 
            this.splitterEntDropdown.Panel1.Controls.Add(this.tableEntDropdown);
            // 
            // splitterEntDropdown.Panel2
            // 
            this.splitterEntDropdown.Panel2.Controls.Add(this.tableEntDropdownDetail);
            this.splitterEntDropdown.Size = new System.Drawing.Size(901, 558);
            this.splitterEntDropdown.SplitterDistance = 295;
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
            this.tableEntDropdown.Margin = new System.Windows.Forms.Padding(2);
            this.tableEntDropdown.Name = "tableEntDropdown";
            this.tableEntDropdown.RowCount = 4;
            this.tableEntDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableEntDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableEntDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableEntDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableEntDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableEntDropdown.Size = new System.Drawing.Size(295, 558);
            this.tableEntDropdown.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(3, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(289, 23);
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
            this.EntityDropdown.Size = new System.Drawing.Size(287, 30);
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
            this.listBoxEntities.Size = new System.Drawing.Size(289, 489);
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
            this.tableEntDropdownDetail.Margin = new System.Windows.Forms.Padding(2);
            this.tableEntDropdownDetail.Name = "tableEntDropdownDetail";
            this.tableEntDropdownDetail.RowCount = 2;
            this.tableEntDropdownDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableEntDropdownDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableEntDropdownDetail.Size = new System.Drawing.Size(596, 558);
            this.tableEntDropdownDetail.TabIndex = 21;
            // 
            // propGridEntDropdown
            // 
            this.propGridEntDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propGridEntDropdown.Location = new System.Drawing.Point(4, 3);
            this.propGridEntDropdown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.propGridEntDropdown.Name = "propGridEntDropdown";
            this.propGridEntDropdown.Size = new System.Drawing.Size(290, 496);
            this.propGridEntDropdown.TabIndex = 8;
            // 
            // textEntDropdownLog
            // 
            this.textEntDropdownLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEntDropdownLog.Location = new System.Drawing.Point(302, 3);
            this.textEntDropdownLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textEntDropdownLog.Multiline = true;
            this.textEntDropdownLog.Name = "textEntDropdownLog";
            this.textEntDropdownLog.ReadOnly = true;
            this.textEntDropdownLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textEntDropdownLog.Size = new System.Drawing.Size(290, 496);
            this.textEntDropdownLog.TabIndex = 7;
            // 
            // panel3
            // 
            this.tableEntDropdownDetail.SetColumnSpan(this.panel3, 2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.radioEntDropdownShowEnt);
            this.panel3.Controls.Add(this.radioEntDropdownShowProps);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(2, 504);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(592, 52);
            this.panel3.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(592, 25);
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
            this.tabPageAttrList.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAttrList.Name = "tabPageAttrList";
            this.tabPageAttrList.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageAttrList.Size = new System.Drawing.Size(907, 564);
            this.tabPageAttrList.TabIndex = 4;
            this.tabPageAttrList.Text = "Attribute List Control";
            this.tabPageAttrList.UseVisualStyleBackColor = true;
            // 
            // splitterAttribList
            // 
            this.splitterAttribList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitterAttribList.Location = new System.Drawing.Point(2, 2);
            this.splitterAttribList.Margin = new System.Windows.Forms.Padding(2);
            this.splitterAttribList.Name = "splitterAttribList";
            // 
            // splitterAttribList.Panel1
            // 
            this.splitterAttribList.Panel1.Controls.Add(this.tableAttribList);
            // 
            // splitterAttribList.Panel2
            // 
            this.splitterAttribList.Panel2.Controls.Add(this.tableAttribListDetail);
            this.splitterAttribList.Size = new System.Drawing.Size(903, 560);
            this.splitterAttribList.SplitterDistance = 295;
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
            this.tableAttribList.Margin = new System.Windows.Forms.Padding(2);
            this.tableAttribList.Name = "tableAttribList";
            this.tableAttribList.RowCount = 4;
            this.tableAttribList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableAttribList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableAttribList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableAttribList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableAttribList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableAttribList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableAttribList.Size = new System.Drawing.Size(295, 560);
            this.tableAttribList.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(2, 62);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(291, 26);
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
            this.EntityDropdownAttribList.Size = new System.Drawing.Size(287, 30);
            this.EntityDropdownAttribList.SolutionFilter = null;
            this.EntityDropdownAttribList.TabIndex = 15;
            this.EntityDropdownAttribList.SelectedItemChanged += new System.EventHandler(this.EntityDropdownAttribList_SelectedItemChanged);
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(2, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(291, 26);
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
            this.AttribListControl.Location = new System.Drawing.Point(0, 89);
            this.AttribListControl.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.AttribListControl.Name = "AttribListControl";
            this.AttribListControl.ParentEntity = null;
            this.AttribListControl.ParentEntityLogicalName = null;
            this.AttribListControl.Service = null;
            this.AttribListControl.Size = new System.Drawing.Size(295, 495);
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
            this.tableAttribListDetail.Margin = new System.Windows.Forms.Padding(2);
            this.tableAttribListDetail.Name = "tableAttribListDetail";
            this.tableAttribListDetail.RowCount = 2;
            this.tableAttribListDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableAttribListDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableAttribListDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableAttribListDetail.Size = new System.Drawing.Size(598, 560);
            this.tableAttribListDetail.TabIndex = 21;
            // 
            // propGridAttrList
            // 
            this.propGridAttrList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propGridAttrList.Location = new System.Drawing.Point(4, 3);
            this.propGridAttrList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.propGridAttrList.Name = "propGridAttrList";
            this.propGridAttrList.Size = new System.Drawing.Size(291, 498);
            this.propGridAttrList.TabIndex = 8;
            // 
            // textAttribListLog
            // 
            this.textAttribListLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textAttribListLog.Location = new System.Drawing.Point(303, 3);
            this.textAttribListLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textAttribListLog.Multiline = true;
            this.textAttribListLog.Name = "textAttribListLog";
            this.textAttribListLog.ReadOnly = true;
            this.textAttribListLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textAttribListLog.Size = new System.Drawing.Size(291, 498);
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
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(594, 52);
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
            this.label13.Size = new System.Drawing.Size(594, 18);
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
            this.tabPageAttrDropDown.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAttrDropDown.Name = "tabPageAttrDropDown";
            this.tabPageAttrDropDown.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAttrDropDown.Size = new System.Drawing.Size(907, 564);
            this.tabPageAttrDropDown.TabIndex = 2;
            this.tabPageAttrDropDown.Text = "Attributes Dropdown";
            this.tabPageAttrDropDown.UseVisualStyleBackColor = true;
            // 
            // splitterAttribDropdown
            // 
            this.splitterAttribDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitterAttribDropdown.Location = new System.Drawing.Point(3, 3);
            this.splitterAttribDropdown.Margin = new System.Windows.Forms.Padding(2);
            this.splitterAttribDropdown.Name = "splitterAttribDropdown";
            // 
            // splitterAttribDropdown.Panel1
            // 
            this.splitterAttribDropdown.Panel1.Controls.Add(this.tableAttribDropdown);
            // 
            // splitterAttribDropdown.Panel2
            // 
            this.splitterAttribDropdown.Panel2.Controls.Add(this.tableAttribDropdownDetail);
            this.splitterAttribDropdown.Size = new System.Drawing.Size(901, 558);
            this.splitterAttribDropdown.SplitterDistance = 295;
            this.splitterAttribDropdown.SplitterWidth = 10;
            this.splitterAttribDropdown.TabIndex = 19;
            // 
            // tableAttribDropdown
            // 
            this.tableAttribDropdown.ColumnCount = 1;
            this.tableAttribDropdown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableAttribDropdown.Controls.Add(this.labelAttributes, 0, 2);
            this.tableAttribDropdown.Controls.Add(this.EntityDropdownAttribs, 0, 1);
            this.tableAttribDropdown.Controls.Add(this.label4, 0, 0);
            this.tableAttribDropdown.Controls.Add(this.listBoxAttributes, 0, 5);
            this.tableAttribDropdown.Controls.Add(this.label6, 0, 4);
            this.tableAttribDropdown.Controls.Add(this.panelAttrDropdown, 0, 3);
            this.tableAttribDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableAttribDropdown.Location = new System.Drawing.Point(0, 0);
            this.tableAttribDropdown.Margin = new System.Windows.Forms.Padding(2);
            this.tableAttribDropdown.Name = "tableAttribDropdown";
            this.tableAttribDropdown.RowCount = 6;
            this.tableAttribDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableAttribDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableAttribDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableAttribDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableAttribDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableAttribDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableAttribDropdown.Size = new System.Drawing.Size(295, 558);
            this.tableAttribDropdown.TabIndex = 19;
            // 
            // labelAttributes
            // 
            this.labelAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAttributes.Location = new System.Drawing.Point(2, 62);
            this.labelAttributes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAttributes.Name = "labelAttributes";
            this.labelAttributes.Size = new System.Drawing.Size(291, 26);
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
            this.EntityDropdownAttribs.Size = new System.Drawing.Size(287, 30);
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
            this.label4.Location = new System.Drawing.Point(2, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Entity Dropdown Control";
            // 
            // listBoxAttributes
            // 
            this.listBoxAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxAttributes.FormattingEnabled = true;
            this.listBoxAttributes.Location = new System.Drawing.Point(3, 153);
            this.listBoxAttributes.Name = "listBoxAttributes";
            this.listBoxAttributes.Size = new System.Drawing.Size(289, 427);
            this.listBoxAttributes.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(3, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(289, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Full list of Attributes";
            // 
            // panelAttrDropdown
            // 
            this.panelAttrDropdown.Controls.Add(this.AttributeDropdownBase);
            this.panelAttrDropdown.Controls.Add(this.buttonReload);
            this.panelAttrDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAttrDropdown.Location = new System.Drawing.Point(2, 90);
            this.panelAttrDropdown.Margin = new System.Windows.Forms.Padding(2);
            this.panelAttrDropdown.Name = "panelAttrDropdown";
            this.panelAttrDropdown.Padding = new System.Windows.Forms.Padding(5);
            this.panelAttrDropdown.Size = new System.Drawing.Size(291, 32);
            this.panelAttrDropdown.TabIndex = 21;
            // 
            // AttributeDropdownBase
            // 
            this.AttributeDropdownBase.AutoLoadData = false;
            this.AttributeDropdownBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AttributeDropdownBase.FormattingEnabled = true;
            this.AttributeDropdownBase.LanguageCode = 1033;
            this.AttributeDropdownBase.Location = new System.Drawing.Point(5, 5);
            this.AttributeDropdownBase.Margin = new System.Windows.Forms.Padding(2);
            this.AttributeDropdownBase.Name = "AttributeDropdownBase";
            this.AttributeDropdownBase.ParentEntity = null;
            this.AttributeDropdownBase.ParentEntityLogicalName = null;
            this.AttributeDropdownBase.Service = null;
            this.AttributeDropdownBase.Size = new System.Drawing.Size(262, 21);
            this.AttributeDropdownBase.TabIndex = 0;
            // 
            // buttonReload
            // 
            this.buttonReload.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonReload.Font = new System.Drawing.Font("Wingdings 3", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonReload.Location = new System.Drawing.Point(267, 5);
            this.buttonReload.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonReload.MinimumSize = new System.Drawing.Size(19, 19);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(19, 22);
            this.buttonReload.TabIndex = 2;
            this.buttonReload.Text = "P";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
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
            this.tableAttribDropdownDetail.Margin = new System.Windows.Forms.Padding(2);
            this.tableAttribDropdownDetail.Name = "tableAttribDropdownDetail";
            this.tableAttribDropdownDetail.RowCount = 2;
            this.tableAttribDropdownDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableAttribDropdownDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableAttribDropdownDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableAttribDropdownDetail.Size = new System.Drawing.Size(596, 558);
            this.tableAttribDropdownDetail.TabIndex = 21;
            // 
            // propGridAttribDropdown
            // 
            this.propGridAttribDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propGridAttribDropdown.Location = new System.Drawing.Point(4, 3);
            this.propGridAttribDropdown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.propGridAttribDropdown.Name = "propGridAttribDropdown";
            this.propGridAttribDropdown.Size = new System.Drawing.Size(290, 496);
            this.propGridAttribDropdown.TabIndex = 8;
            // 
            // textAttribDropdownLog
            // 
            this.textAttribDropdownLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textAttribDropdownLog.Location = new System.Drawing.Point(302, 3);
            this.textAttribDropdownLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textAttribDropdownLog.Multiline = true;
            this.textAttribDropdownLog.Name = "textAttribDropdownLog";
            this.textAttribDropdownLog.ReadOnly = true;
            this.textAttribDropdownLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textAttribDropdownLog.Size = new System.Drawing.Size(290, 496);
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
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(592, 52);
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
            this.label5.Size = new System.Drawing.Size(592, 18);
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
            this.tabPageSolution.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageSolution.Name = "tabPageSolution";
            this.tabPageSolution.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSolution.Size = new System.Drawing.Size(907, 564);
            this.tabPageSolution.TabIndex = 3;
            this.tabPageSolution.Text = "Solutions Dropdown";
            this.tabPageSolution.UseVisualStyleBackColor = true;
            // 
            // splitterSolnDropdown
            // 
            this.splitterSolnDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitterSolnDropdown.Location = new System.Drawing.Point(3, 3);
            this.splitterSolnDropdown.Margin = new System.Windows.Forms.Padding(2);
            this.splitterSolnDropdown.Name = "splitterSolnDropdown";
            // 
            // splitterSolnDropdown.Panel1
            // 
            this.splitterSolnDropdown.Panel1.Controls.Add(this.tableSolnDropdown);
            // 
            // splitterSolnDropdown.Panel2
            // 
            this.splitterSolnDropdown.Panel2.Controls.Add(this.tableSolnDropdownDetail);
            this.splitterSolnDropdown.Size = new System.Drawing.Size(901, 558);
            this.splitterSolnDropdown.SplitterDistance = 295;
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
            this.tableSolnDropdown.Margin = new System.Windows.Forms.Padding(2);
            this.tableSolnDropdown.Name = "tableSolnDropdown";
            this.tableSolnDropdown.RowCount = 4;
            this.tableSolnDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableSolnDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableSolnDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableSolnDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableSolnDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSolnDropdown.Size = new System.Drawing.Size(295, 558);
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
            this.label9.Size = new System.Drawing.Size(291, 26);
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
            this.SolutionDropdown.PublisherPrefixes = ((System.Collections.Generic.List<string>)(resources.GetObject("SolutionDropdown.PublisherPrefixes")));
            this.SolutionDropdown.Service = null;
            this.SolutionDropdown.Size = new System.Drawing.Size(295, 34);
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
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Solutions Dropdown Control";
            // 
            // listBoxSolutions
            // 
            this.listBoxSolutions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSolutions.FormattingEnabled = true;
            this.listBoxSolutions.Location = new System.Drawing.Point(3, 91);
            this.listBoxSolutions.Name = "listBoxSolutions";
            this.listBoxSolutions.Size = new System.Drawing.Size(289, 489);
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
            this.tableSolnDropdownDetail.Margin = new System.Windows.Forms.Padding(2);
            this.tableSolnDropdownDetail.Name = "tableSolnDropdownDetail";
            this.tableSolnDropdownDetail.RowCount = 2;
            this.tableSolnDropdownDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableSolnDropdownDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableSolnDropdownDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSolnDropdownDetail.Size = new System.Drawing.Size(596, 558);
            this.tableSolnDropdownDetail.TabIndex = 20;
            // 
            // propGridSolutions
            // 
            this.propGridSolutions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propGridSolutions.Location = new System.Drawing.Point(4, 3);
            this.propGridSolutions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.propGridSolutions.Name = "propGridSolutions";
            this.propGridSolutions.Size = new System.Drawing.Size(290, 496);
            this.propGridSolutions.TabIndex = 8;
            // 
            // textSolnDropdownLog
            // 
            this.textSolnDropdownLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textSolnDropdownLog.Location = new System.Drawing.Point(302, 3);
            this.textSolnDropdownLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textSolnDropdownLog.Multiline = true;
            this.textSolnDropdownLog.Name = "textSolnDropdownLog";
            this.textSolnDropdownLog.ReadOnly = true;
            this.textSolnDropdownLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textSolnDropdownLog.Size = new System.Drawing.Size(290, 496);
            this.textSolnDropdownLog.TabIndex = 7;
            // 
            // panel4
            // 
            this.tableSolnDropdownDetail.SetColumnSpan(this.panel4, 2);
            this.panel4.Controls.Add(this.radioSolnDropdownShowProps);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.radioSolnDropdownShowSoln);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(2, 504);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(592, 52);
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
            this.label8.Size = new System.Drawing.Size(592, 18);
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
            // tabPageViewsDropdown
            // 
            this.tabPageViewsDropdown.Controls.Add(this.splitterViewDropdown);
            this.tabPageViewsDropdown.Location = new System.Drawing.Point(4, 34);
            this.tabPageViewsDropdown.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageViewsDropdown.Name = "tabPageViewsDropdown";
            this.tabPageViewsDropdown.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageViewsDropdown.Size = new System.Drawing.Size(907, 564);
            this.tabPageViewsDropdown.TabIndex = 5;
            this.tabPageViewsDropdown.Text = "Views Dropdown";
            this.tabPageViewsDropdown.UseVisualStyleBackColor = true;
            // 
            // splitterViewDropdown
            // 
            this.splitterViewDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitterViewDropdown.Location = new System.Drawing.Point(2, 2);
            this.splitterViewDropdown.Margin = new System.Windows.Forms.Padding(2);
            this.splitterViewDropdown.Name = "splitterViewDropdown";
            // 
            // splitterViewDropdown.Panel1
            // 
            this.splitterViewDropdown.Panel1.Controls.Add(this.tableViewDropdown);
            // 
            // splitterViewDropdown.Panel2
            // 
            this.splitterViewDropdown.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitterViewDropdown.Size = new System.Drawing.Size(903, 560);
            this.splitterViewDropdown.SplitterDistance = 296;
            this.splitterViewDropdown.SplitterWidth = 10;
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
            this.tableViewDropdown.Margin = new System.Windows.Forms.Padding(2);
            this.tableViewDropdown.Name = "tableViewDropdown";
            this.tableViewDropdown.RowCount = 6;
            this.tableViewDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableViewDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableViewDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableViewDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableViewDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableViewDropdown.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableViewDropdown.Size = new System.Drawing.Size(296, 560);
            this.tableViewDropdown.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(2, 62);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(292, 26);
            this.label12.TabIndex = 18;
            this.label12.Text = "Views Dropdown";
            // 
            // EntityDropdownViews
            // 
            this.EntityDropdownViews.AutoLoadData = false;
            this.EntityDropdownViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EntityDropdownViews.LanguageCode = 1033;
            this.EntityDropdownViews.Location = new System.Drawing.Point(4, 29);
            this.EntityDropdownViews.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EntityDropdownViews.Name = "EntityDropdownViews";
            this.EntityDropdownViews.Service = null;
            this.EntityDropdownViews.Size = new System.Drawing.Size(288, 30);
            this.EntityDropdownViews.SolutionFilter = null;
            this.EntityDropdownViews.TabIndex = 15;
            this.EntityDropdownViews.SelectedItemChanged += new System.EventHandler(this.EntityDropdownViews_SelectedItemChanged);
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(2, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(292, 26);
            this.label14.TabIndex = 0;
            this.label14.Text = "Entity Dropdown Control";
            // 
            // listBoxViews
            // 
            this.listBoxViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxViews.FormattingEnabled = true;
            this.listBoxViews.Location = new System.Drawing.Point(3, 153);
            this.listBoxViews.Name = "listBoxViews";
            this.listBoxViews.Size = new System.Drawing.Size(290, 430);
            this.listBoxViews.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Location = new System.Drawing.Point(3, 124);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(290, 23);
            this.label15.TabIndex = 20;
            this.label15.Text = "Full list of Views";
            // 
            // ViewDropdown
            // 
            this.ViewDropdown.AutoLoadData = false;
            this.ViewDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewDropdown.IncludePersonalViews = false;
            this.ViewDropdown.LanguageCode = 1033;
            this.ViewDropdown.Location = new System.Drawing.Point(0, 89);
            this.ViewDropdown.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.ViewDropdown.Name = "ViewDropdown";
            this.ViewDropdown.ParentEntity = null;
            this.ViewDropdown.ParentEntityLogicalName = null;
            this.ViewDropdown.Service = null;
            this.ViewDropdown.Size = new System.Drawing.Size(296, 34);
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
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(597, 560);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // propGridViewDropdown
            // 
            this.propGridViewDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propGridViewDropdown.Location = new System.Drawing.Point(4, 3);
            this.propGridViewDropdown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.propGridViewDropdown.Name = "propGridViewDropdown";
            this.propGridViewDropdown.Size = new System.Drawing.Size(290, 498);
            this.propGridViewDropdown.TabIndex = 8;
            // 
            // textViewsDropdownLog
            // 
            this.textViewsDropdownLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textViewsDropdownLog.Location = new System.Drawing.Point(302, 3);
            this.textViewsDropdownLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textViewsDropdownLog.Multiline = true;
            this.textViewsDropdownLog.Name = "textViewsDropdownLog";
            this.textViewsDropdownLog.ReadOnly = true;
            this.textViewsDropdownLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textViewsDropdownLog.Size = new System.Drawing.Size(291, 498);
            this.textViewsDropdownLog.TabIndex = 7;
            // 
            // panel6
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.panel6, 2);
            this.panel6.Controls.Add(this.radioViewDropdownShowProps);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.radioAttribDropdownShowView);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(2, 506);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(593, 52);
            this.panel6.TabIndex = 16;
            // 
            // radioViewDropdownShowProps
            // 
            this.radioViewDropdownShowProps.AutoSize = true;
            this.radioViewDropdownShowProps.Checked = true;
            this.radioViewDropdownShowProps.Location = new System.Drawing.Point(14, 20);
            this.radioViewDropdownShowProps.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioViewDropdownShowProps.Name = "radioViewDropdownShowProps";
            this.radioViewDropdownShowProps.Size = new System.Drawing.Size(136, 17);
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
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(593, 18);
            this.label16.TabIndex = 4;
            this.label16.Text = "Choose what displays in the property control";
            // 
            // radioAttribDropdownShowView
            // 
            this.radioAttribDropdownShowView.AutoSize = true;
            this.radioAttribDropdownShowView.Location = new System.Drawing.Point(170, 20);
            this.radioAttribDropdownShowView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioAttribDropdownShowView.Name = "radioAttribDropdownShowView";
            this.radioAttribDropdownShowView.Size = new System.Drawing.Size(93, 17);
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
            this.tabPageGlobalOptSets.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageGlobalOptSets.Name = "tabPageGlobalOptSets";
            this.tabPageGlobalOptSets.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageGlobalOptSets.Size = new System.Drawing.Size(907, 564);
            this.tabPageGlobalOptSets.TabIndex = 6;
            this.tabPageGlobalOptSets.Text = "Global OptionSet ListView";
            this.tabPageGlobalOptSets.UseVisualStyleBackColor = true;
            // 
            // splitterGlobalOptsList
            // 
            this.splitterGlobalOptsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitterGlobalOptsList.Location = new System.Drawing.Point(2, 2);
            this.splitterGlobalOptsList.Margin = new System.Windows.Forms.Padding(2);
            this.splitterGlobalOptsList.Name = "splitterGlobalOptsList";
            // 
            // splitterGlobalOptsList.Panel1
            // 
            this.splitterGlobalOptsList.Panel1.Controls.Add(this.GlobalOptionSetList);
            // 
            // splitterGlobalOptsList.Panel2
            // 
            this.splitterGlobalOptsList.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitterGlobalOptsList.Size = new System.Drawing.Size(903, 560);
            this.splitterGlobalOptsList.SplitterDistance = 296;
            this.splitterGlobalOptsList.SplitterWidth = 10;
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
            this.GlobalOptionSetList.Margin = new System.Windows.Forms.Padding(1);
            this.GlobalOptionSetList.Name = "GlobalOptionSetList";
            this.GlobalOptionSetList.RetrieveAsIfPublished = false;
            this.GlobalOptionSetList.Service = null;
            this.GlobalOptionSetList.Size = new System.Drawing.Size(296, 560);
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(597, 560);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // panel7
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel7, 2);
            this.panel7.Controls.Add(this.radioGlobalOptsListShowProps);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.radioEntDropdownShowOptionSet);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(2, 506);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(593, 52);
            this.panel7.TabIndex = 16;
            // 
            // radioGlobalOptsListShowProps
            // 
            this.radioGlobalOptsListShowProps.AutoSize = true;
            this.radioGlobalOptsListShowProps.Checked = true;
            this.radioGlobalOptsListShowProps.Location = new System.Drawing.Point(10, 27);
            this.radioGlobalOptsListShowProps.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioGlobalOptsListShowProps.Name = "radioGlobalOptsListShowProps";
            this.radioGlobalOptsListShowProps.Size = new System.Drawing.Size(183, 17);
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
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(593, 23);
            this.label17.TabIndex = 4;
            this.label17.Text = "Choose what displays in the property control";
            // 
            // radioEntDropdownShowOptionSet
            // 
            this.radioEntDropdownShowOptionSet.AutoSize = true;
            this.radioEntDropdownShowOptionSet.Location = new System.Drawing.Point(204, 27);
            this.radioEntDropdownShowOptionSet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioEntDropdownShowOptionSet.Name = "radioEntDropdownShowOptionSet";
            this.radioEntDropdownShowOptionSet.Size = new System.Drawing.Size(150, 17);
            this.radioEntDropdownShowOptionSet.TabIndex = 2;
            this.radioEntDropdownShowOptionSet.TabStop = true;
            this.radioEntDropdownShowOptionSet.Text = "Selected Global OptionSet";
            this.radioEntDropdownShowOptionSet.UseVisualStyleBackColor = true;
            this.radioEntDropdownShowOptionSet.CheckedChanged += new System.EventHandler(this.RadioGlobalOptionSetList_CheckedChanged);
            // 
            // propGridGlobalOptsList
            // 
            this.propGridGlobalOptsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propGridGlobalOptsList.Location = new System.Drawing.Point(4, 3);
            this.propGridGlobalOptsList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.propGridGlobalOptsList.Name = "propGridGlobalOptsList";
            this.propGridGlobalOptsList.Size = new System.Drawing.Size(290, 498);
            this.propGridGlobalOptsList.TabIndex = 8;
            // 
            // textGlobalOptsListLog
            // 
            this.textGlobalOptsListLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textGlobalOptsListLog.Location = new System.Drawing.Point(302, 3);
            this.textGlobalOptsListLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textGlobalOptsListLog.Multiline = true;
            this.textGlobalOptsListLog.Name = "textGlobalOptsListLog";
            this.textGlobalOptsListLog.ReadOnly = true;
            this.textGlobalOptsListLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textGlobalOptsListLog.Size = new System.Drawing.Size(291, 498);
            this.textGlobalOptsListLog.TabIndex = 7;
            // 
            // tabPageCRMGridView
            // 
            this.tabPageCRMGridView.Controls.Add(this.splitterCRMGridView);
            this.tabPageCRMGridView.Location = new System.Drawing.Point(4, 34);
            this.tabPageCRMGridView.Name = "tabPageCRMGridView";
            this.tabPageCRMGridView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCRMGridView.Size = new System.Drawing.Size(907, 564);
            this.tabPageCRMGridView.TabIndex = 7;
            this.tabPageCRMGridView.Text = "CRM GridView";
            this.tabPageCRMGridView.UseVisualStyleBackColor = true;
            // 
            // splitterCRMGridView
            // 
            this.splitterCRMGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitterCRMGridView.Location = new System.Drawing.Point(3, 3);
            this.splitterCRMGridView.Margin = new System.Windows.Forms.Padding(2);
            this.splitterCRMGridView.Name = "splitterCRMGridView";
            // 
            // splitterCRMGridView.Panel1
            // 
            this.splitterCRMGridView.Panel1.Controls.Add(this.tableCRMGridView);
            // 
            // splitterCRMGridView.Panel2
            // 
            this.splitterCRMGridView.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitterCRMGridView.Size = new System.Drawing.Size(901, 558);
            this.splitterCRMGridView.SplitterDistance = 295;
            this.splitterCRMGridView.SplitterWidth = 10;
            this.splitterCRMGridView.TabIndex = 2;
            // 
            // tableCRMGridView
            // 
            this.tableCRMGridView.ColumnCount = 1;
            this.tableCRMGridView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableCRMGridView.Controls.Add(this.panelCrmGridViewControls, 0, 0);
            this.tableCRMGridView.Controls.Add(this.CrmGridView, 0, 2);
            this.tableCRMGridView.Controls.Add(this.XmlViewerCRMDataGrid, 0, 1);
            this.tableCRMGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableCRMGridView.Location = new System.Drawing.Point(0, 0);
            this.tableCRMGridView.Margin = new System.Windows.Forms.Padding(2);
            this.tableCRMGridView.Name = "tableCRMGridView";
            this.tableCRMGridView.RowCount = 3;
            this.tableCRMGridView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableCRMGridView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableCRMGridView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableCRMGridView.Size = new System.Drawing.Size(295, 558);
            this.tableCRMGridView.TabIndex = 0;
            // 
            // panelCrmGridViewControls
            // 
            this.panelCrmGridViewControls.Controls.Add(this.dataGridViewGrouperControl1);
            this.panelCrmGridViewControls.Controls.Add(this.flowLayoutPanel1);
            this.panelCrmGridViewControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCrmGridViewControls.Location = new System.Drawing.Point(2, 2);
            this.panelCrmGridViewControls.Margin = new System.Windows.Forms.Padding(2);
            this.panelCrmGridViewControls.Name = "panelCrmGridViewControls";
            this.panelCrmGridViewControls.Size = new System.Drawing.Size(291, 50);
            this.panelCrmGridViewControls.TabIndex = 5;
            // 
            // dataGridViewGrouperControl1
            // 
            this.dataGridViewGrouperControl1.AllowDrop = true;
            this.dataGridViewGrouperControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataGridViewGrouperControl1.DataGridView = this.CrmGridView;
            this.dataGridViewGrouperControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewGrouperControl1.Location = new System.Drawing.Point(0, 26);
            this.dataGridViewGrouperControl1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridViewGrouperControl1.Name = "dataGridViewGrouperControl1";
            this.dataGridViewGrouperControl1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.dataGridViewGrouperControl1.Size = new System.Drawing.Size(291, 24);
            this.dataGridViewGrouperControl1.TabIndex = 5;
            // 
            // CrmGridView
            // 
            this.CrmGridView.AllowUserToAddRows = false;
            this.CrmGridView.AllowUserToDeleteRows = false;
            this.CrmGridView.AllowUserToOrderColumns = true;
            this.CrmGridView.AllowUserToResizeRows = false;
            this.CrmGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CrmGridView.ColumnOrder = "";
            this.CrmGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrmGridView.FilterColumns = "";
            this.CrmGridView.Location = new System.Drawing.Point(3, 258);
            this.CrmGridView.Name = "CrmGridView";
            this.CrmGridView.ReadOnly = true;
            this.CrmGridView.RowHeadersWidth = 72;
            this.CrmGridView.ShowFriendlyNames = true;
            this.CrmGridView.Size = new System.Drawing.Size(289, 297);
            this.CrmGridView.TabIndex = 2;
            this.CrmGridView.RecordClick += new xrmtb.XrmToolBox.Controls.CRMRecordEventHandler(this.crmGridView1_RecordClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelExecFetch);
            this.flowLayoutPanel1.Controls.Add(this.buttonExecFetch);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(291, 29);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // labelExecFetch
            // 
            this.labelExecFetch.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelExecFetch.Location = new System.Drawing.Point(2, 0);
            this.labelExecFetch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelExecFetch.Name = "labelExecFetch";
            this.labelExecFetch.Size = new System.Drawing.Size(131, 39);
            this.labelExecFetch.TabIndex = 3;
            this.labelExecFetch.Text = "Enter FetchXml below: ";
            this.labelExecFetch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonExecFetch
            // 
            this.buttonExecFetch.AutoSize = true;
            this.buttonExecFetch.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonExecFetch.Location = new System.Drawing.Point(137, 2);
            this.buttonExecFetch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExecFetch.Name = "buttonExecFetch";
            this.buttonExecFetch.Size = new System.Drawing.Size(147, 35);
            this.buttonExecFetch.TabIndex = 4;
            this.buttonExecFetch.Text = "Execute Fetch";
            this.buttonExecFetch.UseVisualStyleBackColor = true;
            this.buttonExecFetch.Click += new System.EventHandler(this.buttonExecFetch_Click);
            // 
            // XmlViewerCRMDataGrid
            // 
            this.XmlViewerCRMDataGrid.CurrentParseError = ((System.Exception)(resources.GetObject("XmlViewerCRMDataGrid.CurrentParseError")));
            this.XmlViewerCRMDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XmlViewerCRMDataGrid.FormatAsYouType = true;
            this.XmlViewerCRMDataGrid.Location = new System.Drawing.Point(2, 56);
            this.XmlViewerCRMDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.XmlViewerCRMDataGrid.Name = "XmlViewerCRMDataGrid";
            xmlViewerSettings1.AttributeKey = System.Drawing.Color.Blue;
            xmlViewerSettings1.AttributeValue = System.Drawing.Color.DarkRed;
            xmlViewerSettings1.Comment = System.Drawing.Color.Gray;
            xmlViewerSettings1.Element = System.Drawing.Color.DarkGreen;
            xmlViewerSettings1.FontName = "Consolas";
            xmlViewerSettings1.FontSize = 9F;
            xmlViewerSettings1.QuoteCharacter = '\"';
            xmlViewerSettings1.Tag = System.Drawing.Color.ForestGreen;
            xmlViewerSettings1.Value = System.Drawing.Color.Black;
            this.XmlViewerCRMDataGrid.Settings = xmlViewerSettings1;
            this.XmlViewerCRMDataGrid.Size = new System.Drawing.Size(291, 197);
            this.XmlViewerCRMDataGrid.TabIndex = 5;
            this.XmlViewerCRMDataGrid.Text = "";
            this.XmlViewerCRMDataGrid.TextChanged += new System.EventHandler(this.XmlViewerCRMDataGrid_TextChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel8, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.propCRMGridView, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel11, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(596, 558);
            this.tableLayoutPanel3.TabIndex = 20;
            // 
            // panel8
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.panel8, 2);
            this.panel8.Controls.Add(this.radioCRMGridViewRightShowProps);
            this.panel8.Controls.Add(this.radioCRMGridViewShowProps);
            this.panel8.Controls.Add(this.label18);
            this.panel8.Controls.Add(this.radioCRMGridViewSelEntity);
            this.panel8.Controls.Add(this.groupBox1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(2, 490);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(592, 66);
            this.panel8.TabIndex = 16;
            // 
            // radioCRMGridViewRightShowProps
            // 
            this.radioCRMGridViewRightShowProps.AutoSize = true;
            this.radioCRMGridViewRightShowProps.Checked = true;
            this.radioCRMGridViewRightShowProps.Location = new System.Drawing.Point(10, 39);
            this.radioCRMGridViewRightShowProps.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioCRMGridViewRightShowProps.Name = "radioCRMGridViewRightShowProps";
            this.radioCRMGridViewRightShowProps.Size = new System.Drawing.Size(119, 17);
            this.radioCRMGridViewRightShowProps.TabIndex = 7;
            this.radioCRMGridViewRightShowProps.TabStop = true;
            this.radioCRMGridViewRightShowProps.Text = "CRMGridView Right";
            this.radioCRMGridViewRightShowProps.UseVisualStyleBackColor = true;
            this.radioCRMGridViewRightShowProps.CheckedChanged += new System.EventHandler(this.RadioCRMGridViewShowProps_CheckedChanged);
            // 
            // radioCRMGridViewShowProps
            // 
            this.radioCRMGridViewShowProps.AutoSize = true;
            this.radioCRMGridViewShowProps.Checked = true;
            this.radioCRMGridViewShowProps.Location = new System.Drawing.Point(10, 21);
            this.radioCRMGridViewShowProps.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioCRMGridViewShowProps.Name = "radioCRMGridViewShowProps";
            this.radioCRMGridViewShowProps.Size = new System.Drawing.Size(112, 17);
            this.radioCRMGridViewShowProps.TabIndex = 3;
            this.radioCRMGridViewShowProps.TabStop = true;
            this.radioCRMGridViewShowProps.Text = "CRMGridView Left";
            this.radioCRMGridViewShowProps.UseVisualStyleBackColor = true;
            this.radioCRMGridViewShowProps.CheckedChanged += new System.EventHandler(this.RadioCRMGridViewShowProps_CheckedChanged);
            // 
            // label18
            // 
            this.label18.Dock = System.Windows.Forms.DockStyle.Top;
            this.label18.Location = new System.Drawing.Point(0, 0);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(301, 23);
            this.label18.TabIndex = 4;
            this.label18.Text = "Choose what displays in the property control";
            // 
            // radioCRMGridViewSelEntity
            // 
            this.radioCRMGridViewSelEntity.AutoSize = true;
            this.radioCRMGridViewSelEntity.Location = new System.Drawing.Point(130, 21);
            this.radioCRMGridViewSelEntity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioCRMGridViewSelEntity.Name = "radioCRMGridViewSelEntity";
            this.radioCRMGridViewSelEntity.Size = new System.Drawing.Size(96, 17);
            this.radioCRMGridViewSelEntity.TabIndex = 2;
            this.radioCRMGridViewSelEntity.TabStop = true;
            this.radioCRMGridViewSelEntity.Text = "Selected Entity";
            this.radioCRMGridViewSelEntity.UseVisualStyleBackColor = true;
            this.radioCRMGridViewSelEntity.CheckedChanged += new System.EventHandler(this.RadioCRMGridViewShowProps_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textCdsDataComboBoxFormat);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.cdsDataComboBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(301, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 66);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CDSDataComboBox";
            // 
            // textCdsDataComboBoxFormat
            // 
            this.textCdsDataComboBoxFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCdsDataComboBoxFormat.Location = new System.Drawing.Point(58, 17);
            this.textCdsDataComboBoxFormat.Name = "textCdsDataComboBoxFormat";
            this.textCdsDataComboBoxFormat.Size = new System.Drawing.Size(227, 20);
            this.textCdsDataComboBoxFormat.TabIndex = 7;
            this.textCdsDataComboBoxFormat.TextChanged += new System.EventHandler(this.textCdsDataComboBoxFormat_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(13, 20);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 13);
            this.label21.TabIndex = 6;
            this.label21.Text = "Format";
            // 
            // cdsDataComboBox
            // 
            this.cdsDataComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cdsDataComboBox.DisplayFormat = "";
            this.cdsDataComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdsDataComboBox.FormattingEnabled = true;
            this.cdsDataComboBox.Location = new System.Drawing.Point(6, 39);
            this.cdsDataComboBox.Name = "cdsDataComboBox";
            this.cdsDataComboBox.Size = new System.Drawing.Size(279, 21);
            this.cdsDataComboBox.TabIndex = 5;
            this.cdsDataComboBox.SelectedIndexChanged += new System.EventHandler(this.cdsDataComboBox_SelectedIndexChanged);
            // 
            // propCRMGridView
            // 
            this.propCRMGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propCRMGridView.Location = new System.Drawing.Point(4, 3);
            this.propCRMGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.propCRMGridView.Name = "propCRMGridView";
            this.propCRMGridView.Size = new System.Drawing.Size(290, 482);
            this.propCRMGridView.TabIndex = 8;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.CrmGridViewDesignedCols);
            this.panel11.Controls.Add(this.buttonExecPredefinedCrmGridViewQuery);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(301, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(292, 482);
            this.panel11.TabIndex = 17;
            // 
            // CrmGridViewDesignedCols
            // 
            this.CrmGridViewDesignedCols.AllowUserToAddRows = false;
            this.CrmGridViewDesignedCols.AllowUserToDeleteRows = false;
            this.CrmGridViewDesignedCols.AllowUserToOrderColumns = true;
            this.CrmGridViewDesignedCols.AllowUserToResizeRows = false;
            this.CrmGridViewDesignedCols.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CrmGridViewDesignedCols.ColumnOrder = "";
            this.CrmGridViewDesignedCols.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.revenue});
            this.CrmGridViewDesignedCols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrmGridViewDesignedCols.EnableHeadersVisualStyles = false;
            this.CrmGridViewDesignedCols.FilterColumns = "name";
            this.CrmGridViewDesignedCols.Location = new System.Drawing.Point(0, 23);
            this.CrmGridViewDesignedCols.Name = "CrmGridViewDesignedCols";
            this.CrmGridViewDesignedCols.ReadOnly = true;
            this.CrmGridViewDesignedCols.ShowFriendlyNames = true;
            this.CrmGridViewDesignedCols.ShowIdColumn = false;
            this.CrmGridViewDesignedCols.ShowIndexColumn = false;
            this.CrmGridViewDesignedCols.ShowLocalTimes = true;
            this.CrmGridViewDesignedCols.Size = new System.Drawing.Size(292, 459);
            this.CrmGridViewDesignedCols.TabIndex = 0;
            // 
            // name
            // 
            this.name.HeaderText = "Account Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // revenue
            // 
            this.revenue.HeaderText = "Revenue";
            this.revenue.Name = "revenue";
            this.revenue.ReadOnly = true;
            // 
            // buttonExecPredefinedCrmGridViewQuery
            // 
            this.buttonExecPredefinedCrmGridViewQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonExecPredefinedCrmGridViewQuery.Location = new System.Drawing.Point(0, 0);
            this.buttonExecPredefinedCrmGridViewQuery.Name = "buttonExecPredefinedCrmGridViewQuery";
            this.buttonExecPredefinedCrmGridViewQuery.Size = new System.Drawing.Size(292, 23);
            this.buttonExecPredefinedCrmGridViewQuery.TabIndex = 1;
            this.buttonExecPredefinedCrmGridViewQuery.Text = "Execute predefined query";
            this.buttonExecPredefinedCrmGridViewQuery.UseVisualStyleBackColor = true;
            this.buttonExecPredefinedCrmGridViewQuery.Click += new System.EventHandler(this.buttonExecPredefinedCrmGridViewQuery_Click);
            // 
            // tabPageXrmViewer
            // 
            this.tabPageXrmViewer.Controls.Add(this.TableXmlViewers);
            this.tabPageXrmViewer.Location = new System.Drawing.Point(4, 34);
            this.tabPageXrmViewer.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageXrmViewer.Name = "tabPageXrmViewer";
            this.tabPageXrmViewer.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageXrmViewer.Size = new System.Drawing.Size(907, 564);
            this.tabPageXrmViewer.TabIndex = 8;
            this.tabPageXrmViewer.Text = "XrmViewer";
            this.tabPageXrmViewer.UseVisualStyleBackColor = true;
            // 
            // TableXmlViewers
            // 
            this.TableXmlViewers.ColumnCount = 1;
            this.TableXmlViewers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableXmlViewers.Controls.Add(this.splitterXmlViewerControl, 0, 1);
            this.TableXmlViewers.Controls.Add(this.splitterXmlViewer, 0, 3);
            this.TableXmlViewers.Controls.Add(this.labelXmlViewerControlTitle, 0, 0);
            this.TableXmlViewers.Controls.Add(this.labelXmlViewerTitle, 0, 2);
            this.TableXmlViewers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableXmlViewers.Location = new System.Drawing.Point(2, 2);
            this.TableXmlViewers.Margin = new System.Windows.Forms.Padding(2);
            this.TableXmlViewers.Name = "TableXmlViewers";
            this.TableXmlViewers.RowCount = 4;
            this.TableXmlViewers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.TableXmlViewers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableXmlViewers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.TableXmlViewers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableXmlViewers.Size = new System.Drawing.Size(903, 560);
            this.TableXmlViewers.TabIndex = 2;
            // 
            // splitterXmlViewerControl
            // 
            this.splitterXmlViewerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitterXmlViewerControl.Location = new System.Drawing.Point(2, 25);
            this.splitterXmlViewerControl.Margin = new System.Windows.Forms.Padding(2);
            this.splitterXmlViewerControl.Name = "splitterXmlViewerControl";
            // 
            // splitterXmlViewerControl.Panel1
            // 
            this.splitterXmlViewerControl.Panel1.Controls.Add(this.XmlViewerControl);
            // 
            // splitterXmlViewerControl.Panel2
            // 
            this.splitterXmlViewerControl.Panel2.Controls.Add(this.propGridXmlViewerControl);
            this.splitterXmlViewerControl.Size = new System.Drawing.Size(899, 253);
            this.splitterXmlViewerControl.SplitterDistance = 454;
            this.splitterXmlViewerControl.SplitterWidth = 8;
            this.splitterXmlViewerControl.TabIndex = 1;
            // 
            // XmlViewerControl
            // 
            this.XmlViewerControl.AcceptsTab = false;
            this.XmlViewerControl.AutoWordSelection = false;
            this.XmlViewerControl.BulletIndent = 0;
            this.XmlViewerControl.DetectUrls = true;
            this.XmlViewerControl.DisplayParseErrors = true;
            this.XmlViewerControl.DisplayToolbar = false;
            this.XmlViewerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XmlViewerControl.EnableAutoDragDrop = false;
            this.XmlViewerControl.FormatAsYouType = true;
            this.XmlViewerControl.HideSelection = true;
            this.XmlViewerControl.Location = new System.Drawing.Point(0, 0);
            this.XmlViewerControl.Margin = new System.Windows.Forms.Padding(2);
            this.XmlViewerControl.MaxLength = 2147483647;
            this.XmlViewerControl.Multiline = true;
            this.XmlViewerControl.Name = "XmlViewerControl";
            this.XmlViewerControl.ReadOnly = false;
            this.XmlViewerControl.RightMargin = 0;
            this.XmlViewerControl.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
            xmlViewerSettings2.AttributeKey = System.Drawing.Color.Blue;
            xmlViewerSettings2.AttributeValue = System.Drawing.Color.DarkRed;
            xmlViewerSettings2.Comment = System.Drawing.Color.Gray;
            xmlViewerSettings2.Element = System.Drawing.Color.DarkGreen;
            xmlViewerSettings2.FontName = "Consolas";
            xmlViewerSettings2.FontSize = 9F;
            xmlViewerSettings2.QuoteCharacter = '\"';
            xmlViewerSettings2.Tag = System.Drawing.Color.ForestGreen;
            xmlViewerSettings2.Value = System.Drawing.Color.Black;
            this.XmlViewerControl.Settings = xmlViewerSettings2;
            this.XmlViewerControl.ShortcutsEnabled = true;
            this.XmlViewerControl.ShowSelectionMargin = false;
            this.XmlViewerControl.Size = new System.Drawing.Size(454, 253);
            this.XmlViewerControl.TabIndex = 0;
            this.XmlViewerControl.WordWrap = true;
            this.XmlViewerControl.ZoomFactor = 1F;
            // 
            // propGridXmlViewerControl
            // 
            this.propGridXmlViewerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propGridXmlViewerControl.Location = new System.Drawing.Point(0, 0);
            this.propGridXmlViewerControl.Margin = new System.Windows.Forms.Padding(2);
            this.propGridXmlViewerControl.Name = "propGridXmlViewerControl";
            this.propGridXmlViewerControl.SelectedObject = this.XmlViewerControl;
            this.propGridXmlViewerControl.Size = new System.Drawing.Size(437, 253);
            this.propGridXmlViewerControl.TabIndex = 0;
            // 
            // splitterXmlViewer
            // 
            this.splitterXmlViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitterXmlViewer.Location = new System.Drawing.Point(2, 305);
            this.splitterXmlViewer.Margin = new System.Windows.Forms.Padding(2);
            this.splitterXmlViewer.Name = "splitterXmlViewer";
            // 
            // splitterXmlViewer.Panel1
            // 
            this.splitterXmlViewer.Panel1.Controls.Add(this.XmlViewer);
            // 
            // splitterXmlViewer.Panel2
            // 
            this.splitterXmlViewer.Panel2.Controls.Add(this.propGridXmlViewer);
            this.splitterXmlViewer.Size = new System.Drawing.Size(899, 253);
            this.splitterXmlViewer.SplitterDistance = 460;
            this.splitterXmlViewer.SplitterWidth = 8;
            this.splitterXmlViewer.TabIndex = 2;
            // 
            // XmlViewer
            // 
            this.XmlViewer.CurrentParseError = null;
            this.XmlViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XmlViewer.FormatAsYouType = true;
            this.XmlViewer.Location = new System.Drawing.Point(0, 0);
            this.XmlViewer.Margin = new System.Windows.Forms.Padding(2);
            this.XmlViewer.Name = "XmlViewer";
            xmlViewerSettings3.AttributeKey = System.Drawing.Color.Blue;
            xmlViewerSettings3.AttributeValue = System.Drawing.Color.DarkRed;
            xmlViewerSettings3.Comment = System.Drawing.Color.Gray;
            xmlViewerSettings3.Element = System.Drawing.Color.DarkGreen;
            xmlViewerSettings3.FontName = "Consolas";
            xmlViewerSettings3.FontSize = 9F;
            xmlViewerSettings3.QuoteCharacter = '\"';
            xmlViewerSettings3.Tag = System.Drawing.Color.ForestGreen;
            xmlViewerSettings3.Value = System.Drawing.Color.Black;
            this.XmlViewer.Settings = xmlViewerSettings3;
            this.XmlViewer.Size = new System.Drawing.Size(460, 253);
            this.XmlViewer.TabIndex = 0;
            this.XmlViewer.Text = "";
            // 
            // propGridXmlViewer
            // 
            this.propGridXmlViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propGridXmlViewer.Location = new System.Drawing.Point(0, 0);
            this.propGridXmlViewer.Margin = new System.Windows.Forms.Padding(2);
            this.propGridXmlViewer.Name = "propGridXmlViewer";
            this.propGridXmlViewer.SelectedObject = this.XmlViewer;
            this.propGridXmlViewer.Size = new System.Drawing.Size(431, 253);
            this.propGridXmlViewer.TabIndex = 0;
            // 
            // labelXmlViewerControlTitle
            // 
            this.labelXmlViewerControlTitle.AutoSize = true;
            this.labelXmlViewerControlTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelXmlViewerControlTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXmlViewerControlTitle.Location = new System.Drawing.Point(2, 0);
            this.labelXmlViewerControlTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelXmlViewerControlTitle.Name = "labelXmlViewerControlTitle";
            this.labelXmlViewerControlTitle.Size = new System.Drawing.Size(899, 23);
            this.labelXmlViewerControlTitle.TabIndex = 3;
            this.labelXmlViewerControlTitle.Text = "XmlViewerControl";
            this.labelXmlViewerControlTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelXmlViewerTitle
            // 
            this.labelXmlViewerTitle.AutoSize = true;
            this.labelXmlViewerTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelXmlViewerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXmlViewerTitle.Location = new System.Drawing.Point(2, 280);
            this.labelXmlViewerTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelXmlViewerTitle.Name = "labelXmlViewerTitle";
            this.labelXmlViewerTitle.Size = new System.Drawing.Size(899, 23);
            this.labelXmlViewerTitle.TabIndex = 4;
            this.labelXmlViewerTitle.Text = "XmlViewer";
            this.labelXmlViewerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageBoundListIVew
            // 
            this.tabPageBoundListIVew.Controls.Add(this.splitterBoundListView);
            this.tabPageBoundListIVew.Location = new System.Drawing.Point(4, 34);
            this.tabPageBoundListIVew.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageBoundListIVew.Name = "tabPageBoundListIVew";
            this.tabPageBoundListIVew.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageBoundListIVew.Size = new System.Drawing.Size(907, 564);
            this.tabPageBoundListIVew.TabIndex = 9;
            this.tabPageBoundListIVew.Text = "BoundListView";
            this.tabPageBoundListIVew.UseVisualStyleBackColor = true;
            // 
            // splitterBoundListView
            // 
            this.splitterBoundListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitterBoundListView.Location = new System.Drawing.Point(2, 2);
            this.splitterBoundListView.Margin = new System.Windows.Forms.Padding(2);
            this.splitterBoundListView.Name = "splitterBoundListView";
            // 
            // splitterBoundListView.Panel1
            // 
            this.splitterBoundListView.Panel1.Controls.Add(this.splitterEntList);
            this.splitterBoundListView.Panel1.Controls.Add(this.listViewEntCollection);
            this.splitterBoundListView.Panel1.Controls.Add(this.xmlViewerEntColl);
            this.splitterBoundListView.Panel1.Controls.Add(this.flowLayoutPanel2);
            // 
            // splitterBoundListView.Panel2
            // 
            this.splitterBoundListView.Panel2.Controls.Add(this.tableLayoutPanel4);
            this.splitterBoundListView.Size = new System.Drawing.Size(903, 560);
            this.splitterBoundListView.SplitterDistance = 295;
            this.splitterBoundListView.SplitterWidth = 10;
            this.splitterBoundListView.TabIndex = 1;
            // 
            // splitterEntList
            // 
            this.splitterEntList.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterEntList.Location = new System.Drawing.Point(0, 336);
            this.splitterEntList.Margin = new System.Windows.Forms.Padding(2);
            this.splitterEntList.Name = "splitterEntList";
            this.splitterEntList.Size = new System.Drawing.Size(295, 5);
            this.splitterEntList.TabIndex = 10;
            this.splitterEntList.TabStop = false;
            // 
            // listViewEntCollection
            // 
            this.listViewEntCollection.AutoLoadData = false;
            this.listViewEntCollection.AutoRefresh = false;
            this.listViewEntCollection.AutosizeColumns = System.Windows.Forms.ColumnHeaderAutoResizeStyle.None;
            this.listViewEntCollection.CheckBoxes = true;
            this.listViewEntCollection.DisplayCheckBoxes = true;
            this.listViewEntCollection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewEntCollection.FullRowSelect = true;
            this.listViewEntCollection.HideSelection = false;
            this.listViewEntCollection.LanguageCode = 1033;
            this.listViewEntCollection.ListViewColDefs = new xrmtb.XrmToolBox.Controls.ListViewColumnDef[] {
        ((xrmtb.XrmToolBox.Controls.ListViewColumnDef)(resources.GetObject("listViewEntCollection.ListViewColDefs"))),
        ((xrmtb.XrmToolBox.Controls.ListViewColumnDef)(resources.GetObject("listViewEntCollection.ListViewColDefs1"))),
        ((xrmtb.XrmToolBox.Controls.ListViewColumnDef)(resources.GetObject("listViewEntCollection.ListViewColDefs2")))};
            this.listViewEntCollection.Location = new System.Drawing.Point(0, 336);
            this.listViewEntCollection.Margin = new System.Windows.Forms.Padding(2);
            this.listViewEntCollection.Name = "listViewEntCollection";
            this.listViewEntCollection.Service = null;
            this.listViewEntCollection.ShowFriendlyNames = true;
            this.listViewEntCollection.ShowLocalTimes = true;
            this.listViewEntCollection.Size = new System.Drawing.Size(295, 224);
            this.listViewEntCollection.TabIndex = 1;
            this.listViewEntCollection.UseCompatibleStateImageBehavior = false;
            this.listViewEntCollection.View = System.Windows.Forms.View.Details;
            // 
            // xmlViewerEntColl
            // 
            this.xmlViewerEntColl.CurrentParseError = ((System.Exception)(resources.GetObject("xmlViewerEntColl.CurrentParseError")));
            this.xmlViewerEntColl.Dock = System.Windows.Forms.DockStyle.Top;
            this.xmlViewerEntColl.FormatAsYouType = true;
            this.xmlViewerEntColl.Location = new System.Drawing.Point(0, 34);
            this.xmlViewerEntColl.Margin = new System.Windows.Forms.Padding(2);
            this.xmlViewerEntColl.Name = "xmlViewerEntColl";
            xmlViewerSettings4.AttributeKey = System.Drawing.Color.Blue;
            xmlViewerSettings4.AttributeValue = System.Drawing.Color.DarkRed;
            xmlViewerSettings4.Comment = System.Drawing.Color.Gray;
            xmlViewerSettings4.Element = System.Drawing.Color.DarkGreen;
            xmlViewerSettings4.FontName = "Consolas";
            xmlViewerSettings4.FontSize = 9F;
            xmlViewerSettings4.QuoteCharacter = '\"';
            xmlViewerSettings4.Tag = System.Drawing.Color.ForestGreen;
            xmlViewerSettings4.Value = System.Drawing.Color.Black;
            this.xmlViewerEntColl.Settings = xmlViewerSettings4;
            this.xmlViewerEntColl.Size = new System.Drawing.Size(295, 302);
            this.xmlViewerEntColl.TabIndex = 8;
            this.xmlViewerEntColl.Text = "";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.labelExecFetchBoundList);
            this.flowLayoutPanel2.Controls.Add(this.buttonExecFetchBoundList);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(295, 34);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // labelExecFetchBoundList
            // 
            this.labelExecFetchBoundList.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelExecFetchBoundList.Location = new System.Drawing.Point(2, 0);
            this.labelExecFetchBoundList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelExecFetchBoundList.Name = "labelExecFetchBoundList";
            this.labelExecFetchBoundList.Size = new System.Drawing.Size(131, 27);
            this.labelExecFetchBoundList.TabIndex = 3;
            this.labelExecFetchBoundList.Text = "Enter FetchXml below: ";
            this.labelExecFetchBoundList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonExecFetchBoundList
            // 
            this.buttonExecFetchBoundList.AutoSize = true;
            this.buttonExecFetchBoundList.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonExecFetchBoundList.Location = new System.Drawing.Point(137, 2);
            this.buttonExecFetchBoundList.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExecFetchBoundList.Name = "buttonExecFetchBoundList";
            this.buttonExecFetchBoundList.Size = new System.Drawing.Size(123, 23);
            this.buttonExecFetchBoundList.TabIndex = 4;
            this.buttonExecFetchBoundList.Text = "Execute Fetch";
            this.buttonExecFetchBoundList.UseVisualStyleBackColor = true;
            this.buttonExecFetchBoundList.Click += new System.EventHandler(this.buttonExecFetchBoundList_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.panel9, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.propGridBoundListView, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(598, 560);
            this.tableLayoutPanel4.TabIndex = 20;
            // 
            // panel9
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.panel9, 2);
            this.panel9.Controls.Add(this.radioBoundListShowProps);
            this.panel9.Controls.Add(this.label19);
            this.panel9.Controls.Add(this.radioEntListShowObj);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(2, 506);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(594, 52);
            this.panel9.TabIndex = 16;
            // 
            // radioBoundListShowProps
            // 
            this.radioBoundListShowProps.AutoSize = true;
            this.radioBoundListShowProps.Checked = true;
            this.radioBoundListShowProps.Location = new System.Drawing.Point(10, 27);
            this.radioBoundListShowProps.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioBoundListShowProps.Name = "radioBoundListShowProps";
            this.radioBoundListShowProps.Size = new System.Drawing.Size(134, 17);
            this.radioBoundListShowProps.TabIndex = 3;
            this.radioBoundListShowProps.TabStop = true;
            this.radioBoundListShowProps.Text = "Bound ListView Control";
            this.radioBoundListShowProps.UseVisualStyleBackColor = true;
            this.radioBoundListShowProps.CheckedChanged += new System.EventHandler(this.RadioBoundListShowProps_CheckedChanged);
            // 
            // label19
            // 
            this.label19.Dock = System.Windows.Forms.DockStyle.Top;
            this.label19.Location = new System.Drawing.Point(0, 0);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(594, 23);
            this.label19.TabIndex = 4;
            this.label19.Text = "Choose what displays in the property control";
            // 
            // radioEntListShowObj
            // 
            this.radioEntListShowObj.AutoSize = true;
            this.radioEntListShowObj.Location = new System.Drawing.Point(150, 27);
            this.radioEntListShowObj.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioEntListShowObj.Name = "radioEntListShowObj";
            this.radioEntListShowObj.Size = new System.Drawing.Size(101, 17);
            this.radioEntListShowObj.TabIndex = 2;
            this.radioEntListShowObj.TabStop = true;
            this.radioEntListShowObj.Text = "Selected Object";
            this.radioEntListShowObj.UseVisualStyleBackColor = true;
            // 
            // propGridBoundListView
            // 
            this.propGridBoundListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propGridBoundListView.Location = new System.Drawing.Point(4, 3);
            this.propGridBoundListView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.propGridBoundListView.Name = "propGridBoundListView";
            this.propGridBoundListView.Size = new System.Drawing.Size(291, 498);
            this.propGridBoundListView.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(303, 3);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(291, 498);
            this.textBox1.TabIndex = 7;
            // 
            // tabPageCDSDataComboBox
            // 
            this.tabPageCDSDataComboBox.Controls.Add(this.tableLayoutPanel6);
            this.tabPageCDSDataComboBox.Location = new System.Drawing.Point(4, 34);
            this.tabPageCDSDataComboBox.Name = "tabPageCDSDataComboBox";
            this.tabPageCDSDataComboBox.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCDSDataComboBox.Size = new System.Drawing.Size(907, 564);
            this.tabPageCDSDataComboBox.TabIndex = 11;
            this.tabPageCDSDataComboBox.Text = "CDSDataComboBox";
            this.tabPageCDSDataComboBox.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.xmlViewerFetchCDSCombo, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.textBoxCDSComboProgress, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.panelCDSComboRetrieve, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(901, 558);
            this.tableLayoutPanel6.TabIndex = 11;
            // 
            // xmlViewerFetchCDSCombo
            // 
            this.xmlViewerFetchCDSCombo.AcceptsTab = false;
            this.xmlViewerFetchCDSCombo.AutoWordSelection = false;
            this.xmlViewerFetchCDSCombo.BackColor = System.Drawing.SystemColors.Window;
            this.xmlViewerFetchCDSCombo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xmlViewerFetchCDSCombo.BulletIndent = 0;
            this.xmlViewerFetchCDSCombo.DetectUrls = true;
            this.xmlViewerFetchCDSCombo.DisplayParseErrors = true;
            this.xmlViewerFetchCDSCombo.DisplayToolbar = false;
            this.xmlViewerFetchCDSCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xmlViewerFetchCDSCombo.EnableAutoDragDrop = false;
            this.xmlViewerFetchCDSCombo.FormatAsYouType = true;
            this.xmlViewerFetchCDSCombo.HideSelection = true;
            this.xmlViewerFetchCDSCombo.Location = new System.Drawing.Point(7, 40);
            this.xmlViewerFetchCDSCombo.Margin = new System.Windows.Forms.Padding(2);
            this.xmlViewerFetchCDSCombo.MaxLength = 2147483647;
            this.xmlViewerFetchCDSCombo.Multiline = true;
            this.xmlViewerFetchCDSCombo.Name = "xmlViewerFetchCDSCombo";
            this.xmlViewerFetchCDSCombo.ReadOnly = false;
            this.xmlViewerFetchCDSCombo.RightMargin = 0;
            this.xmlViewerFetchCDSCombo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
            xmlViewerSettings5.AttributeKey = System.Drawing.Color.Blue;
            xmlViewerSettings5.AttributeValue = System.Drawing.Color.DarkRed;
            xmlViewerSettings5.Comment = System.Drawing.Color.Gray;
            xmlViewerSettings5.Element = System.Drawing.Color.DarkGreen;
            xmlViewerSettings5.FontName = "Consolas";
            xmlViewerSettings5.FontSize = 9F;
            xmlViewerSettings5.QuoteCharacter = '\"';
            xmlViewerSettings5.Tag = System.Drawing.Color.ForestGreen;
            xmlViewerSettings5.Value = System.Drawing.Color.Black;
            this.xmlViewerFetchCDSCombo.Settings = xmlViewerSettings5;
            this.xmlViewerFetchCDSCombo.ShortcutsEnabled = true;
            this.xmlViewerFetchCDSCombo.ShowSelectionMargin = false;
            this.xmlViewerFetchCDSCombo.Size = new System.Drawing.Size(441, 511);
            this.xmlViewerFetchCDSCombo.TabIndex = 10;
            this.xmlViewerFetchCDSCombo.WordWrap = true;
            this.xmlViewerFetchCDSCombo.ZoomFactor = 1F;
            // 
            // textBoxCDSComboProgress
            // 
            this.textBoxCDSComboProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCDSComboProgress.Location = new System.Drawing.Point(454, 8);
            this.textBoxCDSComboProgress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxCDSComboProgress.Multiline = true;
            this.textBoxCDSComboProgress.Name = "textBoxCDSComboProgress";
            this.textBoxCDSComboProgress.ReadOnly = true;
            this.tableLayoutPanel6.SetRowSpan(this.textBoxCDSComboProgress, 2);
            this.textBoxCDSComboProgress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCDSComboProgress.Size = new System.Drawing.Size(438, 542);
            this.textBoxCDSComboProgress.TabIndex = 8;
            // 
            // panelCDSComboRetrieve
            // 
            this.panelCDSComboRetrieve.Controls.Add(this.cdsDataComboRetrieve);
            this.panelCDSComboRetrieve.Controls.Add(this.buttonCDSComboRetrieve);
            this.panelCDSComboRetrieve.Location = new System.Drawing.Point(7, 7);
            this.panelCDSComboRetrieve.Margin = new System.Windows.Forms.Padding(2);
            this.panelCDSComboRetrieve.Name = "panelCDSComboRetrieve";
            this.panelCDSComboRetrieve.Size = new System.Drawing.Size(441, 29);
            this.panelCDSComboRetrieve.TabIndex = 12;
            // 
            // cdsDataComboRetrieve
            // 
            this.cdsDataComboRetrieve.DisplayFormat = "";
            this.cdsDataComboRetrieve.FormattingEnabled = true;
            this.cdsDataComboRetrieve.Location = new System.Drawing.Point(3, 3);
            this.cdsDataComboRetrieve.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.cdsDataComboRetrieve.Name = "cdsDataComboRetrieve";
            this.cdsDataComboRetrieve.Size = new System.Drawing.Size(356, 21);
            this.cdsDataComboRetrieve.TabIndex = 0;
            // 
            // buttonCDSComboRetrieve
            // 
            this.buttonCDSComboRetrieve.Location = new System.Drawing.Point(368, 2);
            this.buttonCDSComboRetrieve.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCDSComboRetrieve.Name = "buttonCDSComboRetrieve";
            this.buttonCDSComboRetrieve.Size = new System.Drawing.Size(70, 21);
            this.buttonCDSComboRetrieve.TabIndex = 10;
            this.buttonCDSComboRetrieve.Text = "Retireve!";
            this.buttonCDSComboRetrieve.UseVisualStyleBackColor = true;
            this.buttonCDSComboRetrieve.Click += new System.EventHandler(this.buttonCDSComboRetrieve_Click);
            // 
            // ControlTesterPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ControlTesterPluginControl";
            this.Size = new System.Drawing.Size(915, 627);
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
            this.tabPageEntListViewBase.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanelToolbar.ResumeLayout(false);
            this.flowLayoutPanelToolbar.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
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
            this.panelAttrDropdown.ResumeLayout(false);
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
            this.tabPageCRMGridView.ResumeLayout(false);
            this.splitterCRMGridView.Panel1.ResumeLayout(false);
            this.splitterCRMGridView.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitterCRMGridView)).EndInit();
            this.splitterCRMGridView.ResumeLayout(false);
            this.tableCRMGridView.ResumeLayout(false);
            this.panelCrmGridViewControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CrmGridView)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CrmGridViewDesignedCols)).EndInit();
            this.tabPageXrmViewer.ResumeLayout(false);
            this.TableXmlViewers.ResumeLayout(false);
            this.TableXmlViewers.PerformLayout();
            this.splitterXmlViewerControl.Panel1.ResumeLayout(false);
            this.splitterXmlViewerControl.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitterXmlViewerControl)).EndInit();
            this.splitterXmlViewerControl.ResumeLayout(false);
            this.splitterXmlViewer.Panel1.ResumeLayout(false);
            this.splitterXmlViewer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitterXmlViewer)).EndInit();
            this.splitterXmlViewer.ResumeLayout(false);
            this.tabPageBoundListIVew.ResumeLayout(false);
            this.splitterBoundListView.Panel1.ResumeLayout(false);
            this.splitterBoundListView.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitterBoundListView)).EndInit();
            this.splitterBoundListView.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.tabPageCDSDataComboBox.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.panelCDSComboRetrieve.ResumeLayout(false);
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
        private xrmtb.XrmToolBox.Controls.EntitiesListControl EntityListControl;
        private System.Windows.Forms.TableLayoutPanel tableEntListDetails;
        private System.Windows.Forms.PropertyGrid propGridEntList;
        private System.Windows.Forms.RadioButton radioEntListShowProps;
        private System.Windows.Forms.RadioButton radioEntListShowEnt;
        private System.Windows.Forms.TextBox textEntListLog;
        private System.Windows.Forms.TableLayoutPanel tableEntDropdown;
        private xrmtb.XrmToolBox.Controls.EntitiesDropdownControl EntityDropdown;
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
        private System.Windows.Forms.Label labelAttributes;
        private xrmtb.XrmToolBox.Controls.EntitiesDropdownControl EntityDropdownAttribs;
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
        private xrmtb.XrmToolBox.Controls.SolutionsDropdownControl SolutionDropdown;
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
        private xrmtb.XrmToolBox.Controls.EntitiesDropdownControl EntityDropdownAttribList;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel tableAttribListDetail;
        private System.Windows.Forms.PropertyGrid propGridAttrList;
        private System.Windows.Forms.TextBox textAttribListLog;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton radioAttribListShowProps;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton radioAttribListShowAttrib;
        private xrmtb.XrmToolBox.Controls.AttributeListControl AttribListControl;
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
        private xrmtb.XrmToolBox.Controls.EntitiesDropdownControl EntityDropdownViews;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox listBoxViews;
        private System.Windows.Forms.Label label15;
        private xrmtb.XrmToolBox.Controls.ViewsDropdownControl ViewDropdown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PropertyGrid propGridViewDropdown;
        private System.Windows.Forms.TextBox textViewsDropdownLog;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton radioViewDropdownShowProps;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton radioAttribDropdownShowView;
        private System.Windows.Forms.TabPage tabPageGlobalOptSets;
        private System.Windows.Forms.SplitContainer splitterGlobalOptsList;
        private xrmtb.XrmToolBox.Controls.GlobalOptionSetListControl GlobalOptionSetList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RadioButton radioGlobalOptsListShowProps;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton radioEntDropdownShowOptionSet;
        private System.Windows.Forms.PropertyGrid propGridGlobalOptsList;
        private System.Windows.Forms.TextBox textGlobalOptsListLog;
        private System.Windows.Forms.TabPage tabPageCRMGridView;
        private System.Windows.Forms.SplitContainer splitterCRMGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.RadioButton radioCRMGridViewShowProps;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RadioButton radioCRMGridViewSelEntity;
        private System.Windows.Forms.PropertyGrid propCRMGridView;
        private System.Windows.Forms.TableLayoutPanel tableCRMGridView;
        private System.Windows.Forms.Label labelExecFetch;
        private xrmtb.XrmToolBox.Controls.CRMGridView CrmGridView;
        private System.Windows.Forms.TabPage tabPageXrmViewer;
        private xrmtb.XrmToolBox.Controls.XmlViewerControl XmlViewerControl;
        private System.Windows.Forms.SplitContainer splitterXmlViewerControl;
        private System.Windows.Forms.PropertyGrid propGridXmlViewerControl;
        private System.Windows.Forms.TableLayoutPanel TableXmlViewers;
        private System.Windows.Forms.SplitContainer splitterXmlViewer;
        private xrmtb.XrmToolBox.Controls.XMLViewer XmlViewer;
        private System.Windows.Forms.PropertyGrid propGridXmlViewer;
        private System.Windows.Forms.Label labelXmlViewerControlTitle;
        private System.Windows.Forms.Label labelXmlViewerTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonExecFetch;
        private xrmtb.XrmToolBox.Controls.XMLViewer XmlViewerCRMDataGrid;
        private Subro.Controls.DataGridViewGrouperControl dataGridViewGrouperControl1;
        private System.Windows.Forms.Panel panelCrmGridViewControls;
        private System.Windows.Forms.TabPage tabPageBoundListIVew;
        private System.Windows.Forms.SplitContainer splitterBoundListView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.RadioButton radioBoundListShowProps;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RadioButton radioEntListShowObj;
        private System.Windows.Forms.PropertyGrid propGridBoundListView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPageEntListViewBase;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private xrmtb.XrmToolBox.Controls.EntityListViewBaseControl EntityListViewBase;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.RadioButton radioEntLVBaseShowProps;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.PropertyGrid propGridEntLVBase;
        private System.Windows.Forms.TextBox textBox2;
        protected System.Windows.Forms.FlowLayoutPanel flowLayoutPanelToolbar;
        protected System.Windows.Forms.Button buttonLoadItems;
        protected System.Windows.Forms.CheckBox checkBoxCheckAllNone;
        protected System.Windows.Forms.Label labelFilter;
        protected System.Windows.Forms.TextBox textFilterList;
        protected System.Windows.Forms.Button buttonClearFilter;
        private xrmtb.XrmToolBox.Controls.EntitiesCollectionListView listViewEntCollection;
        private System.Windows.Forms.Panel panelAttrDropdown;
        private xrmtb.XrmToolBox.Controls.AttributeDropdownBaseControl AttributeDropdownBase;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textCdsDataComboBoxFormat;
        private System.Windows.Forms.Label label21;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataComboBox cdsDataComboBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label labelExecFetchBoundList;
        private System.Windows.Forms.Button buttonExecFetchBoundList;
        private xrmtb.XrmToolBox.Controls.XMLViewer xmlViewerEntColl;
        private System.Windows.Forms.Splitter splitterEntList;
        private System.Windows.Forms.TabPage tabPageCDSDataComboBox;
        private System.Windows.Forms.TextBox textBoxCDSComboProgress;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataComboBox cdsDataComboRetrieve;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private xrmtb.XrmToolBox.Controls.XmlViewerControl xmlViewerFetchCDSCombo;
        private System.Windows.Forms.Button buttonCDSComboRetrieve;
        private System.Windows.Forms.FlowLayoutPanel panelCDSComboRetrieve;
        private System.Windows.Forms.Panel panel11;
        private xrmtb.XrmToolBox.Controls.CRMGridView CrmGridViewDesignedCols;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn revenue;
        private System.Windows.Forms.Button buttonExecPredefinedCrmGridViewQuery;
        private System.Windows.Forms.RadioButton radioCRMGridViewRightShowProps;
    }
}