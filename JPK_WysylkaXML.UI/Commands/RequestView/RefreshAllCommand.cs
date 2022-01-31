using System;
using System.Threading.Tasks;
using System.Windows.Threading;
using JPK.Interfaces;
using JPK.Interfaces.Configuration;
using JPK_Wysylka.DB.Interfaces.Services;
using UnitSoftware.Common.Interfaces.Commands;

namespace JPK_WysylkaXML.UI.Commands.RequestView
{
    public class RefreshAllCommand : IGenericCommand<RefreshParams>, IDisposable
    {
        private readonly IRequestService _requestService;

        private readonly IJpkSender _jpkSender;

        private readonly Dispatcher _uiDispatcher;

        private readonly Action _onStatusCheckFinish;

        private readonly IConfiguration _configuration;

        private Task _checkTask;

        public RefreshAllCommand(IRequestService requestService, IJpkSender jpkSender, Dispatcher uiDispatcher, Action onStatusCheckFinish, IConfiguration configuration)
        {
            if (jpkSender == null) throw new ArgumentNullException("jpkSender");
            if (uiDispatcher == null) throw new ArgumentNullException("uiDispatcher");

            _requestService = requestService;
            _jpkSender = jpkSender;
            _uiDispatcher = uiDispatcher;
            _onStatusCheckFinish = onStatusCheckFinish;
            _configuration = configuration;
        }

        private async void CheckStatusCallback(IStatusCallback status)
        {
            var request = await _requestService.GetByReferenceNoAsync(status.RequestNo, status.Configuration.SelectedServer);

            var code = int.Parse(status.StatusCode);

            if (code != request.LastStatus)
            {
                request.LastStatus = code;
                request.LastStatusDescription = status.StatusDescription;

                await _requestService.UpdateRequestAsync(request);
            }
        }

        public void Execute(RefreshParams parameter)
        {
            _checkTask = Task.Run(() =>
            {
                var list = parameter.ReferenceNoList;

                foreach (var refNo in list)
                    _jpkSender.CheckStatus(refNo, _uiDispatcher, message => { }, CheckStatusCallback, _configuration).Wait();
            }).ContinueWith(task =>
            {
                if (_onStatusCheckFinish != null)
                    _onStatusCheckFinish();
            });
        }

        public bool CanExecute(RefreshParams parameter)
        {
            return parameter.ReferenceNoList.Count > 0;
        }

        public void Dispose()
        {
            if (_checkTask != null)
            {
                _checkTask.Dispose();
                _checkTask = null;
            }
        }
    }    
}