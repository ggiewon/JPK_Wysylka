using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Input;
using System.Windows.Threading;
using JPK.Interfaces;
using JPK.Interfaces.Configuration;
using JPK.Interfaces.Factories;
using JPK.Interfaces.Validators;
using JPK_WysylkaXML.EditXML.Interfaces;
using JPK_WysylkaXML.EditXML.Interfaces.Factories;
using JPK_WysylkaXML.License.Interfaces;
using JPK_WysylkaXML.UI.Components;
using JPK_WysylkaXML.UI.Components.Resources;
using JPK_WysylkaXML.UI.Interfaces.Commands.Factories;
using JPK_WysylkaXML.UI.Interfaces.ViewModel;
using JPK_WysylkaXML.UI.Interfaces.ViewModel.Factories;
using UnitSoftware.Common.Implementation.Commands;
using UnitSoftware.Common.Interfaces.Views;
using UnitSoftware.Common.Wpf.Implementation.Components.WpfMessageBox;
using UnitSoftware.Common.Wpf.Implementation.ViewModels;
using UnitSoftware.Common.Wpf.Interfaces.Components.WpfMessageBox;
using UnitSoftware.Common.Wpf.Interfaces.ViewModels;

namespace JPK_WysylkaXML.UI.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.    
    /// </summary>
    public class MainViewModel : ViewModelBase, IMainViewModel
    {
        private readonly IXmlValidator _xmlValidator;

        private readonly IConfiguration _configuration;

        private readonly IBaseView _mainWindow;

        private readonly IEditJpkFileViewsFactory _editJpkFileViewsFactory;

        private string _referenceNo;

        private bool _isValidationValidated;

        private bool _isValidationInProgress;

        private bool _isSendingInProgress;

        private readonly ICommand _internalSendCommand;

        private readonly IJpkVersionProvider _jpkVersionProvider;

        private readonly IJpkEditFileViewModelsFactory _editJpkFileViewModelsFactory;

        private readonly IWpfMessageBoxManager _wpfMessageBoxManager;

        public ICommand ValidateCommand { get; }

        public ICommand EditCommand { get; }

        public IOpenFileViewModel OpenFileViewModel { get; }

        public ICommand SendCommand { get; }

        public ICommand SendWithoutValidationCommand { get; }

        public ICommand CheckStatusCommand { get; }

        public ILogViewModel LogViewModel { get; }

        public bool IsProductionServerChecked => _configuration.SelectedServer == ServerType.Production;

        public bool IsTestServerChecked => _configuration.SelectedServer == ServerType.Test;

        public bool IsInputFileValid { get; private set; }

        public bool IsValidationValidated
        {
            get => _isValidationValidated;
            private set
            {
                if (_isValidationValidated != value)
                {
                    _isValidationValidated = value;

                    OnPropertyChanged(nameof(IsValidationValidated));
                }
            }
        }

        public string ReferenceNo
        {
            get => _referenceNo;
            set
            {
                if (value != _referenceNo)
                {
                    _referenceNo = value;

                    OnPropertyChanged(nameof(ReferenceNo));
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IXmlValidator xmlValidator, IJpkSenderFactory jpkSenderFactory, IConfiguration configuration, ILogViewModelFactory logViewModelFactory, 
            ICommandFactory commandFactory, IBaseView mainWindow, string applicationPath,
            IEditJpkFileViewsFactory editJpkFileViewsFactory, IJpkVersionProvider jpkVersionProvider, IJpkEditFileViewModelsFactory editJpkFileViewModelsFactory, 
            ILicenseManager licenseManager, IWpfMessageBoxManager wpfMessageBoxManager)
        {
            if (xmlValidator == null) throw new ArgumentNullException(nameof(xmlValidator));
            if (jpkSenderFactory == null) throw new ArgumentNullException(nameof(jpkSenderFactory));
            if (configuration == null) throw new ArgumentNullException(nameof(configuration));
            if (editJpkFileViewsFactory == null) throw new ArgumentNullException(nameof(editJpkFileViewsFactory));
            if (wpfMessageBoxManager == null) throw new ArgumentNullException(nameof(wpfMessageBoxManager));

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            var jpkSender = jpkSenderFactory.Create(AppDomain.CurrentDomain.BaseDirectory, configuration, licenseManager);

            OpenFileViewModel = new OpenFileViewModel("XML Files (*.xml)|*.xml|All files (*.*)|*.*", "*.xml");

            LogViewModel = logViewModelFactory.Create();

            ValidateCommand = new RelayCommand(ValidateCommandExecute, CanValidateCommandExecute);

            SendCommand = new RelayCommand(SendCommandExecute, CanSendCommandExecute);

            _internalSendCommand = commandFactory.CreateSendCommand(LogViewModel.AddLogMessage, CanSendCommandExecute, jpkSender, Dispatcher.CurrentDispatcher, configuration, mainWindow);

            SendWithoutValidationCommand = commandFactory.CreateSendWithoutValidationCommand(LogViewModel.AddLogMessage, CanSendWithoutValidationCommandExecute, jpkSender, Dispatcher.CurrentDispatcher, configuration, mainWindow);

            CheckStatusCommand = commandFactory.CreateCheckStatusCommand(LogViewModel.AddLogMessage, jpkSender, configuration);

            ExitCommand = commandFactory.CreateExitCommand();

            SelectServerCommand = new RelayCommand(SelectServerCommandExecute, SelectServerCommandCanExecute);

            OpenConfigurationCommand = commandFactory.CreateOpenConfigurationCommand(configuration, mainWindow);

            OpenHistoryCommand = commandFactory.CreateOpenHistoryCommand(configuration, mainWindow, Dispatcher.CurrentDispatcher, applicationPath, licenseManager);

            ShowVersionCommand = commandFactory.CreateShowVersionCommand(AppDomain.CurrentDomain, Assembly.GetEntryAssembly(), mainWindow);

            EditCommand = new RelayCommand(EditFileCommandExecute, EditFileCommandCanExecute);

            ClearUserDataCommand = new RelayCommand(ClearUserDataCommandExecute);

            _xmlValidator = xmlValidator;
            _configuration = configuration;
            _mainWindow = mainWindow;
            _editJpkFileViewsFactory = editJpkFileViewsFactory;
            _jpkVersionProvider = jpkVersionProvider;
            _editJpkFileViewModelsFactory = editJpkFileViewModelsFactory;
            _wpfMessageBoxManager = wpfMessageBoxManager;

            OpenFileViewModel.OnFilenameChanged += OnFilenameChanged;
        }

        private void ClearUserDataCommandExecute(object obj)
        {
            Properties.Settings.Default.PurchaseGridSettings = string.Empty;
            Properties.Settings.Default.SaleGridSettings = string.Empty;
            Properties.Settings.Default.Save();

            _wpfMessageBoxManager.ShowDialog(ResourceTranslator.GetString("MainView_UserDataTitle"), ResourceTranslator.GetString("MainView_ClearEditSettingsDataMessage"), string.Empty, WpfMessageBoxImage.Information, _mainWindow);
        }

        private bool EditFileCommandCanExecute(object obj)
        {
            return File.Exists(OpenFileViewModel.FilePath);
        }

        private void EditFileCommandExecute(object obj)
        {
            if (File.Exists(OpenFileViewModel.FilePath))
                try
                {
                    var jpkType = _jpkVersionProvider.GetVersion(OpenFileViewModel.FilePath);

                    var view = _editJpkFileViewsFactory.Create(jpkType, _mainWindow.GetOwnerWindow());

                    var viewmodel = _editJpkFileViewModelsFactory.Create(jpkType, OpenFileViewModel.FilePath, view);

                    view.DataContext = viewmodel;
                    
                    view.ShowDialog();

                    IsValidationValidated = false;
                }
                catch (Exception e)
                {
                    LogViewModel.AddLogMessage(string.Format(ResourceTranslator.GetString("MainView_OpenFileErrorMessage") , e.Message));
                }
        }

        private void SendCommandExecute(object path)
        {

            IsSendingInProgress = true;

            try
            {
                _internalSendCommand.Execute((string)path);
            }
            finally
            {
                IsSendingInProgress = false;
            }
        }

        private void SelectServerCommandExecute(object obj)
        {
            _configuration.SelectedServer = (ServerType)obj;

            OnPropertyChanged(nameof(IsProductionServerChecked));
            OnPropertyChanged(nameof(IsTestServerChecked));
        }

        private bool SelectServerCommandCanExecute(object arg)
        {
            return true;
        }

        private bool CanSendWithoutValidationCommandExecute()
        {
            return (!string.IsNullOrEmpty(OpenFileViewModel.FilePath)) && !IsSendingInProgress && !IsValidationInProgress;
        }

        private void OnFilenameChanged(string filename)
        {
            IsValidationValidated = false;
        }

        private bool CanSendCommandExecute(object filename)
        {

            return (!string.IsNullOrEmpty((string)filename)) && IsInputFileValid && !IsSendingInProgress && !IsValidationInProgress && IsValidationValidated;
        }

        public bool IsValidationInProgress
        {
            get { return _isValidationInProgress; }
            set
            {
                if (_isValidationInProgress != value)
                {
                    _isValidationInProgress = value;
                    OnPropertyChanged(nameof(IsValidationInProgress));
                }
            }
        }

        public bool IsSendingInProgress
        {
            get { return _isSendingInProgress; }
            set
            {
                if (_isSendingInProgress != value)
                {
                    _isSendingInProgress = value;
                    OnPropertyChanged(nameof(IsSendingInProgress));
                }
            }
        }

        public ICommand ExitCommand { get; }

        public ICommand SelectServerCommand { get;  }

        public ICommand OpenConfigurationCommand { get; }

        public ICommand ClearUserDataCommand { get; }

        public ICommand OpenHistoryCommand { get; }

        public ICommand ShowVersionCommand { get; }

        private bool CanValidateCommandExecute(object obj)
        {
            return !string.IsNullOrEmpty(OpenFileViewModel.FilePath) && !IsValidationInProgress && !IsValidationValidated;
        }

        private async void ValidateCommandExecute(object obj)
        {
            LogViewModel.AddLogMessage(ResourceTranslator.GetString("MainView_ValidationStartedTxt"));

            IsValidationInProgress = true;

            IsInputFileValid = await _xmlValidator.ValidateAsync(OpenFileViewModel.FilePath, LogViewModel.AddLogMessage);

            LogViewModel.AddLogMessage(IsInputFileValid ? ResourceTranslator.GetString("MainView_ValidationEndedOkTxt") : ResourceTranslator.GetString("MainView_ValidationEndedErrorsTxt"));

            IsValidationInProgress = false;

            IsValidationValidated = IsInputFileValid;

            CommandManager.InvalidateRequerySuggested();
        }
    }
}