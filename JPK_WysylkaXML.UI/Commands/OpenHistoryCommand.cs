using System;
using System.Windows;
using System.Windows.Threading;
using JPK.Interfaces.Configuration;
using JPK_Wysylka.DB.Interfaces.Services;
using JPK_WysylkaXML.License.Interfaces;
using JPK_WysylkaXML.UI.Interfaces.Commands.RequestView.Factories;
using JPK_WysylkaXML.UI.Interfaces.Providers;
using JPK_WysylkaXML.UI.Interfaces.ViewModel.RequestHistory.Factories;
using JPK_WysylkaXML.UI.ViewModel.RequestHistory;
using JPK_WysylkaXML.UI.Views.RequestHistory;
using NLog;
using UnitSoftware.Common.Implementation.Commands;
using UnitSoftware.Common.Interfaces.Views;
using UnitSoftware.Common.Interfaces.Wrappers.System.Windows;
using UnitSoftware.Common.Wpf.Interfaces.Extensions;

namespace JPK_WysylkaXML.UI.Commands
{
    public class OpenHistoryCommand : BaseRefreshableCommand
    {
        private readonly IBaseView _parentView;

        private readonly IRequestService _requestService;

        private readonly IRequestsViewCommandsFactory _requestsViewCommandsFactory;

        private readonly IRequestViewModelFactory _requestsViewModelFactory;

        private readonly IFilterViewModelFactory _filterViewModelFactory;

        private readonly Dispatcher _uiDispatcher;

        private readonly IConfiguration _configuration;
        
        private readonly IStatusProvider _statusProvider;

        private readonly string _applicationPath;

        private readonly IWaitCursorExtension _waitCursorExtension;
        private readonly ILicenseManager _licenseManager;

        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();

        public OpenHistoryCommand(IBaseView parentView, IRequestService requestService, IRequestsViewCommandsFactory requestsViewCommandsFactory, IRequestViewModelFactory requestViewModelFactory, 
            IFilterViewModelFactory filterViewModelFactory, Dispatcher uiDispatcher, IConfiguration configuration, IStatusProvider statusProvider, string applicationPath, 
            IClipboardWrapper clipboardWrapper, IWaitCursorExtension waitCursorExtension, ILicenseManager licenseManager)
        {
            if (parentView == null) throw new ArgumentNullException("parentView");
            if (requestService == null) throw new ArgumentNullException("requestService");
            if (requestsViewCommandsFactory == null) throw new ArgumentNullException("requestsViewCommandsFactory");
            if (requestViewModelFactory == null) throw new ArgumentNullException("requestViewModelFactory");
            if (filterViewModelFactory == null) throw new ArgumentNullException("filterViewModelFactory");
            if (uiDispatcher == null) throw new ArgumentNullException("uiDispatcher");
            if (configuration == null) throw new ArgumentNullException("configuration");
            if (statusProvider == null) throw new ArgumentNullException("statusProvider");
            if (clipboardWrapper == null) throw new ArgumentNullException("clipboardWrapper");
            if (waitCursorExtension == null) throw new ArgumentNullException("waitCursorExtension");
            if (string.IsNullOrEmpty(applicationPath)) throw new ArgumentNullException("applicationPath");

            _parentView = parentView;
            _requestService = requestService;
            _requestsViewCommandsFactory = requestsViewCommandsFactory;
            _requestsViewModelFactory = requestViewModelFactory;
            _filterViewModelFactory = filterViewModelFactory;
            _uiDispatcher = uiDispatcher;
            _configuration = configuration;
            _statusProvider = statusProvider;
            _applicationPath = applicationPath;
            _waitCursorExtension = waitCursorExtension;
            _licenseManager = licenseManager ?? throw new ArgumentNullException(nameof(licenseManager));
        }

        public override void Execute(object parameter)
        {
            try
            {
                _waitCursorExtension.SetBusy();

                var requestHistoryView = new RequestsView { Owner = _parentView.GetOwnerWindow() };

                var viewModel = new RequestHistoryViewModel(_requestService, _requestsViewCommandsFactory, requestHistoryView, _requestsViewModelFactory, _filterViewModelFactory, _uiDispatcher, _configuration.SelectedServer, _statusProvider, _applicationPath, _configuration, _licenseManager);

                requestHistoryView.DataContext = viewModel;

                requestHistoryView.ShowDialog();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);

                MessageBox.Show(ex.Message, "B³¹d aplikacji", MessageBoxButton.OK, MessageBoxImage.Error);
            }            
        }
    }
}