using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginManagermentNS
{
    /// <summary>
    /// Plugin Interface
    /// </summary>
    public interface IPlugin
    {
        /// <summary>
        /// Name of Plugin
        /// </summary>
        string Name { get; }

        void Do();

    }
}
