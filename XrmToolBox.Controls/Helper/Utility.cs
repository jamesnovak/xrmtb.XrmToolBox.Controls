using System;
using System.IO;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml;

namespace xrmtb.XrmToolBox.Controls
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
            for (var i = 0; i < pathParts.Length; i++) {
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

        /// <summary>
        /// Helper method to retrieve the Property Value from the reflected object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="p"></param>
        /// <param name="languageCode"></param>
        /// <returns></returns>
        public static T GetPropertyValue<T>(object data, PropertyInfo p, int languageCode = 1033)
        {
            T propValue = default(T);
            object dataValue = p.GetValue(data);

            if (dataValue != null)
            {
                if (dataValue is Guid)
                {
                    dataValue = ((Guid)dataValue).ToString("b");
                }
                else if (dataValue is AttributeTypeDisplayName)
                {
                    dataValue = ((AttributeTypeDisplayName)dataValue).Value;
                }
                else if (dataValue is BooleanManagedProperty)
                {
                    var boolean = (BooleanManagedProperty)dataValue;
                    dataValue = boolean.Value;

                }
                else if (dataValue is AttributeRequiredLevelManagedProperty)
                {
                    var reqLevel = (AttributeRequiredLevelManagedProperty)dataValue;
                    dataValue = reqLevel.Value;
                }
                else if (dataValue is AttributeTypeCode)
                {
                    var val = (AttributeTypeCode)dataValue;
                    dataValue = val.ToString();

                }
                else if (dataValue is String[])
                {
                    var val = (String[])dataValue;
                    if (val.Length > 0)
                    {
                        dataValue = val[0];
                    }
                }

                else if (dataValue is Microsoft.Xrm.Sdk.Label)
                {
                    var label = (Microsoft.Xrm.Sdk.Label)dataValue;
                    if (label.LocalizedLabels.Count > 0)
                    {
                        var localLabel = label.LocalizedLabels.Where(l => l.LanguageCode == languageCode).First();
                        if (localLabel != null)
                        {
                            dataValue = localLabel.Label;
                        }
                    }
                }
            }
            if (dataValue is IConvertible)
            {
                propValue = (T)Convert.ChangeType(dataValue, typeof(T));
            }

            return propValue;
        }

        /// <summary>
        /// Helper method to get the Type from the PropInfo
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Type GetPropertyType(PropertyInfo p)
        {
            Type propType = typeof(string);
            object t = Nullable.GetUnderlyingType(p.PropertyType) ?? p.PropertyType;

            if (t is BooleanManagedProperty)
            {
                propType = typeof(bool);
            }
            return propType;
        }

        /// <summary>
        /// Helper method to validate Xml as well formed 
        /// </summary>
        /// <param name="xmlString"></param>
        /// <returns></returns>
        public static bool IsValidXml(string xmlString)
        {
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(xmlString);
                return true;
            }
            catch (XmlException)
            {
                return false;
            }
        }
        /// <summary>
        /// Helper method to return the Type of a value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="showFriendlyNames"></param>
        /// <returns></returns>
        public static Type GetValueType(object value, bool showFriendlyNames)
        {
            if (value == null)
            {
                return typeof(string);
            }
            if (showFriendlyNames && !ValueTypeIsFriendly(value))
            {
                return typeof(string);
            }
            var basevalue = EntitySerializer.AttributeToBaseType(value);
            if (basevalue == null)
            {
                return typeof(string);
            }
            return basevalue.GetType();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        internal static bool ValueTypeIsFriendly(object value)
        {
            return value is Int32 || value is decimal || value is double || value is string || value is Money;
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
