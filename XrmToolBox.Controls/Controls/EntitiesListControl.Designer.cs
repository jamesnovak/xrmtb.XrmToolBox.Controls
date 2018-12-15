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
            this.solutionsDropdown = new XrmToolBox.Controls.SolutionsDropdownControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerToolbar)).BeginInit();
            this.splitContainerToolbar.Panel2.SuspendLayout();
            this.splitContainerToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListViewMain
            // 
            this.ListViewMain.Size = new System.Drawing.Size(840, 537);
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
            // 
            // splitContainerToolbar.Panel2
            // 
            this.splitContainerToolbar.Panel2.Controls.Add(this.solutionsDropdown);
            this.splitContainerToolbar.Size = new System.Drawing.Size(840, 30);
            this.splitContainerToolbar.SplitterDistance = 466;
            this.splitContainerToolbar.SplitterWidth = 5;
            // 
            // solutionsDropdown
            // 
            this.solutionsDropdown.AutoLoadData = false;
            this.solutionsDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.solutionsDropdown.LanguageCode = 1033;
            this.solutionsDropdown.Location = new System.Drawing.Point(0, 0);
            this.solutionsDropdown.Margin = new System.Windows.Forms.Padding(1);
            this.solutionsDropdown.Name = "solutionsDropdown";
            this.solutionsDropdown.Service = null;
            this.solutionsDropdown.Size = new System.Drawing.Size(369, 30);
            this.solutionsDropdown.TabIndex = 1;
            // 
            // EntitiesListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ListViewColDefs = new XrmToolBox.Controls.ListViewColumnDef[0];
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "EntitiesListControl";
            this.Size = new System.Drawing.Size(840, 567);
            this.splitContainerToolbar.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerToolbar)).EndInit();
            this.splitContainerToolbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SolutionsDropdownControl solutionsDropdown;
    }
}
