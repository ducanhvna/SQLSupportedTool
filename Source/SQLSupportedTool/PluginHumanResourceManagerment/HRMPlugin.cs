using LibCommon.CommonStructure;
using PluginManagermentNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceManagermentNS
{
    class HRMPlugin : IPlugin
    {
        public string Name => throw new NotImplementedException();

        public IObjectContainers CreateContainer(int key, string name)
        {
            return new HRMContainer(key,name);
        }
    }
}
