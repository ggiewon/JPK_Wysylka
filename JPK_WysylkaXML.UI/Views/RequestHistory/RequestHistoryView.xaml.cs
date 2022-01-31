#nullable enable
using System.Windows;
using JPK_WysylkaXML.UI.Interfaces.Views;
using JPK_WysylkaXML.UI.ViewModel.RequestHistory;
using Syncfusion.UI.Xaml.Grid;

namespace JPK_WysylkaXML.UI.Views.RequestHistory
{
    /// <summary>
    /// Description for RequestsView.
    /// </summary>
    public partial class RequestsView : IRequestsView
    {
        /// <summary>
        /// Initializes a new instance of the RequestsView class.
        /// </summary>
        public RequestsView()
        {
            InitializeComponent();
        }

        public Window GetOwnerWindow()
        {
            return GetWindow(this);
        }

        private void SfDataGrid_OnGridCopyContent(object? sender, GridCopyPasteEventArgs e)
        {
            if (DataContext is RequestHistoryViewModel dataContext && dataContext.SelectedItem != null)
            {
                Clipboard.SetText(dataContext.SelectedItem.ReferenceNo);
            }

            e.Handled = true;
        }
    }
}