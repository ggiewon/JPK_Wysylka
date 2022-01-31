using System;
using System.Reflection;
using System.Windows.Input;
using System.Windows.Threading;
using JPK.Interfaces;
using JPK.Interfaces.Configuration;
using JPK_WysylkaXML.License.Interfaces;
using UnitSoftware.Common.Interfaces.Views;

namespace JPK_WysylkaXML.UI.Interfaces.Commands.Factories
{
    public interface ICommandFactory
    {
        ICommand CreateOpenConfigurationCommand(IConfiguration configuration, IBaseView parentView);

        ICommand CreateOpenHistoryCommand(IConfiguration configuration, IBaseView parentView, Dispatcher uiDispatcher, string applicationPath, ILicenseManager licenseManager);

        ICommand CreateCheckStatusCommand(Action<string> addLogMessage, IJpkSender jpkSender, IConfiguration configuration);

        ICommand CreateSendCommand(Action<string> addLogMessage, Func<string, bool> canSendCommandExecute, IJpkSender jpkSender, Dispatcher uiDispatcher, IConfiguration configuration, IBaseView ownerView);

        ICommand CreateSendWithoutValidationCommand(Action<string> addLogMessage, Func<bool> canSendCommandExecute, IJpkSender jpkSender, Dispatcher uiDispatcher, IConfiguration configuration, IBaseView ownerView);

        ICommand CreateExitCommand();

        ICommand CreateShowVersionCommand(AppDomain currentDomain, Assembly entryAssembly, IBaseView ownerView);
    }
}