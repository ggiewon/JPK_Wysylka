using System.ComponentModel;
using System.Windows;
using JPK_WysylkaXML.EditXML.Interfaces.Views;
using JPK_WysylkaXML.EditXML.ViewModels.JPK_V7M.v1_2E;

namespace JPK_WysylkaXML.EditXML.Views.JPK_V7M.v1_2E
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

            Loaded += OnLoaded;

            SaleGrid.Loaded += SaleGridOnLoaded;

            PurchaseGrid.Loaded += PurchaseGridOnLoaded;

            Closing += OnClosing;
        }

        private void OnClosing(object sender, CancelEventArgs e)
        {
            var dataContext = DataContext as JpkV7MEditViewModel;

            dataContext?.SaveGrids();
        }

        private void SaleGridOnLoaded(object sender, RoutedEventArgs e)
        {
            if (DataContext is JpkV7MEditViewModel dataContext)
            {
                dataContext.UpdateSaleGrid();
            }
        }

        private void PurchaseGridOnLoaded(object sender, RoutedEventArgs e)
        {
            if (DataContext is JpkV7MEditViewModel dataContext)
            {
                dataContext.UpdatePurchaseGrid();
            }
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            if (DataContext is JpkV7MEditViewModel dataContext)
            {
                dataContext.SaleGrid = SaleGrid;
                dataContext.PurchaseGrid = PurchaseGrid;
            }
        }

        public Window GetOwnerWindow()
        {
            return GetWindow(this);
        }
    }
}