using System;
using System.Windows.Threading;
using JPK.Interfaces;
using JPK.Interfaces.Configuration;
using JPK_Wysylka.DB.Interfaces.Services;
using JPK_WysylkaXML.UI.Components;
using UnitSoftware.Common.Implementation.Commands;
using UnitSoftware.Common.Interfaces.Views;
using UnitSoftware.Common.Wpf.Implementation.Components.WpfMessageBox;
using UnitSoftware.Common.Wpf.Interfaces.Components.WpfMessageBox;

namespace JPK_WysylkaXML.UI.Commands
{
    public class SendWithoutValidationCommand : BaseRefreshableCommand
    {
        private readonly IJpkSender _jpkSender;

        private readonly Action<string> _addLogMessage;

        private readonly IRequestUpdater _requestUpdater;

        private readonly Dispatcher _uiDispatcher;

        private readonly Func<bool> _canSendCommandExecute;
        
        private readonly IConfiguration _configuration;
        
        private readonly IWpfMessageBoxManager _wpfMessageBoxManager;
        
        private readonly IBaseView _ownerView;

        public SendWithoutValidationCommand(IJpkSender jpkSender, Action<string> addLogMessage, IRequestUpdater requestUpdater, Dispatcher uiDispatcher, Func<bool> canSendCommandExecute, IConfiguration configuration, IWpfMessageBoxManager wpfMessageBoxManager, IBaseView ownerView)
        {
            if (jpkSender == null) throw new ArgumentNullException("jpkSender");
            if (addLogMessage == null) throw new ArgumentNullException("addLogMessage");
            if (requestUpdater == null) throw new ArgumentNullException("requestUpdater");
            if (uiDispatcher == null) throw new ArgumentNullException("uiDispatcher");
            if (configuration == null) throw new ArgumentNullException("configuration");

            _jpkSender = jpkSender;
            _addLogMessage = addLogMessage;
            _requestUpdater = requestUpdater;
            _uiDispatcher = uiDispatcher;
            _canSendCommandExecute = canSendCommandExecute;
            _configuration = configuration;
            _wpfMessageBoxManager = wpfMessageBoxManager ?? throw new ArgumentNullException(nameof(wpfMessageBoxManager));
            _ownerView = ownerView ?? throw new ArgumentNullException(nameof(ownerView));
        }

        public override bool CanExecute(object parameter)
        {
            if (_canSendCommandExecute == null)
                return true;

            return _canSendCommandExecute();
        }

        public override async void Execute(object parameter)
        {
            if (WpfMessageBox.Show(ResourceTranslator.GetString("SendFile_SendingWithoutValidationTitle"), ResourceTranslator.GetString("SendFile_SendingWithoutValidationQuestion"), WpfMessageBoxButtons.YesNo, WpfMessageBoxImage.Question) == WpfMessageBoxResult.Yes)
            {
                if (_configuration.SelectedServer == ServerType.Test)
                {
                    if (_wpfMessageBoxManager.ShowDialog(ResourceTranslator.GetString("SendFile_SendingTestServerTitle"), ResourceTranslator.GetString("SendFile_SendingTestServerMessage"), WpfMessageBoxImage.Question, WpfMessageBoxButtons.YesNo, _ownerView) != WpfMessageBoxResult.Yes)
                    {
                        _addLogMessage(ResourceTranslator.GetString("SendFile_SendingCanceledMessage"));

                        return;
                    }
                }

                _addLogMessage(ResourceTranslator.GetString("SendFile_SendingInProgress"));

                var filePath = parameter as string;

                await _jpkSender.SendXml(filePath, _uiDispatcher, _addLogMessage, SendCallback, _configuration);
            }
        }

        private async void SendCallback(IStatusCallback statusCallback)
        {
            await _requestUpdater.AddOrUpdateAsync(statusCallback.RequestNo, statusCallback.Configuration, statusCallback.StatusCode, statusCallback.StatusDescription, statusCallback.SendDate);
        }
    }
}