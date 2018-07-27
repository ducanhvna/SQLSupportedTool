using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginManagermentNS
{
    /// <summary>
    /// Interface of Library
    /// </summary>
    public static class PluginManagement
    {
        private static Dictionary<string, IPlugin> _Plugins = null;
        public static ICollection<IPlugin> LoadPlugins(string path)
        {
            _Plugins = new Dictionary<string, IPlugin>();
            //ICollection<IPlugin> plugins = PluginLoader.LoadPlugins("Plugins");
            ICollection<IPlugin> plugins = PluginLoader.LoadPlugins(path);
            foreach (var item in plugins)
            {
                _Plugins.Add(item.Name, item);
            }
            return plugins;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Dictionary<string, IPlugin> Plugins
        {
            get
            {
                return _Plugins;
            }
        }
    }
}
