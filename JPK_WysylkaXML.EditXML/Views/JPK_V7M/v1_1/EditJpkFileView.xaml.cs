using System.Windows;
using JPK_WysylkaXML.EditXML.Interfaces.Views;
using JPK_WysylkaXML.EditXML.ViewModels.JPK_V7M.v1_1;

namespace JPK_WysylkaXML.EditXML.Views.JPK_V7M.v1_1
{
    /// <summary>
    /// Description for ConfigurationView.
    /// </summary>
    public partial class EditJpkFileView : IEditJpkFileView
    {
        /// <summary>
        /// Initializes a new instance of the ConfigurationView class.
        /// </summary>
        public EditJpkFileView()
        {
            InitializeComponent();
        }

        public Window GetOwnerWindow()
        {
            return GetWindow(this);
        }
    }
}