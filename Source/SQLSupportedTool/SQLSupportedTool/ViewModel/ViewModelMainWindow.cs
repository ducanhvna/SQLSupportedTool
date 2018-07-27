using CommonNS.CommonStructure;
using CommonNS.ViewModel;
using PluginManagermentNS;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLSupportedTool.ViewModel
{
    class ViewModelMainWindow : ViewModelBase
    {
        
        private ObservableCollection<IObjectContainers> m_ListObjectContainers;
        private ICollection<IPlugin> m_listPlugins;

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public ViewModelMainWindow()
        {
            // Create List Plugin
            CreateListPlugin();
        }

        private void CreateListPlugin()
        {
            // List Plugins
            m_listPlugins = PluginManagement.LoadPlugins("plugin");

            var dumyItem1 =   PluginManagement.CreatePlugin("Human Resource Managerment");
            var dumyItem2 = PluginManagement.CreatePlugin("Human Resource Managerment");
            var dumyItem3 = PluginManagement.CreatePlugin("Human Resource Managerment");

            ListObjectContainers = new ObservableCollection<IObjectContainers>();
            ListObjectContainers.Add(dumyItem1);
            ListObjectContainers.Add(dumyItem2);
            ListObjectContainers.Add(dumyItem3);
            RaisePropertyChanged("ListObjectContainers");

        }

        #endregion
        public ObservableCollection<IObjectContainers> ListObjectContainers {
            get
            {
                return m_ListObjectContainers;
            }
            set
            {
                if(m_ListObjectContainers != value)
                {
                    m_ListObjectContainers = value;
                    RaisePropertyChanged("ListObjectContainers");
                }
            }
        }
    }
}
