using System.Collections.Generic;
using System.Linq;
using JPK_WysylkaXML.EditXML.Interfaces.JPK_V7M.v1_1;
using JPK_WysylkaXML.EditXML.Views.JPK_V7M.v1_1;
using JPK_WysylkaXML.EditXML.XmlTypes.Version3_v7m.v1_1;
using UnitSoftware.Common.Implementation.Commands;
using UnitSoftware.Common.Interfaces.Commands;
using UnitSoftware.Common.Interfaces.Views;

namespace JPK_WysylkaXML.EditXML.ViewModels.JPK_V7M.v1_1
{
    public class JpkV7MEditViewModel : BaseEditViewModel<XmlTypes.Version3_v7m.v1_1.JPK>, IJpkV7MEditViewModel
    {
        public IRefreshableCommand SaveCommand { get; }

        public IRefreshableCommand CancelCommand { get; }

        public IRefreshableCommand SaleDoubleClickCommand { get; }

        public IRefreshableCommand PurchaseDoubleClickCommand { get; }

        public IRefreshableCommand AddNewSaleRowCommand { get; }

        public IRefreshableCommand DeleteSaleRowCommand { get; }

        public IRefreshableCommand AddNewPurchaseRowCommand { get; }

        public IRefreshableCommand DeletePurchaseRowCommand { get; }

        public IBaseView View { get; set; }

        public IList<JPKSprzedazWiersz> SaleList
        {
            get => _saleList;
            private set
            {
                _saleList = value; 
                OnPropertyChanged();
            }
        }

        public JPKSprzedazWiersz SelectedSaleRow { get; set; }

        public IList<JPKZakupWiersz> PurchaseList
        {
            get => _purchaseList;
            private set
            {
                _purchaseList = value;
                OnPropertyChanged();
            }
        }

        public JPKZakupWiersz SelectedPurchaseRow { get; set; }

        public DeklaracjeViewModel Deklaracje { get; }

        private bool doneLoading;

        private IList<JPKSprzedazWiersz> _saleList;

        private IList<JPKZakupWiersz> _purchaseList;

      

        public JpkV7MEditViewModel(string filePath) : base(filePath)
        {
            CancelCommand = new DelegateCommand(CancelCommandExecute);
            SaveCommand = new DelegateCommand(SaveCommandExecute, SaveCommandCanExecute);
            SaleDoubleClickCommand = new DelegateCommand(DoubleClickCommandExecute);
            PurchaseDoubleClickCommand = new DelegateCommand(PurchaseDoubleClickCommandExecute);
            AddNewSaleRowCommand = new DelegateCommand(AddNewSaleCommandExecute);
            AddNewPurchaseRowCommand = new DelegateCommand(AddNewPurchaseRowCommandExecute);

            DeletePurchaseRowCommand = new DelegateCommand(DeletePurchaseRowCommandExecute, DeletePurchaseRowCanCommandExecute);
            DeleteSaleRowCommand = new DelegateCommand(DeleteSaleRowCommandExecute, DeleteSaleRowCanCommandExecute);

            SaleList = _jpkFile.SprzedazWiersz != null ? _jpkFile.SprzedazWiersz.ToList() : new List<JPKSprzedazWiersz>();

            PurchaseList = _jpkFile.ZakupWiersz != null ? _jpkFile.ZakupWiersz.ToList() : new List<JPKZakupWiersz>();

            Deklaracje = new DeklaracjeViewModel(_jpkFile.Deklaracja);

            doneLoading = true;
        }

        private void DeleteSaleRowCommandExecute(object obj)
        {
            var list = _jpkFile.SprzedazWiersz.ToList().Where(x => x != SelectedSaleRow);
            _jpkFile.SprzedazWiersz = list.ToArray();
            SaleList = _jpkFile.SprzedazWiersz.ToList();
        }

        private bool DeleteSaleRowCanCommandExecute(object obj)
        {
            return SelectedSaleRow != null;
        }

        private void DeletePurchaseRowCommandExecute(object obj)
        {
            var list = _jpkFile.ZakupWiersz.ToList().Where(x => x != SelectedPurchaseRow);
            _jpkFile.ZakupWiersz = list.ToArray();
            PurchaseList = _jpkFile.ZakupWiersz.ToList();
        }

        private bool DeletePurchaseRowCanCommandExecute(object obj)
        {
            return SelectedPurchaseRow != null;
        }

