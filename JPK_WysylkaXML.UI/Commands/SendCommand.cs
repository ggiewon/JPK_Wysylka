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
    public class SendCommand : BaseRefreshableCommand
    {
        private readonly IJpkSender _jpkSender;

        private readonly Action<string> _addLogMessage;

        private readonly IRequestUpdater _requestUpdater;

        private readonly Dispatcher _uiDispatcher;

        private readonly Func<string, bool> _canSendCommandExecute;

        private readonly IConfiguration _configuration;
        
        private readonly IWpfMessageBoxManager _wpfMessageBoxManager;
        
        private readonly IBaseView _ownerView;

        public SendCommand(IJpkSender jpkSender, Action<string> addLogMessage, IRequestUpdater requestUpdater, Dispatcher uiDispatcher, Func<string, bool> canSendCommandExecute, IConfiguration configuration, IWpfMessageBoxManager wpfMessageBoxManager, IBaseView ownerView)
        {
            _jpkSender = jpkSender ?? throw new ArgumentNullException(nameof(jpkSender));
            _addLogMessage = addLogMessage ?? throw new ArgumentNullException(nameof(addLogMessage));
            _requestUpdater = requestUpdater ?? throw new ArgumentNullException(nameof(requestUpdater));
            _uiDispatcher = uiDispatcher ?? throw new ArgumentNullException(nameof(uiDispatcher));
            _canSendCommandExecute = canSendCommandExecute;
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _wpfMessageBoxManager = wpfMessageBoxManager ?? throw new ArgumentNullException(nameof(wpfMessageBoxManager));
            _ownerView = ownerView ?? throw new ArgumentNullException(nameof(ownerView));
        }

        public override bool CanExecute(object parameter)
        {
            var strParam = (string) parameter;

            return _canSendCommandExecute == null || _canSendCommandExecute(strParam);
        }

        public override async void Execute(object parameter)
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

        private async void SendCallback(IStatusCallback statusCallback)
        {
            await _requestUpdater.AddOrUpdateAsync(statusCallback.RequestNo, statusCallback.Configuration, statusCallback.StatusCode, statusCallback.StatusDescription, statusCallback.SendDate);
        }
    }
}