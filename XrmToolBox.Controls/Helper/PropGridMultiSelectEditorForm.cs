using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xrmtb.XrmToolBox.Controls
{
    public partial class PropGridMultiSelectEditorForm : Form
    {
        public PropGridMultiSelectEditorForm()
        {
            InitializeComponent();
        }
        public PropGridMultiSelectEditorForm(List<ListDisplayItem> boundItems):base() {

            // bind the list view to the list of items
            ListViewMain.Items.Clear();
            ListViewMain.Items.AddRange(boundItems.ToArray<ListDisplayItem>());

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
