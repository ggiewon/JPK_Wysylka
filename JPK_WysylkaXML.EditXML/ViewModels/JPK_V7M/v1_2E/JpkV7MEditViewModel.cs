using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using JPK.Interfaces;
using JPK_WysylkaXML.EditXML.Interfaces.JPK_V7M.v1_2E;
using JPK_WysylkaXML.EditXML.ViewModels.JPK_V7M.v1_2E.Factories;
using JPK_WysylkaXML.EditXML.Views.JPK_V7M.v1_2E;
using JPK_WysylkaXML.EditXML.XmlTypes.Version3_v7m.v1_2E;
using Syncfusion.UI.Xaml.Grid;
using UnitSoftware.Common.Implementation.Commands;
using UnitSoftware.Common.Interfaces.Commands;
using UnitSoftware.Common.Interfaces.Views;

namespace JPK_WysylkaXML.EditXML.ViewModels.JPK_V7M.v1_2E
{
    public class JpkV7MEditViewModel : BaseEditViewModel<XmlTypes.Version3_v7m.v1_2E.JPK>, IJpkV7MEditViewModel
    {
        private readonly ISettingsManager _settingsManager;

        public IRefreshableCommand SaveCommand { get; }

        public IRefreshableCommand CancelCommand { get; }

        public IRefreshableCommand SaleDoubleClickCommand { get; }

        public IRefreshableCommand PurchaseDoubleClickCommand { get; }

        public IRefreshableCommand AddNewSaleRowCommand { get; }

        public IRefreshableCommand DeleteSaleRowCommand { get; }

        public IRefreshableCommand DeleteAllSaleRowsCommand { get; }

        public IRefreshableCommand DeleteAllPurchaseRowsCommand { get; }

        public IRefreshableCommand ImportSaleRowsCommand { get; }

        public IRefreshableCommand ImportPurchaseRowsCommand { get; }

        public IRefreshableCommand AddNewPurchaseRowCommand { get; }

        public IRefreshableCommand DeletePurchaseRowCommand { get; }

        public IBaseView View { get; set; }

        private bool saleListLoaded = false;

        public IList<JPKEwidencjaSprzedazWiersz> SaleList
        {
            get
            {
                return _saleList;
            }
            private set
            {
                SaveGrids();

                _saleList = value;
                
                OnPropertyChanged();
                UpdateSaleGrid();
            }
        }

        public JPKEwidencjaSprzedazWiersz SelectedSaleRow { get; set; }

        public IList<JPKEwidencjaZakupWiersz> PurchaseList
        {
            get => _purchaseList;
            private set
            {
                SaveGrids();

                _purchaseList = value; 
                
                OnPropertyChanged();

                UpdatePurchaseGrid();
            }
        }

        public JPKEwidencjaZakupWiersz SelectedPurchaseRow { get; set; }

        public NaglowekViewModel Naglowek { get; }

        public DeklaracjeViewModel Deklaracje { get; }

        public SfDataGrid SaleGrid { get; set; }

        public SfDataGrid PurchaseGrid { get; set; }

        private IList<JPKEwidencjaSprzedazWiersz> _saleList;

        private IList<JPKEwidencjaZakupWiersz> _purchaseList;

        private readonly JPKEwidencjaSprzedazWierszFactory _saleFactory = new();

        private readonly JPKEwidencjaZakupWierszFactory _purchaseFactory = new();
        
