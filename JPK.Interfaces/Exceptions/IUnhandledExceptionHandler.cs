using System;
using System.Windows.Threading;

namespace JPK.Interfaces.Exceptions
{
    public interface IUnhandledExceptionHandler
    {
        bool IsSilentMode { get; set; }

        void HandleUnhandledException(object sender, UnhandledExceptionEventArgs e);

        void HandleDispatherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e);
    }
}