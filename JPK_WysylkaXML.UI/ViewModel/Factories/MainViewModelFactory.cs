using System;
using JPK.Interfaces.Configuration;
using JPK.Interfaces.Factories;
using JPK.Interfaces.Validators;
using JPK_WysylkaXML.EditXML.Interfaces;
using JPK_WysylkaXML.EditXML.Interfaces.Factories;
using JPK_WysylkaXML.License.Interfaces;
using JPK_WysylkaXML.UI.Interfaces.Commands.Factories;
using JPK_WysylkaXML.UI.Interfaces.ViewModel;
using JPK_WysylkaXML.UI.Interfaces.ViewModel.Factories;
using UnitSoftware.Common.Interfaces.Views;
using UnitSoftware.Common.Wpf.Interfaces.Components.WpfMessageBox;

namespace JPK_WysylkaXML.UI.ViewModel.Factories
{
    public class MainViewModelFactory : IMainViewModelFactory
    {
        private readonly IXmlValidator _xmlValidator;
        private readonly IJpkSenderFactory _jpkSenderFactory;
        private readonly ILogViewModelFactory _logViewModelFactory;
        private readonly ICommandFactory _commandFactory;
        private readonly IEditJpkFileViewsFactory _editJpkFileViewsFactory;
        private readonly IJpkVersionProvider _jpkVersionProvider;
        private readonly IJpkEditFileViewModelsFactory _editJpkFileViewModelsFactory;
        private readonly IWpfMessageBoxManager _wpfMessageBoxManager;

        public MainViewModelFactory(IXmlValidator xmlValidator, IJpkSenderFactory jpkSenderFactory, ILogViewModelFactory logViewModelFactory,
            ICommandFactory commandFactory, 
            IEditJpkFileViewsFactory editJpkFileViewsFactory, IJpkVersionProvider jpkVersionProvider, IJpkEditFileViewModelsFactory editJpkFileViewModelsFactory, IWpfMessageBoxManager wpfMessageBoxManager)
        {
            _xmlValidator = xmlValidator ?? throw new ArgumentNullException(nameof(xmlValidator));
            _jpkSenderFactory = jpkSenderFactory ?? throw new ArgumentNullException(nameof(jpkSenderFactory));

            _logViewModelFactory = logViewModelFactory ?? throw new ArgumentNullException(nameof(logViewModelFactory));
            _commandFactory = commandFactory ?? throw new ArgumentNullException(nameof(commandFactory));
            _editJpkFileViewsFactory = editJpkFileViewsFactory ?? throw new ArgumentNullException(nameof(editJpkFileViewsFactory));
            _jpkVersionProvider = jpkVersionProvider ?? throw new ArgumentNullException(nameof(jpkVersionProvider));
            _editJpkFileViewModelsFactory = editJpkFileViewModelsFactory ?? throw new ArgumentNullException(nameof(editJpkFileViewModelsFactory));
            _wpfMessageBoxManager = wpfMessageBoxManager ?? throw new ArgumentNullException(nameof(wpfMessageBoxManager));
        }

        public IMainViewModel Create(IBaseView mainWindow, string applicationPath, IConfiguration configuration, ILicenseManager licenseManager)
        {
            return new MainViewModel(_xmlValidator, _jpkSenderFactory, configuration, _logViewModelFactory, _commandFactory, mainWindow, applicationPath, _editJpkFileViewsFactory, _jpkVersionProvider, _editJpkFileViewModelsFactory, licenseManager, _wpfMessageBoxManager);
        }
    }
}