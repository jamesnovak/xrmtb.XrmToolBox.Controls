using System;
using System.IO;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;
using System.Threading;

namespace XrmToolBox.Controls
{
    internal class Utility
    {
        /// <summary>
        /// Get the folder for the currenty loaded Assemblu
        /// </summary>
        /// <returns></returns>
        public static string GetAssemblyFolder() {
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;

            UriBuilder uri = new UriBuilder(codeBase);

            string path = Uri.UnescapeDataString(uri.Path).ToLower();

            var pathParts = path.Split('/');
            // make it a little more readable than ALL CAPS IN YOUR FACE
            for (var i=0; i < pathParts.Length; i++) {
                pathParts[i] = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(pathParts[i]);
            }
            path = string.Join("/", pathParts);
            return Path.GetDirectoryName(path);
        }

        /// <summary>
        /// Create a settings folder for this plugin using the Assembly Name 
        /// </summary>
        /// <returns></returns>
        public static string GetToolSettingsFolder() {
            var path = Path.Combine(GetAssemblyFolder(), Assembly.GetExecutingAssembly().GetName().Name);

            if (!Directory.Exists(path)) {
                Directory.CreateDirectory(path);
            }
            
            return path;
        }
    }

    /// <summary>
    /// ListView Item Compare taken from XrmToolBox: 
    /// https://github.com/MscrmTools/XrmToolBox/blob/master/Plugins/MsCrmTools.MetadataDocumentGenerator/Helper/ListViewItemComparer.cs
    /// </summary>
    internal class ListViewItemComparer : IComparer
    {
        private readonly int col;

        private readonly SortOrder innerOrder;

        public ListViewItemComparer()
        {
            this.col = 0;
            this.innerOrder = SortOrder.Ascending;
        }

        public ListViewItemComparer(int column, SortOrder order)
        {
            this.col = column;
            this.innerOrder = order;
        }

        public int Compare(object x, object y)
        {
            return this.Compare((ListViewItem)x, (ListViewItem)y);
        }

        public int Compare(ListViewItem x, ListViewItem y)
        {
            if (this.innerOrder == SortOrder.Ascending)
            {
                return string.Compare(x.SubItems[this.col].Text, y.SubItems[this.col].Text);
            }
            return string.Compare(y.SubItems[this.col].Text, x.SubItems[this.col].Text);
        }
    }
}
