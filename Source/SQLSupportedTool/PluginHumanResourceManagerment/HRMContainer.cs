using HumanResourceManagermentNS.View;
using CommonNS.CommonStructure;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HumanResourceManagermentNS
{
    /// <summary>
    /// Container
    /// </summary>
    class HRMContainer : IObjectContainers
    {
        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="key"></param>
        /// <param name="name"></param>
        public HRMContainer(int key, string name)
        {
            Key = key;
            Name = name;

            // Create views
            DiagramView = new HRMDiagramView();
            PropertiesView = new HRMPropertiesView();
            CommandView = new HRMCommandView();

            // Create sub items
            CreateSubItems();
        }

        /// <summary>
        /// CreateSubItems
        /// </summary>
        private void CreateSubItems()
        {
            SubItems = new ObservableCollection<IObjectContainers>();
        }

        #endregion
        /// <summary>
        /// Key
        /// </summary>
        public int Key { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// SubItems
        /// </summary>
        public ObservableCollection<IObjectContainers> SubItems { get; private set; }

        /// <summary>
        /// DiagramView
        /// </summary>
        public UserControl DiagramView { get; private set; }

        /// <summary>
        /// PropertiesView
        /// </summary>
        public UserControl PropertiesView { get; private set; }

        /// <summary>
        /// CommandView
        /// </summary>
        public UserControl CommandView { get; private set; }
    }
}
