using System;
using System.Collections.Generic;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using JPK.Interfaces.Configuration;
using JPK_WysylkaXML.UI.Interfaces.ViewModel;
using JPK_WysylkaXML.UI.Interfaces.Views;
using UnitSoftware.Common.Implementation.Commands;
using UnitSoftware.Common.Interfaces.Commands;
using UnitSoftware.Common.Wpf.Implementation.ViewModels;

namespace JPK_WysylkaXML.UI.ViewModel
{
    public class ConfigurationViewModel : ViewModelBase, IConfigurationViewModel
    {
        private readonly IConfiguration _configuration;

        private string _dataFolder;

        private string _language;

        public IRefreshableCommand SaveCommand { get; private set; }

        public IRefreshableCommand CancelCommand { get; private set; }

        public string DataFolder
        {
            get { return _dataFolder; }
            set
            {
                if (_dataFolder != value)
                {
                    _dataFolder = value;
                    
                    IsConfigurationModified = true;

                    OnPropertyChanged(nameof(DataFolder));

                    SaveCommand.RaiseCanExecuteChanged();
                }
            }
        }

        public Dictionary<string, string> LanguageList => new() {{"Polski", "pl"}, {"Angielski", "en"}};

        public string Language
        {
            get { return _language; }
            set
            {
                if (_language != value)
                {
                    _language = value;

                    IsConfigurationModified = true;

                    OnPropertyChanged(nameof(Language));

                    SaveCommand.RaiseCanExecuteChanged();
                }
            }
        }

        public ICommand OpenFolderDialogCommand { get; private set; }
        
        public IConfigurationView View { get; set; }

        public bool IsConfigurationModified { get; set; }

        public ConfigurationViewModel(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException("configuration");

            _dataFolder = configuration.DataFolderPath;

            _language = configuration.Language;

            CancelCommand = new DelegateCommand(CancelCommandExecute);
            SaveCommand = new DelegateCommand(SaveCommandExecute, SaveCommandCanExecute);
            OpenFolderDialogCommand = new RelayCommand(OpenFolderDialogCommandExecute);
        }

        private void OpenFolderDialogCommandExecute(object obj)
        {            
            var dlg = new FolderBrowserDialog
            {
                SelectedPath = DataFolder, Description = "Proszê wybraæ lokalizacjê folderu danych", ShowNewFolderButton = true
            };

            var result = dlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                DataFolder = dlg.SelectedPath;
            }
        }

        private void CancelCommandExecute(object obj)
        {
            View.Close();
        }

        private void SaveCommandExecute(object obj)
        {
            _configuration.DataFolderPath = DataFolder;

            _configuration.Language = Language;

            View.Close();
        }

        private bool SaveCommandCanExecute(object obj)
        {
            return IsConfigurationModified;
        }        
    }
}