namespace xrmtb.XrmToolBox.Controls
{
    partial class ViewsDropdownControl
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
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.buttonReload = new System.Windows.Forms.Button();
            this.ComboViews = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanelMain.Controls.Add(this.buttonReload, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.ComboViews, 0, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(800, 48);
            this.tableLayoutPanelMain.TabIndex = 4;
            // 
            // buttonReload
            // 
            this.buttonReload.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReload.Font = new System.Drawing.Font("Wingdings 3", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonReload.Location = new System.Drawing.Point(758, 6);
            this.buttonReload.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonReload.MinimumSize = new System.Drawing.Size(38, 36);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(38, 36);
            this.buttonReload.TabIndex = 1;
            this.buttonReload.Text = "P";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.ButtonReload_Click);
            // 
            // ComboViews
            // 
            this.ComboViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboViews.FormattingEnabled = true;
            this.ComboViews.IntegralHeight = false;
            this.ComboViews.ItemHeight = 25;
            this.ComboViews.Location = new System.Drawing.Point(7, 6);
            this.ComboViews.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ComboViews.Name = "ComboViews";
            this.ComboViews.Size = new System.Drawing.Size(737, 33);
            this.ComboViews.TabIndex = 0;
            this.ComboViews.SelectedIndexChanged += new System.EventHandler(this.ComboViews_SelectedIndexChanged);
            // 
            // ViewsDropdownControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "ViewsDropdownControl";
            this.Size = new System.Drawing.Size(800, 48);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.ComboBox ComboViews;
    }
}
