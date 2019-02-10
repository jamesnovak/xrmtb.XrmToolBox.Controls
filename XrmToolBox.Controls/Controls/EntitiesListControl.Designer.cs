namespace xrmtb.XrmToolBox.Controls
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
            this.solutionsDropdown = new xrmtb.XrmToolBox.Controls.SolutionsDropdownControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerToolbar)).BeginInit();
            this.splitContainerToolbar.Panel2.SuspendLayout();
            this.splitContainerToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListViewMain
            // 
            this.ListViewMain.Margin = new System.Windows.Forms.Padding(12);
            this.ListViewMain.Size = new System.Drawing.Size(1680, 1032);
            // 
            // colDisplayName
            // 
            this.colDisplayName.DisplayIndex = 0;
            // 
            // colName
            // 
            this.colName.DisplayIndex = 1;
            // 
            // colSchemaName
            // 
            this.colSchemaName.DisplayIndex = 2;
            // 
            // colState
            // 
            this.colState.DisplayIndex = 3;
            // 
            // colDescription
            // 
            this.colDescription.DisplayIndex = 4;
            // 
            // splitContainerToolbar
            // 
            this.splitContainerToolbar.Margin = new System.Windows.Forms.Padding(12);
            // 
            // splitContainerToolbar.Panel2
            // 
            this.splitContainerToolbar.Panel2.Controls.Add(this.solutionsDropdown);
            this.splitContainerToolbar.Size = new System.Drawing.Size(1680, 58);
            this.splitContainerToolbar.SplitterDistance = 1094;
            this.splitContainerToolbar.SplitterWidth = 20;
            // 
            // solutionsDropdown
            // 
            this.solutionsDropdown.AutoLoadData = true;
            this.solutionsDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.solutionsDropdown.LanguageCode = 1033;
            this.solutionsDropdown.Location = new System.Drawing.Point(0, 0);
            this.solutionsDropdown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.solutionsDropdown.Name = "solutionsDropdown";
            this.solutionsDropdown.Service = null;
            this.solutionsDropdown.Size = new System.Drawing.Size(566, 58);
            this.solutionsDropdown.TabIndex = 1;
            // 
            // EntitiesListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ListViewColDefs = new xrmtb.XrmToolBox.Controls.ListViewColumnDef[0];
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EntitiesListControl";
            this.Size = new System.Drawing.Size(1680, 1090);
            this.splitContainerToolbar.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerToolbar)).EndInit();
            this.splitContainerToolbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SolutionsDropdownControl solutionsDropdown;
    }
}
