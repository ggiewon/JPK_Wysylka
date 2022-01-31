using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using JPK.Interfaces;
using JPK.Interfaces.Configuration;
using JPK_Wysylka.DB.Interfaces.Services;
using JPK_WysylkaXML.License.Interfaces;
using JPK_WysylkaXML.UI.Commands.RequestView;
using JPK_WysylkaXML.UI.Interfaces.Commands.RequestView.Factories;
using JPK_WysylkaXML.UI.Interfaces.Providers;
using JPK_WysylkaXML.UI.Interfaces.ViewModel.RequestHistory;
using JPK_WysylkaXML.UI.Interfaces.ViewModel.RequestHistory.Factories;
using JPK_WysylkaXML.UI.Interfaces.Views;
using NLog;
using UnitSoftware.Common.Implementation.Commands;
using UnitSoftware.Common.Interfaces.Commands;
using UnitSoftware.Common.Wpf.Implementation.ViewModels;

namespace JPK_WysylkaXML.UI.ViewModel.RequestHistory
{
    public class RequestHistoryViewModel : ViewModelBase, IRequestsViewModel
    {
        private readonly IRequestService _requestService;

        private readonly IRequestViewModelFactory _requestViewModelFactory;
        
        private readonly ServerType _selectedServerType;

        private readonly IStatusProvider _statusProvider;

        private ObservableCollection<IRequestViewModel> _requestList;

        private Task _loadTask;

        private bool _isLoadingStarted;

        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();

        public bool IsTestServer => _selectedServerType == ServerType.Test;

        public ObservableCollection<IRequestViewModel> RequestList
        {
            get
            {
                if (!_isLoadingStarted)
                {
                    _isLoadingStarted = true;

                    _loadTask = LoadData();
                }

                return _requestList;
            }
        }

        private async Task LoadData()
        {
            try
            {
                if (_loadTask != null)
                {
                    _loadTask.Dispose();
                    _loadTask = null;
                }

                var list = await _requestService.GetListAsync();

                var filteredList = list.Where(r => r.ServerType == FilterViewModel.SelectedServerType);

                if (FilterViewModel.StartDate.HasValue)
                    filteredList = filteredList.Where(r => r.SendDate >= FilterViewModel.StartDate.Value);

                if (FilterViewModel.EndDate.HasValue)
                    filteredList = filteredList.Where(r => r.SendDate <= FilterViewModel.EndDate.Value);

                _requestList = new ObservableCollection<IRequestViewModel>(filteredList.Select(_requestViewModelFactory.Create).ToList());
            }
            catch (Exception ex)
            {
                Logger.Error(ex);

                MessageBox.Show(ex.Message, "Błąd aplikacji", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally 
            {
                OnPropertyChanged(nameof(RequestList));

                IsWaitDisplayed = false;
            }
        }

        public IFilterViewModel FilterViewModel { get; private set; }

        public ICommand RefreshAllCommand { get; private set; }

        private readonly IGenericCommand<DownloadUpoParams> _internalDownloadCommand;

        private readonly IGenericCommand<DownloadUpoParams> _internalGenerateUpoCommand;
        
        private bool _isWaitDisplayed;

        private readonly IGenericCommand<RefreshParams> _internalRefreshCommand;       

        public ICommand DownloadUpoCommand { get; private set; }

        public ICommand GenerateUpoCommand { get; private set; }

        public ICommand CloseCommand { get; private set; }

        public IRequestViewModel SelectedItem { get; set; }

        public bool IsWaitDisplayed
        {
            get { return _isWaitDisplayed; }
            set
            {
                if (value != _isWaitDisplayed)
                {
                    _isWaitDisplayed = value;
                    OnPropertyChanged(nameof(IsWaitDisplayed));
                }
            }
        }

        public ICommand DoubleClickCommnad { get; private set; }

        public RequestHistoryViewModel(IRequestService requestService, IRequestsViewCommandsFactory requestsViewCommandsFactory, IRequestsView view, IRequestViewModelFactory requestViewModelFactory, 
            IFilterViewModelFactory filterViewModelFactory, Dispatcher uiDispatcher, ServerType selectedServerType, IStatusProvider statusProvider, string applicationPath, IConfiguration configuration, ILicenseManager licenseManager)
        {          
            if (requestService == null) throw new ArgumentNullException("requestService");
            if (uiDispatcher == null) throw new ArgumentNullException("uiDispatcher");
            if (statusProvider == null) throw new ArgumentNullException("statusProvider");
            if (string.IsNullOrEmpty(applicationPath)) throw new ArgumentNullException("applicationPath");

            _requestService = requestService;
            _requestViewModelFactory = requestViewModelFactory;
            _selectedServerType = selectedServerType;
            _statusProvider = statusProvider;

            FilterViewModel = filterViewModelFactory.Create(selectedServerType);

            _requestList = new ObservableCollection<IRequestViewModel>();

            _internalRefreshCommand = requestsViewCommandsFactory.CreateRefreshAllCommand(requestService, uiDispatcher, OnStatucCheckFinish, configuration, licenseManager);
            RefreshAllCommand = new RelayCommand(RefreshAllCommandExecute);

            _internalDownloadCommand = requestsViewCommandsFactory.CreateDownloadCommand(requestService);
            DownloadUpoCommand = new RelayCommand(DownloadCommandExecute, DownloadCommandCanExecute);

            DoubleClickCommnad = new RelayCommand(DownloadCommandExecute, DownloadCommandCanExecute);

            CloseCommand = requestsViewCommandsFactory.CreateCloseCommand(view);
            
            GenerateUpoCommand = new RelayCommand(GenerateUpoCommandExecute, DownloadCommandCanExecute);
            _internalGenerateUpoCommand = requestsViewCommandsFactory.CreateGenerateUpoCommand(applicationPath, view, requestService);
            FilterViewModel.OnFilterChange += OnFilterChange;
        }

        private void GenerateUpoCommandExecute(object obj)
        {
            _internalGenerateUpoCommand.Execute(new DownloadUpoParams(SelectedItem.IsUpo, SelectedItem.ReferenceNo, SelectedItem.ServerType));
        }

        private void OnStatucCheckFinish()
        {
            _loadTask = LoadData();

            _loadTask.Wait();
        }

        private void RefreshAllCommandExecute(object obj)
        {
            IsWaitDisplayed = true;

            var statusList = _statusProvider.FinishStatusList();

            var list = _requestList.Where(r => (!statusList.Contains(r.LastStatus))).Select(r => r.ReferenceNo).ToList();

            _internalRefreshCommand.Execute(new RefreshParams(list));
        }

        private void OnFilterChange(object sender, EventArgs e)
        {
            _loadTask = LoadData();
        }

        private void DownloadCommandExecute(object obj)
        {
            _internalDownloadCommand.Execute(new DownloadUpoParams(SelectedItem.IsUpo, SelectedItem.ReferenceNo, SelectedItem.ServerType));          
        }

        private bool DownloadCommandCanExecute(object obj)
        {
            return SelectedItem != null && _internalDownloadCommand.CanExecute(new DownloadUpoParams(SelectedItem.IsUpo, SelectedItem.ReferenceNo, SelectedItem.ServerType));
        }
    }
}