        public JpkV7MEditViewModel(string filePath, ISettingsManager settingsManager) : base(filePath)
        {
            _settingsManager = settingsManager;

            CancelCommand = new DelegateCommand(CancelCommandExecute);
            SaveCommand = new DelegateCommand(SaveCommandExecute, SaveCommandCanExecute);
            SaleDoubleClickCommand = new DelegateCommand(DoubleClickCommandExecute);
            PurchaseDoubleClickCommand = new DelegateCommand(PurchaseDoubleClickCommandExecute);
            AddNewSaleRowCommand = new DelegateCommand(AddNewSaleCommandExecute);
            AddNewPurchaseRowCommand = new DelegateCommand(AddNewPurchaseRowCommandExecute);

            DeletePurchaseRowCommand = new DelegateCommand(DeletePurchaseRowCommandExecute, DeletePurchaseRowCanCommandExecute);
            DeleteSaleRowCommand = new DelegateCommand(DeleteSaleRowCommandExecute, DeleteSaleRowCanCommandExecute);
            ImportSaleRowsCommand = new DelegateCommand(ImportSaleRowsCommandExecute);
            ImportPurchaseRowsCommand = new DelegateCommand(ImportPurchaseRowsCommandExecute);

            DeleteAllSaleRowsCommand = new DelegateCommand(DeleteAllSaleRowsCommandExecute);
            DeleteAllPurchaseRowsCommand = new DelegateCommand(DeleteAllPurchaseRowsCommandExecute);

            if (_jpkFile.Ewidencja == null)
                _jpkFile.Ewidencja = new JPKEwidencja();

            SaleList = _jpkFile.Ewidencja.SprzedazWiersz != null ? _jpkFile.Ewidencja.SprzedazWiersz.ToList() : new List<JPKEwidencjaSprzedazWiersz>();

            PurchaseList = _jpkFile.Ewidencja.ZakupWiersz != null ? _jpkFile.Ewidencja.ZakupWiersz.ToList() : new List<JPKEwidencjaZakupWiersz>();

            Deklaracje = new DeklaracjeViewModel(_jpkFile.Deklaracja);

            Naglowek = new NaglowekViewModel(_jpkFile.Naglowek);
        }

        private void ImportSaleRowsCommandExecute(object obj)
        {
            var dlg = new Microsoft.Win32.OpenFileDialog
            {
                DefaultExt = ".csv",
                Filter = "Pliki csv|*.csv|Wszystkie pliki|*.*"
            };

            var result = dlg.ShowDialog();

            if (result == true)
            {
                var fileContent = File.ReadAllLines(dlg.FileName);

                var saleList = _jpkFile.Ewidencja.SprzedazWiersz != null ?_jpkFile.Ewidencja.SprzedazWiersz.ToList() : new List<JPKEwidencjaSprzedazWiersz>();
                
                saleList.AddRange(fileContent.Skip(1).Select(line => _saleFactory.Create(line)));

                _jpkFile.Ewidencja.SprzedazWiersz = saleList.ToArray();

                SaleList = _jpkFile.Ewidencja.SprzedazWiersz.ToList();
            }
        }

        private void ImportPurchaseRowsCommandExecute(object obj)
        {
            var dlg = new Microsoft.Win32.OpenFileDialog
            {
                DefaultExt = ".csv",
                Filter = "Pliki csv|*.csv|Wszystkie pliki|*.*",
            };

            var result = dlg.ShowDialog();

            if (result == true)
            {
                var fileContent = File.ReadAllLines(dlg.FileName);

                var purchaseList = _jpkFile.Ewidencja.ZakupWiersz != null ? _jpkFile.Ewidencja.ZakupWiersz.ToList() : new List<JPKEwidencjaZakupWiersz>();
                
                purchaseList.AddRange(fileContent.Skip(1).Select(line => _purchaseFactory.Create(line)));

                _jpkFile.Ewidencja.ZakupWiersz = purchaseList.ToArray();

                PurchaseList = _jpkFile.Ewidencja.ZakupWiersz.ToList();
            }
        }

        private void DeleteAllPurchaseRowsCommandExecute(object obj)
        {
            _jpkFile.Ewidencja.ZakupWiersz = new JPKEwidencjaZakupWiersz[0];

            PurchaseList = new List<JPKEwidencjaZakupWiersz>();
        }


        private void DeleteAllSaleRowsCommandExecute(object obj)
        {
            _jpkFile.Ewidencja.SprzedazWiersz = Array.Empty<JPKEwidencjaSprzedazWiersz>();

            SaleList = new List<JPKEwidencjaSprzedazWiersz>();
        }

