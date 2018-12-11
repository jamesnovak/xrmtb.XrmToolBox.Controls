using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XrmToolBox.Controls.Helper
{
    public class ListViewDisplayItem
    {
        public ListViewDisplayItem() {
            var dt = new DataTable;

            dt.Columns[9].
        }

        public List<Field> Fields { get; set; }

        /// <summary>
        /// Object being bound to the list
        /// </summary>
        public object Object { get; set; }


    }

    public class Field {
        public bool IsPrimary { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public string Group { get; set; }
        public int Order { get; set; }
    }
}
