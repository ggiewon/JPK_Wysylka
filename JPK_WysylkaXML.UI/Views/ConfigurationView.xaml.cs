using System.Windows;
using JPK_WysylkaXML.UI.Interfaces.Views;

namespace JPK_WysylkaXML.UI.Views
{
    /// <summary>
    /// Description for ConfigurationView.
    /// </summary>
    public partial class ConfigurationView : IConfigurationView
    {
        /// <summary>
        /// Initializes a new instance of the ConfigurationView class.
        /// </summary>
        public ConfigurationView()
        {
            InitializeComponent();
        }

        public Window GetOwnerWindow()
        {
            return GetWindow(this);
        }
    }
}