        private void DeleteSaleRowCommandExecute(object obj)
        {
            var list = _jpkFile.Ewidencja.SprzedazWiersz.ToList().Where(x => x != SelectedSaleRow);

            _jpkFile.Ewidencja.SprzedazWiersz = list.ToArray();

            SaleList = _jpkFile.Ewidencja.SprzedazWiersz.ToList();
        }

        private bool DeleteSaleRowCanCommandExecute(object obj)
        {
            return SelectedSaleRow != null;
        }

        private void DeletePurchaseRowCommandExecute(object obj)
        {
            var list = _jpkFile.Ewidencja.ZakupWiersz.ToList().Where(x => x != SelectedPurchaseRow);

            _jpkFile.Ewidencja.ZakupWiersz = list.ToArray();

            PurchaseList = _jpkFile.Ewidencja.ZakupWiersz.ToList();
        }

        private bool DeletePurchaseRowCanCommandExecute(object obj)
        {
            return SelectedPurchaseRow != null;
        }
        
        private void AddNewPurchaseRowCommandExecute(object obj)
        {
            var row = new JPKEwidencjaZakupWiersz();

            var viewModel = new JpkV7MEditPurchaseDetailsViewModel(row);

            var view = new EditJpkFilePurchaseDetailsView { DataContext = viewModel, Owner = View.GetOwnerWindow()};

            viewModel.View = view;

            if (view.ShowDialog() ?? false)
            {
                var list = _jpkFile.Ewidencja.ZakupWiersz != null ? _jpkFile.Ewidencja.ZakupWiersz.ToList() : new List<JPKEwidencjaZakupWiersz>();
                
                list.Add(row);

                _jpkFile.Ewidencja.ZakupWiersz = list.ToArray();

                PurchaseList = _jpkFile.Ewidencja.ZakupWiersz.ToList();
            }
        }

        private void AddNewSaleCommandExecute(object obj)
        {
            var row = new JPKEwidencjaSprzedazWiersz();

            var viewModel = new JpkV7MEditSaleDetailsViewModel(row);

            var view = new EditJpkFileSaleDetailsView {DataContext = viewModel, Owner = View.GetOwnerWindow()};

            viewModel.View = view;

            if (view.ShowDialog() ?? false)
            {
                var list = _jpkFile.Ewidencja.SprzedazWiersz != null ? _jpkFile.Ewidencja.SprzedazWiersz.ToList() : new List<JPKEwidencjaSprzedazWiersz>();

                list.Add(row);

                _jpkFile.Ewidencja.SprzedazWiersz = list.ToArray();

                SaleList = _jpkFile.Ewidencja.SprzedazWiersz.ToList();
            }
        }

        private void PurchaseDoubleClickCommandExecute(object obj)
        {
            if (SelectedPurchaseRow == null)
                return;

            var viewModel = new JpkV7MEditPurchaseDetailsViewModel(SelectedPurchaseRow);

            var view = new EditJpkFilePurchaseDetailsView { DataContext = viewModel, Owner = View.GetOwnerWindow() };

            viewModel.View = view;

            view.ShowDialog();

            PurchaseList = _jpkFile.Ewidencja.ZakupWiersz.ToList();
        }

        private void DoubleClickCommandExecute(object obj)
        {
            if (SelectedSaleRow == null)
                return;

            var viewModel = new JpkV7MEditSaleDetailsViewModel(SelectedSaleRow);

            var view = new EditJpkFileSaleDetailsView {DataContext = viewModel, Owner = View.GetOwnerWindow()};

            viewModel.View = view;

            view.ShowDialog();

            SaleList = _jpkFile.Ewidencja.SprzedazWiersz.ToList();
        }

        private void CancelCommandExecute(object obj)
        {
            View.Close();
        }

