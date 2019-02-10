using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace xrmtb.XrmToolBox.Controls
{
    public class PropGridMultiSelectEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(ITypeDescriptorContext context, System.IServiceProvider provider, object value)
        {
            if (provider?.GetService(typeof(IWindowsFormsEditorService)) is IWindowsFormsEditorService svc)
            {
                var plugin = ((List<ListDisplayItem>)context?.Instance)?.Plugin;

                using (var form = new PropGridMultiSelectEditorForm((Webresource)context?.Instance, plugin))
                {
                    if (svc.ShowDialog(form) == DialogResult.OK)
                    {
                        var selectedValues = 
                        value = 
                    }
                }
            }
            return value; // can also replace the wrapper object here
        }
    }
}
