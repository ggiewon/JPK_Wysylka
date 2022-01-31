using System.Windows;
using JPK_WysylkaXML.EditXML.Interfaces.Views.JPK_V7M;

namespace JPK_WysylkaXML.EditXML.Views.JPK_V7M.v2_1E
{
    /// <summary>
    /// Description for ConfigurationView.
    /// </summary>
    public partial class EditJpkFilePurchaseDetailsView : IEditJpkFilePurchaseDetailsView
    {
        /// <summary>
        /// Initializes a new instance of the ConfigurationView class.
        /// </summary>
        public EditJpkFilePurchaseDetailsView()
        {
            InitializeComponent();
        }

        public Window GetOwnerWindow()
        {
            return GetWindow(this);
        }
    }
}