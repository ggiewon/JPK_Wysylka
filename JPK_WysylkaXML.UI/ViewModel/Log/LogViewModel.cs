using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using JPK_WysylkaXML.UI.Interfaces.ViewModel;
using UnitSoftware.Common.Implementation.Commands;
using UnitSoftware.Common.Interfaces.Wrappers.IO;
using UnitSoftware.Common.Interfaces.Wrappers.System;
using UnitSoftware.Common.Wpf.Implementation.ViewModels;

namespace JPK_WysylkaXML.UI.ViewModel.Log
{
    public class LogViewModel : ViewModelBase, ILogViewModel
    {
        private readonly ISystemDateTime _systemDateTime;

        private readonly IFileWrapper _fileWrapper;

        public LogViewModel(ISystemDateTime systemDateTime, IFileWrapper fileWrapper)
        {
            if (systemDateTime == null) throw new ArgumentNullException("systemDateTime");
            if (fileWrapper == null) throw new ArgumentNullException("fileWrapper");

            _systemDateTime = systemDateTime;
            _fileWrapper = fileWrapper;

            LogMessageList = new ObservableCollection<string>();

            ClearCommand = new DelegateCommand(ClearCommandExecute, ClearCommandCanExecute);

            SaveToFileCommand = new DelegateCommand(SaveToFileCommandExecute, SaveToFileCommandCanExecute);
        }

        private bool SaveToFileCommandCanExecute(object obj)
        {
            return LogMessageList.Count > 0;
        }

        private void SaveToFileCommandExecute(object obj)
        {
            const string defaultExt = "*.log";

            const string filter = "Pliki logów (*.log)|*.log|Wszystkie pliki (*.*)|*.*";

            var dlg = new Microsoft.Win32.SaveFileDialog
            {
                DefaultExt = defaultExt,
                Filter = filter,
            };

            var result = dlg.ShowDialog();

            if (result == true)
            {
                var filePath = dlg.FileName;

                if (!string.IsNullOrEmpty(filePath))
                {
                    _fileWrapper.WriteAllLines(filePath, LogMessageList);
                }
            }
        }

        private bool ClearCommandCanExecute(object obj)
        {
            return LogMessageList.Count > 0;
        }

        private void ClearCommandExecute(object obj)
        {
            LogMessageList.Clear();

            OnPropertyChanged(nameof(LogMessages));
        }


        private ObservableCollection<string> LogMessageList { get; set; }

        public string LogMessages
        {
            get { return string.Join(Environment.NewLine, LogMessageList); }
        }

        public ICommand ClearCommand { get; private set; }

        public ICommand SaveToFileCommand { get; private set; }

        public void AddLogMessage(string message)
        {
            var formatedMessage = string.Format("{0} - {1}", _systemDateTime.Now().ToLongTimeString(), message);

            LogMessageList.Add(formatedMessage);

            OnPropertyChanged(nameof(LogMessages));
        }
    }
}