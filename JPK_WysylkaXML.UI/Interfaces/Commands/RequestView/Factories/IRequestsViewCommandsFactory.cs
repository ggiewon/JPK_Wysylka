using System;
using System.Windows.Input;
using System.Windows.Threading;
using JPK.Interfaces.Configuration;
using JPK_Wysylka.DB.Interfaces.Services;
using JPK_WysylkaXML.License.Interfaces;
using JPK_WysylkaXML.UI.Commands.RequestView;
using JPK_WysylkaXML.UI.Interfaces.Views;
using UnitSoftware.Common.Interfaces.Commands;

namespace JPK_WysylkaXML.UI.Interfaces.Commands.RequestView.Factories
{
    public interface IRequestsViewCommandsFactory
    {
        IGenericCommand<RefreshParams> CreateRefreshAllCommand(IRequestService requestService, Dispatcher dispatcher, Action onStatucCheckFinish, IConfiguration configuration, ILicenseManager licenseManager);

        ICommand CreateCloseCommand(IRequestsView ownerView);

        IGenericCommand<DownloadUpoParams> CreateDownloadCommand(IRequestService requestService);

        IGenericCommand<DownloadUpoParams> CreateGenerateUpoCommand(string applicationPath, IRequestsView view, IRequestService requestService);
    }
}