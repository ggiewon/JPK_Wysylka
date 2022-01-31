using System.Windows.Input;

namespace JPK_WysylkaXML.UI.Interfaces.ViewModel
{
    public interface ILogViewModel
    {
        string LogMessages { get; }

        ICommand ClearCommand { get; }

        ICommand SaveToFileCommand { get; }

        void AddLogMessage(string logMessage);
    }
}