        private void SaveCommandExecute(object obj)
        {
            if (_jpkFile.Ewidencja.SprzedazWiersz != null)
            {
                for (var i = 0; i < _jpkFile.Ewidencja.SprzedazWiersz.Length; i++)
                {
                    _jpkFile.Ewidencja.SprzedazWiersz[i].LpSprzedazy = (i + 1).ToString();
                }

                _jpkFile.Ewidencja.SprzedazCtrl.LiczbaWierszySprzedazy = _jpkFile.Ewidencja.SprzedazWiersz.Length.ToString();
                _jpkFile.Ewidencja.SprzedazCtrl.PodatekNalezny = _jpkFile.Ewidencja.SprzedazWiersz.Where(x => x.DowodSprzedazy != "FP").Sum(x => x.K_16 + x.K_18 + x.K_20 + x.K_24 + x.K_26 + x.K_28 + x.K_30 + x.K_32 + x.K_33 + x.K_34 - x.K_35 - x.K_36);
            }
            else
            {
                _jpkFile.Ewidencja.SprzedazCtrl.LiczbaWierszySprzedazy = "0";
                _jpkFile.Ewidencja.SprzedazCtrl.PodatekNalezny = 0;
            }

            if (_jpkFile.Ewidencja.ZakupWiersz != null)
            {
                for (var i = 0; i < _jpkFile.Ewidencja.ZakupWiersz.Length; i++)
                {
                    _jpkFile.Ewidencja.ZakupWiersz[i].LpZakupu = (i + 1).ToString();
                }

                _jpkFile.Ewidencja.ZakupCtrl.LiczbaWierszyZakupow = _jpkFile.Ewidencja.ZakupWiersz.Length.ToString();
                _jpkFile.Ewidencja.ZakupCtrl.PodatekNaliczony     = _jpkFile.Ewidencja.ZakupWiersz.Sum(x => x.K_41 + x.K_43 + (x.K_44Specified ? x.K_44 : 0) + (x.K_45Specified ? x.K_45 : 0) + (x.K_46Specified ? x.K_46 : 0) + (x.K_47Specified ? x.K_47 : 0));
            }
            else
            {
                _jpkFile.Ewidencja.ZakupCtrl.LiczbaWierszyZakupow = "0";
                _jpkFile.Ewidencja.ZakupCtrl.PodatekNaliczony = 0;
            }

            _jpkFile.Deklaracja.Pouczenia = 1;

            SaveJpkFile();
            
            View.Close();
        }

        private bool SaveCommandCanExecute(object obj)
        {
            return true;
        }

        public void UpdateSaleGrid()
        {
            if (SaleGrid != null && _settingsManager.SaleSettingExists)
            {
                SaleGrid.Deserialize(_settingsManager.GetSaleGridSettings());
            }
        }

        public void UpdatePurchaseGrid()
        {
            if (PurchaseGrid != null && _settingsManager.PurchaseSettingExists)
            {
                PurchaseGrid.Deserialize(_settingsManager.GetPurchaseGridSettings());
            }
        }

        public void SaveGrids()
        {
            var serializationOptions = new SerializationOptions {SerializeGrouping = true, SerializeFiltering = true, SerializeSorting = true, SerializeStackedHeaders = true, SerializeDetailsViewDefinition = true, SerializeTableSummaries = true, SerializeGroupSummaries = true};

            if (SaleGrid != null)
                using (var stream = new MemoryStream())
                {
                    SaleGrid.Serialize(stream, serializationOptions);

                    stream.Position = 0;

                    using (StreamReader reader = new(stream))
                    {
                        string saleGridSettings = reader.ReadToEnd();

                        _settingsManager.SetSaleGridSettings(saleGridSettings);
                    }
                }

            if (PurchaseGrid != null)
                using (var stream = new MemoryStream())
                {
                    PurchaseGrid.Serialize(stream, serializationOptions);

                    stream.Position = 0;

                    using (StreamReader reader = new(stream))
                    {
                        string settings = reader.ReadToEnd();

                        _settingsManager.SetPurchaseGridSettings(settings);
                    }
                }
        }
    }
}