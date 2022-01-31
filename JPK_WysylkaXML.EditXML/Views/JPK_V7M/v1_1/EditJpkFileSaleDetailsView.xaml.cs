using System.Windows;
using JPK_WysylkaXML.EditXML.Interfaces.Views.JPK_V7M;

namespace JPK_WysylkaXML.EditXML.Views.JPK_V7M.v1_1
{
    /// <summary>
    /// Description for ConfigurationView.
    /// </summary>
    public partial class EditJpkFileSaleDetailsView : IEditJpkFileSaleDetailsView
    {
        /// <summary>
        /// Initializes a new instance of the ConfigurationView class.
        /// </summary>
        public EditJpkFileSaleDetailsView()
        {
            InitializeComponent();
        }

        public Window GetOwnerWindow()
        {
            return GetWindow(this);
        }
    }
}