namespace xrmtb.XrmToolBox.Controls
{
    partial class SolutionsDropdownControl
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
            this.buttonReload = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.comboSolutions = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonReload
            // 
            this.buttonReload.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReload.Font = new System.Drawing.Font("Wingdings 3", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonReload.Location = new System.Drawing.Point(396, 3);
            this.buttonReload.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonReload.MinimumSize = new System.Drawing.Size(19, 19);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(19, 19);
            this.buttonReload.TabIndex = 1;
            this.buttonReload.Text = "P";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.ButtonReload_Click);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanelMain.Controls.Add(this.buttonReload, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.comboSolutions, 0, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(416, 25);
            this.tableLayoutPanelMain.TabIndex = 4;
            // 
            // comboSolutions
            // 
            this.comboSolutions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboSolutions.FormattingEnabled = true;
            this.comboSolutions.IntegralHeight = false;
            this.comboSolutions.ItemHeight = 13;
            this.comboSolutions.Location = new System.Drawing.Point(4, 3);
            this.comboSolutions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboSolutions.Name = "comboSolutions";
            this.comboSolutions.Size = new System.Drawing.Size(384, 21);
            this.comboSolutions.TabIndex = 0;
            this.comboSolutions.SelectedIndexChanged += new System.EventHandler(this.ComboSolutions_SelectedIndexChanged);
            // 
            // SolutionsDropdownControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "SolutionsDropdownControl";
            this.Size = new System.Drawing.Size(416, 25);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.ComboBox comboSolutions;
    }
}
