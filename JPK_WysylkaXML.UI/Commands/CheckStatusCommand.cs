using System;
using System.Windows.Threading;
using JPK.Interfaces;
using JPK.Interfaces.Configuration;
using JPK_Wysylka.DB.Interfaces.Services;
using NLog;
using UnitSoftware.Common.Implementation.Commands;

namespace JPK_WysylkaXML.UI.Commands
{
    public class CheckStatusCommand : BaseRefreshableCommand
    {
        private readonly IJpkSender _jpkSender;

        private readonly Action<string> _addLogMessage;

        private readonly IRequestUpdater _requestUpdater;

        private readonly IConfiguration _configuration;

        private readonly ILogger _logger = LogManager.GetCurrentClassLogger();

        public CheckStatusCommand(IJpkSender jpkSender, Action<string> addLogMessage, IRequestUpdater requestUpdater, IConfiguration configuration)
        {
            if (jpkSender == null) throw new ArgumentNullException("jpkSender");
            if (addLogMessage == null) throw new ArgumentNullException("addLogMessage");
            if (requestUpdater == null) throw new ArgumentNullException("requestUpdater");

            _jpkSender = jpkSender;
            _addLogMessage = addLogMessage;
            _requestUpdater = requestUpdater;
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public override bool CanExecute(object parameter)
        {
            var refNo = parameter as string;

            if (string.IsNullOrEmpty(refNo))
                return false;

            return !string.IsNullOrEmpty(refNo);
        }

        public override async void Execute(object parameter)
        {
            _addLogMessage("Sprawdzanie statusu w toku...");

            _logger.Trace("CheckStatusCommand.Execute - begin");

            var refNo = parameter as string;

            await _jpkSender.CheckStatus(refNo, Dispatcher.CurrentDispatcher, _addLogMessage, CheckStatusCallback, _configuration);

            _addLogMessage("Sprawdzanie statusu zakoñczone.");

            _logger.Trace("CheckStatusCommand.Execute - end");
        }

        private async void CheckStatusCallback(IStatusCallback statusCallback)
        {
            try
            {
                await _requestUpdater.AddOrUpdateAsync(statusCallback.RequestNo, statusCallback.Configuration, statusCallback.StatusCode, statusCallback.StatusDescription, null);
            }
            catch (Exception ex)
            {
                _addLogMessage(string.Format("Wyst¹pi³ b³¹d przy aktualizacji statusu w historii: {0}", ex.Message));

                _logger.Error(ex);
            }
            
        }
    }
}