        private void AddNewPurchaseRowCommandExecute(object obj)
        {
            var row = new JPKZakupWiersz();

            var viewModel = new JpkV7MEditPurchaseDetailsViewModel(row);

            var view = new EditJpkFilePurchaseDetailsView { DataContext = viewModel, Owner = View.GetOwnerWindow()};

            viewModel.View = view;

            if (view.ShowDialog() ?? false)
            {
                var list = _jpkFile.ZakupWiersz != null ? _jpkFile.ZakupWiersz.ToList() : new List<JPKZakupWiersz>();
                
                list.Add(row);

                _jpkFile.ZakupWiersz = list.ToArray();

                PurchaseList = _jpkFile.ZakupWiersz.ToList();
            }
        }

        private void AddNewSaleCommandExecute(object obj)
        {
            var row = new JPKSprzedazWiersz();

            var viewModel = new JpkV7MEditSaleDetailsViewModel(row);

            var view = new EditJpkFileSaleDetailsView {DataContext = viewModel, Owner = View.GetOwnerWindow()};

            viewModel.View = view;

            if (view.ShowDialog() ?? false)
            {
                var list = _jpkFile.SprzedazWiersz != null ? _jpkFile.SprzedazWiersz.ToList() : new List<JPKSprzedazWiersz>();

                list.Add(row);

                _jpkFile.SprzedazWiersz = list.ToArray();

                SaleList = _jpkFile.SprzedazWiersz.ToList();
            }
        }

        private void PurchaseDoubleClickCommandExecute(object obj)
        {
            var viewModel = new JpkV7MEditPurchaseDetailsViewModel(SelectedPurchaseRow);

            var view = new EditJpkFilePurchaseDetailsView { DataContext = viewModel, Owner = View.GetOwnerWindow() };

            viewModel.View = view;

            view.ShowDialog();

            PurchaseList = _jpkFile.ZakupWiersz.ToList();
        }

        private void DoubleClickCommandExecute(object obj)
        {
            var viewModel = new JpkV7MEditSaleDetailsViewModel(SelectedSaleRow);

            var view = new EditJpkFileSaleDetailsView {DataContext = viewModel, Owner = View.GetOwnerWindow()};

            viewModel.View = view;

            view.ShowDialog();

            SaleList = _jpkFile.SprzedazWiersz.ToList();
        }

        private void CancelCommandExecute(object obj)
        {
            View.Close();
        }

        private void SaveCommandExecute(object obj)
        {
            if (_jpkFile.SprzedazWiersz != null)
            {
                for (var i = 0; i < _jpkFile.SprzedazWiersz.Length; i++)
                {
                    _jpkFile.SprzedazWiersz[i].LpSprzedazy = (i + 1).ToString();
                }

                _jpkFile.SprzedazCtrl.LiczbaWierszySprzedazy = _jpkFile.SprzedazWiersz.Length.ToString();
                _jpkFile.SprzedazCtrl.PodatekNalezny = _jpkFile.SprzedazWiersz.Where(x => x.DowodSprzedazy != "FP").Sum(x => x.K_16 + x.K_18 + x.K_20 + x.K_24 + x.K_26 + x.K_28 + x.K_30 + x.K_32 + x.K_33 + x.K_34 - x.K_35 - x.K_36);
            }
            else
            {
                _jpkFile.SprzedazCtrl.LiczbaWierszySprzedazy = "0";
                _jpkFile.SprzedazCtrl.PodatekNalezny = 0;
            }

            if (_jpkFile.ZakupWiersz != null)
            {
                for (var i = 0; i < _jpkFile.ZakupWiersz.Length; i++)
                {
                    _jpkFile.ZakupWiersz[i].LpZakupu = (i + 1).ToString();
                }

                _jpkFile.ZakupCtrl.LiczbaWierszyZakupow = _jpkFile.ZakupWiersz.Length.ToString();
                _jpkFile.ZakupCtrl.PodatekNaliczony = _jpkFile.ZakupWiersz.Sum(x => x.K_41 + x.K_43 + (x.K_44Specified ? x.K_44 : 0) + (x.K_45Specified ? x.K_45 : 0) + (x.K_46Specified ? x.K_46 : 0) + (x.K_47Specified ? x.K_47 : 0));
            }
            else
            {
                _jpkFile.ZakupCtrl.LiczbaWierszyZakupow = "0";
                _jpkFile.ZakupCtrl.PodatekNaliczony = 0;
            }

            _jpkFile.Deklaracja.Pouczenia = 1;

            SaveJpkFile();

            View.Close();
        }

        private bool SaveCommandCanExecute(object obj)
        {
            return true;
        }

    }
}