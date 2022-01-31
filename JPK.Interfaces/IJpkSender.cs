using System;
using System.Threading.Tasks;
using System.Windows.Threading;
using JPK.Interfaces.Configuration;

namespace JPK.Interfaces
{
    public interface IJpkSender
    {
        Task<bool> SendXml(string inputFilename, Dispatcher currentDispatcher, Action<string> logCallback, Action<IStatusCallback> sendCallback, IConfiguration configuration);

        Task CheckStatus(string referenceNo, Dispatcher currentDispatcher, Action<string> logCallback, Action<IStatusCallback> statusCallback, IConfiguration configuration);
    }
}