using System;
using System.Reflection;
using System.Windows.Input;
using System.Windows.Threading;
using JPK.Interfaces;
using JPK.Interfaces.Configuration;
using JPK_Wysylka.DB.Implementation.Services;
using JPK_Wysylka.DB.Interfaces.Services;
using JPK_WysylkaXML.License.Interfaces;
using JPK_WysylkaXML.UI.Interfaces.Commands.Factories;
using JPK_WysylkaXML.UI.Interfaces.Commands.RequestView.Factories;
using JPK_WysylkaXML.UI.Interfaces.Providers;
using JPK_WysylkaXML.UI.Interfaces.ViewModel.RequestHistory.Factories;
using UnitSoftware.Common.Interfaces.Views;
using UnitSoftware.Common.Interfaces.Wrappers.System;
using UnitSoftware.Common.Interfaces.Wrappers.System.Windows;
using UnitSoftware.Common.Wpf.Interfaces.Components.WpfMessageBox;
using UnitSoftware.Common.Wpf.Interfaces.Extensions;

namespace JPK_WysylkaXML.UI.Commands.Factories
{
    public class CommandFactory : ICommandFactory
    {
        private readonly IRequestServiceFactory _requestService;

        private readonly IRequestUpdater _requestUpdater;

        private readonly IEnvironmentWrapper _environmentWrapper;

        private readonly IRequestsViewCommandsFactory _requestsViewCommandsFactory;

        private readonly IRequestViewModelFactory _requestsViewModelFactory;

        private readonly IFilterViewModelFactory _filterViewModelFactory;

        private readonly IStatusProvider _statusProvider;
        
        private readonly IClipboardWrapper _clipboardWrapper;
        
        private readonly IWpfMessageBoxManager _wpfMessageBoxManager;

        private readonly IWaitCursorExtension _waitCursorExtension;

        public CommandFactory(IRequestServiceFactory requestService, IRequestUpdater requestUpdater, IEnvironmentWrapper environmentWrapper, IRequestsViewCommandsFactory requestsViewCommandsFactory,
            IRequestViewModelFactory requestsViewModelFactory, IFilterViewModelFactory filterViewModelFactory, IStatusProvider statusProvider, IClipboardWrapper clipboardWrapper,
            IWpfMessageBoxManager wpfMessageBoxManager, IWaitCursorExtension waitCursorExtension)
        {
            if (requestService == null) throw new ArgumentNullException("requestService");
            if (requestUpdater == null) throw new ArgumentNullException("requestUpdater");
            if (environmentWrapper == null) throw new ArgumentNullException("environmentWrapper");
            if (requestsViewCommandsFactory == null) throw new ArgumentNullException("requestsViewCommandsFactory");
            if (requestsViewModelFactory == null) throw new ArgumentNullException("requestsViewModelFactory");
            if (filterViewModelFactory == null) throw new ArgumentNullException("filterViewModelFactory");
            if (statusProvider == null) throw new ArgumentNullException("statusProvider");
            if (clipboardWrapper == null) throw new ArgumentNullException("clipboardWrapper");
            if (wpfMessageBoxManager == null) throw new ArgumentNullException("wpfMessageBoxManager");
            if (waitCursorExtension == null) throw new ArgumentNullException("waitCursorExtension");

            _requestService = requestService;
            _requestUpdater = requestUpdater;
            _environmentWrapper = environmentWrapper;
            _requestsViewCommandsFactory = requestsViewCommandsFactory;
            _requestsViewModelFactory = requestsViewModelFactory;
            _filterViewModelFactory = filterViewModelFactory;
            _statusProvider = statusProvider;
            _clipboardWrapper = clipboardWrapper;
            _wpfMessageBoxManager = wpfMessageBoxManager;
            _waitCursorExtension = waitCursorExtension;
        }

        public ICommand CreateOpenConfigurationCommand(IConfiguration configuration, IBaseView parentView)
        {
            return new OpenConfigurationCommand(configuration, parentView);
        }

        public ICommand CreateOpenHistoryCommand(IConfiguration configuration, IBaseView parentView, Dispatcher uiDispatcher, string applicationPath, ILicenseManager licenseManager)
        {
            var requestService = _requestService.Create(configuration);

            return new OpenHistoryCommand(parentView, requestService, _requestsViewCommandsFactory, _requestsViewModelFactory, _filterViewModelFactory, uiDispatcher, configuration, _statusProvider, applicationPath, _clipboardWrapper, _waitCursorExtension, licenseManager);
        }

        public ICommand CreateCheckStatusCommand(Action<string> addLogMessage, IJpkSender jpkSender, IConfiguration configuration)
        {
            return new CheckStatusCommand(jpkSender, addLogMessage, _requestUpdater, configuration);
        }

        public ICommand CreateSendCommand(Action<string> addLogMessage, Func<string, bool> canSendCommandExecute, IJpkSender jpkSender, Dispatcher uiDispatcher, IConfiguration configuration, IBaseView ownerView)
        {
            return new SendCommand(jpkSender, addLogMessage, _requestUpdater, uiDispatcher, canSendCommandExecute, configuration, _wpfMessageBoxManager, ownerView);
        }

        public ICommand CreateSendWithoutValidationCommand(Action<string> addLogMessage, Func<bool> canSendCommandExecute, IJpkSender jpkSender, Dispatcher uiDispatcher, IConfiguration configuration,IBaseView ownerView)
        {
            return new SendWithoutValidationCommand(jpkSender, addLogMessage, _requestUpdater, uiDispatcher, canSendCommandExecute, configuration, _wpfMessageBoxManager, ownerView);
        }

        public ICommand CreateExitCommand()
        {
            return new ExitCommand(_environmentWrapper);
        }

        public ICommand CreateShowVersionCommand(AppDomain currentDomain, Assembly entryAssembly, IBaseView ownerView)
        {
            return new ShowVersionCommand(currentDomain, entryAssembly, ownerView, _wpfMessageBoxManager, _clipboardWrapper);
        }
    }
}