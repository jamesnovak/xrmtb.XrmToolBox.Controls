namespace xrmtb.XrmToolBox.Controls
{
    partial class EntitiesDropdownControl
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
            if (disposing && (components != null)) {
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
            this.comboEntities = new System.Windows.Forms.ComboBox();
            this.buttonReload = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboEntities
            // 
            this.comboEntities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboEntities.FormattingEnabled = true;
            this.comboEntities.IntegralHeight = false;
            this.comboEntities.ItemHeight = 25;
            this.comboEntities.Location = new System.Drawing.Point(8, 6);
            this.comboEntities.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.comboEntities.Name = "comboEntities";
            this.comboEntities.Size = new System.Drawing.Size(684, 33);
            this.comboEntities.TabIndex = 0;
            this.comboEntities.SelectedIndexChanged += new System.EventHandler(this.ComboEntities_SelectedIndexChanged);
            // 
            // buttonReload
            // 
            this.buttonReload.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReload.Font = new System.Drawing.Font("Wingdings 3", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonReload.Location = new System.Drawing.Point(708, 6);
            this.buttonReload.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.buttonReload.MinimumSize = new System.Drawing.Size(38, 37);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(38, 37);
            this.buttonReload.TabIndex = 1;
            this.buttonReload.Text = "P";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.ButtonReload_Click);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanelMain.Controls.Add(this.buttonReload, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.comboEntities, 0, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(748, 48);
            this.tableLayoutPanelMain.TabIndex = 2;
            // 
            // EntitiesDropdownControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "EntitiesDropdownControl";
            this.Size = new System.Drawing.Size(748, 48);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboEntities;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
    }
}
