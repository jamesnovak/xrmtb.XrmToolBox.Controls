using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Reflection;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace Sample.XrmToolBox.TestPlugin
{
    // Do not forget to update version number and author (company attribute) in AssemblyInfo.cs class
    // To generate Base64 string for Images below, you can use https://www.base64-image.de/
    [Export(typeof(IXrmToolBoxPlugin)),
        ExportMetadata("Name", "XrmToolbox Control Tester Plugin"),
        ExportMetadata("Description", "Container plugin for testing shared controls"),
        ExportMetadata("SmallImageBase64", "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAABHNCSVQICAgIfAhkiAAAAAlwSFlzAAACAQAAAgEBrDkxBwAAABl0RVh0U29mdHdhcmUAd3d3Lmlua3NjYXBlLm9yZ5vuPBoAAAbOSURBVFiFtZdrTFTpGcd/75lRBwGBkcsAw2UARVBgttYiICI2Zld3s7EqjdcmbWLWD01XbbWmyW6n6zZNtNGkl2hMNv1Q2bohWpNK3XXTBSoLrtoVi4uucpPbMM4wM8DADDhz3n5gICCuzKr9J+fLc/0/73POeZ9HECLiKiwRujHlDSkpF0gzCBMQHVS7QXYAt5DU+MJktb3K4gklrpjLwPimJUtRNYelkLuAhQAaRQTi9ZEOY0K0E6DH5tbbncOL/arUBt1GJFQKjTjWffGdtuciYKw4EaZ4PRYpOADMy0he3L1vS1H7xqIcfVSEbjmgPOESGPT4Wi433nWevtCY0d47kAKMS+RJ7bC0dNZafCETSNl8NJMAF0DmJ8VHWc8cqbifn5W4BtA8q5ppUFu7HV/+5P1zxk6rywDcRiO2Pu00ZhFI3mQxKxrlYyDh4I619ft3lK0EwkJM/CS8v6+s/fIPH10tAWyq5NXeS+/e/kYCE5XLzzWKiK18b3d9cX562XMmnoH6po66PZbKNQFVOtCIkuknMUUgfZ1Fpy7SNEopzefe31OXY0oo+/SLrwFYHBXO91ctmRG0pcPGnTYrACsyE8k1JczQ/+vGAwYGRwDYUJjNnbb+ul3vni0DmqUuorCn6qAXpr1I6iLxnpTS/LMfll4tzk8v67G5GX8coHBFGg3NnbOquvLF16xcZmTlMiNXgkSno6G5k8IVaYw/DtBjc1NqNpX9fOe6RiBP8Xosk3YKgPGNo0ukFPuT4qOsv9i9buWkMjY6nDRDDLr52lkJAFINMaQaYp6q083XkmaIITY6fEr29vZSc0pCtFUK9hvftGRNEVDgEDDvg19VtBP81v9PCDt1ZFsbMF9RNYcBtHEVlgjpkzuzkmO7lmckrnYNe/nLP67jGvYy6hunpcPGvc5HnPiwjlRDNNvWF7wQg/zMxCJTkr6ro8+5M67CclCr84rXEYTv21p0E0h1Do2SZojh7e1rZzmf+LD2hZIHodn3g+L2X/75UmqYT9mkSCHWA2wsytFPWnjHHjM84pv1+APqyyDAxuJsPYBErtcKpFmjKIHI8AW5ALFR4XjHHnPqfAMe7xjpiXpu3O1mVU4KBVlJcwa/22lj0OOj1z7ItTsPud9lxzk0yohvHPPSZHTztURHLszVKCIQUGWBFkRGwuJFDiABICpCx97Nq2lutdJrH+S1omW4PV72bl4dUnV/++QWGwqXsmVdHo/9AczZyQig5j+txMVEkJm8GEAbFxNpsw4MZWiBKGN8VOskgRdFZPgCSs0Zs+R218zbOcUQ7ewPEpDyZWQOImzBPI6freGh1UVaYgwDgyMsmKcloEqK801TdlJKAaAFhnpsbv03Bfy2+GnFGgCOn63h0O5yPm68R3JcFHlZiTPsemyD0RIGtSDbHzmHVwIBQrhu23oc3G610tY7wMW6OxOy3gEu1DZTkJVIpjE2FJ5+u2s4TiBvaIFbAVV+b9Dja46K0OXN5fnZzVa+m5tCQVbplOw72ckMjY7x2c3WkAi4Pd6vAqosQIgmBUkNwOXGu85QqAOYEvVkGmNnPKbE0LtYXd/iAhCSGq0vTFbrfGLk9IXGjO0bXpmzDbmmBM5cvEZbr2Pyk6Ktd4DM5FhK8tNDye8/c/FaJjDi1an/VOxVFo+EyvbegZTmdmvDXN4lBSYO7yknJz2BAzvKOLCjjJz0BA7vKaekwDSXO00P+ho6+pwpEirtVRaPAiA04hgwvve3VUsAbyhlPCdG3/pd1VJgPJhz4jruvvhOm0Se7LMPGo6frb05ae1wj/Cw34Vv3P/UaF39Lrr6XU/V+cb9POx34XCPTMlOnvt3k9UxZJBwYnIsm+p3fOaWq37F9/r1r7oKV+Wk1mWlxKY/tDrpfTRIdmo8GcF+T2JRuI7bD/qwOoYoyksnLiZiht7vV3nQbUejUXgl28iNlq66w3+8VAo0o4vYM9TyiR+eMZT+1bKrfo3Z9FKG0qtNHbU/slSWBlRpF6pa0lVtaZ/UzXjjh+7VuCKXln8KbD1f89/lqqS+OC89Fpj3nLlHj52tuX7kT5fWSskjVfJaT/Wv7003eMZiIs8DBUlxUf2nj2y7b16SVMzErzsUqC0dtus/Pnou3eoYMgghmggEtk6v/JkEYGJM90cKi0AcAOabkvTdb20uat9UsiwmOnJh7lPI+N0eb8vlz+85T/29IbOzzxlczTihHVZ/861Ws+mYtpzuBMIBFCHUeH2kPcUwsZx297v1j5zDsaqUky198eX0ScRVWCKC82M5CLMEkwiu5xLcAjoQ3BKSmrGxsGrblUMjc8UE+B8MvtySxhT5HQAAAABJRU5ErkJggg=="),
        ExportMetadata("BigImageBase64", "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"),
        ExportMetadata("BackgroundColor", "Lavender"),
        ExportMetadata("PrimaryFontColor", "Black"),
        ExportMetadata("SecondaryFontColor", "Gray")]
    public class ControlTesterPlugin : PluginBase
    {
        public ControlTesterPlugin() {

            // hook into the event that will fire when an Assembly fails to resolve
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(AssemblyResolveEventHandler);
        }

        /// <summary>
        /// This handler is called only when the CLR tries to bind to the assembly and fails.
        /// If the argument includes an assembly that we don't want to load, return a null and the CLR will load it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args">Argument containing the details of the assembly that failed to resolve.</param>
        /// <returns></returns>
        private Assembly AssemblyResolveEventHandler(object sender, ResolveEventArgs args)
        {
            Assembly loadAssembly = null;
            Assembly currAssembly = Assembly.GetExecutingAssembly();
            
            // base name of the assembly that failed to resolve
            var argName = args.Name.Substring(0, args.Name.IndexOf(","));

            // check to see if the failing assembly is one that we reference.
            List<AssemblyName> refAssemblies = currAssembly.GetReferencedAssemblies().ToList();
            var refAssembly = refAssemblies.Where(a => a.Name == argName).FirstOrDefault();

            // if the current unresolved assembly is referenced by our plugin, attempt to load
            if (refAssembly != null)
            {
                // load from the path to this plugin assembly, not host executable
                string dir = Path.GetDirectoryName(currAssembly.Location).ToLower();
                string folder = Path.GetFileNameWithoutExtension(currAssembly.Location);
                dir = Path.Combine(dir, folder);

                var assmbPath = Path.Combine(dir, $"{argName}.dll");

                if (File.Exists(assmbPath))
                {
                    loadAssembly = Assembly.LoadFrom(assmbPath);
                }
                else {
                    throw new FileNotFoundException($"Unable to locate dependency: {assmbPath}");
                }
            }

            return loadAssembly;
        }

        public override IXrmToolBoxPluginControl GetControl()
        {
            return new ControlTesterPluginControl();
        }

    }
}