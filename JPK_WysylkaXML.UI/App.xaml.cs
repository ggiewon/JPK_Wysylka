using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Windows;
using AutoUpdaterDotNET;
using JPK.Cryptography;
using JPK.Exceptions;
using JPK.Factories;
using JPK.Files;
using JPK.Files.Providers;
using JPK.Helpers.Azure.Factories;
using JPK.Helpers.Cryptography;
using JPK.Helpers.Http;
using JPK.Helpers.Providers;
using JPK.Helpers.Requests.Factories;
using JPK.Helpers.Responses.Factories;
using JPK.Helpers.Xml;
using JPK.Interfaces;
using JPK.Interfaces.Configuration;
using JPK.Interfaces.Cryptography;
using JPK.Interfaces.Exceptions;
using JPK.Interfaces.Factories;
using JPK.Interfaces.Files;
using JPK.Interfaces.Files.Factories;
using JPK.Interfaces.Files.Providers;
using JPK.Interfaces.Helpers;
using JPK.Interfaces.Helpers.Azure.Factories;
using JPK.Interfaces.Helpers.Cryptography;
using JPK.Interfaces.Helpers.Http;
using JPK.Interfaces.Helpers.Providers;
using JPK.Interfaces.Helpers.Requests.Factories;
using JPK.Interfaces.Helpers.Responses.Factories;
using JPK.Interfaces.Helpers.Xml;
using JPK.Interfaces.Providers;
using JPK.Interfaces.Providers.Factories;
using JPK.Interfaces.Serializers;
using JPK.Interfaces.Validators;
using JPK.Interfaces.Xml;
using JPK.Providers;
using JPK.Providers.Factories;
using JPK.Serializers;
using JPK.Validators;
using JPK.Xml;
using JPK_Wysylka.DB.Implementation.BO.Factories;
using JPK_Wysylka.DB.Implementation.Context.Factory;
using JPK_Wysylka.DB.Implementation.Services;
using JPK_Wysylka.DB.Interfaces.BO.Factories;
using JPK_Wysylka.DB.Interfaces.Services;
using JPK_WysylkaXML.EditXML.Interfaces;
using JPK_WysylkaXML.EditXML.Interfaces.Factories;
using JPK_WysylkaXML.EditXML.Providers;
using JPK_WysylkaXML.EditXML.Views.Factories;
using JPK_WysylkaXML.License;
using JPK_WysylkaXML.License.Helpers;
using JPK_WysylkaXML.License.Interfaces;
using JPK_WysylkaXML.License.Interfaces.Helpers;
using JPK_WysylkaXML.License.Interfaces.Validators;
using JPK_WysylkaXML.License.Managers;
using JPK_WysylkaXML.License.Validators;
using JPK_WysylkaXML.License.Validators.Factories;
using JPK_WysylkaXML.UI.Commands.Factories;
using JPK_WysylkaXML.UI.Commands.RequestView.Factories;
using JPK_WysylkaXML.UI.Components;
using JPK_WysylkaXML.UI.Components.Resources;
using JPK_WysylkaXML.UI.Configuration;
using JPK_WysylkaXML.UI.Configuration.Providers;
using JPK_WysylkaXML.UI.Interfaces.Commands.Factories;
using JPK_WysylkaXML.UI.Interfaces.Commands.RequestView.Factories;
using JPK_WysylkaXML.UI.Interfaces.Configuration;
using JPK_WysylkaXML.UI.Interfaces.Configuration.Factories;
using JPK_WysylkaXML.UI.Interfaces.Providers;
using JPK_WysylkaXML.UI.Interfaces.Providers.Configuration;
using JPK_WysylkaXML.UI.Interfaces.ViewModel;
using JPK_WysylkaXML.UI.Interfaces.ViewModel.Factories;
using JPK_WysylkaXML.UI.Interfaces.ViewModel.RequestHistory.Factories;
using JPK_WysylkaXML.UI.Interfaces.ViewModel.RequestHistory.Factory;
using JPK_WysylkaXML.UI.Providers;
using JPK_WysylkaXML.UI.Providers.Configuration;
using JPK_WysylkaXML.UI.ViewModel;
using JPK_WysylkaXML.UI.ViewModel.Factories;
using JPK_WysylkaXML.UI.ViewModel.Log.Factories;
using JPK_WysylkaXML.UI.ViewModel.RequestHistory.Factories;
using JPK_WysylkaXML.UI.Views;
using Microsoft.Extensions.DependencyInjection;
using NLog;
using UnitSoftware.Common.Implementation.Generators;
using UnitSoftware.Common.Implementation.Helpers;
using UnitSoftware.Common.Implementation.Streams.Factories;
using UnitSoftware.Common.Implementation.Wrappers.IO;
using UnitSoftware.Common.Implementation.Wrappers.IO.Factories;
using UnitSoftware.Common.Implementation.Wrappers.System;
using UnitSoftware.Common.Implementation.Wrappers.System.Diagnostics;
using UnitSoftware.Common.Implementation.Wrappers.System.Windows;
using UnitSoftware.Common.Interfaces.Generator;
using UnitSoftware.Common.Interfaces.Helpers;
using UnitSoftware.Common.Interfaces.Providers;
using UnitSoftware.Common.Interfaces.Streams.Factories;
using UnitSoftware.Common.Interfaces.Wrappers.IO;
using UnitSoftware.Common.Interfaces.Wrappers.IO.Factories;
using UnitSoftware.Common.Interfaces.Wrappers.System;
using UnitSoftware.Common.Interfaces.Wrappers.System.Diagnostics;
using UnitSoftware.Common.Interfaces.Wrappers.System.Windows;
using UnitSoftware.Common.Wpf.Implementation.Components.WpfMessageBox;
using UnitSoftware.Common.Wpf.Implementation.Components.WpfMessageBox.Factories;
using UnitSoftware.Common.Wpf.Implementation.Extensions;
using UnitSoftware.Common.Wpf.Interfaces.Components.WpfMessageBox;
using UnitSoftware.Common.Wpf.Interfaces.Extensions;
using UnitSoftware.XmlTypes.Factories;
using UnitSoftware.XmlTypes.Helpers;
using UnitSoftware.XmlTypes.Interfaces;
using UnitSoftware.XmlTypes.Interfaces.Upo;
using UnitSoftware.XmlTypes.Upo.Factories;

namespace JPK_WysylkaXML.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        private readonly ServiceProvider _serviceProvider;

        static App()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            PathWrapper = new PathWrapper();

            FileWrapper = new FileWrapper();
        }

        public App()
        {
            ServiceCollection services = new();
            
            ConfigureServices(services);

            _serviceProvider = services.BuildServiceProvider();
        }

        private static readonly IEnvironmentWrapper EnvironmentWrapper = new EnvironmentWrapper();

        private static readonly IUnhandledExceptionHandler UnhandledExceptionHandler = new UnhandledExceptionHandler(EnvironmentWrapper);

        private static readonly IPathWrapper PathWrapper;

        private static readonly IFileWrapper FileWrapper;

        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();

        private static readonly IDirectoryWrapper DirectoryWrapper = new DirectoryWrapper();

        private static string GetApplicationPath()
        {
            Logger.Debug($"Location: {AppContext.BaseDirectory}");

            return PathWrapper.GetDirectoryName(AppContext.BaseDirectory);
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IJpkVersionProvider, JpkVersionProvider>();
            services.AddSingleton<IEditJpkFileViewsFactory, EditJpkFileViewsFactory>();
            services.AddSingleton<IJpkEditFileViewModelsFactory, JpkEditFileViewModelsFactory>();
            
            services.AddSingleton<IFormVersionFinder,FormVersionFinder>();
            
            services.AddSingleton<IXsdFilenameProvider, XsdFilenameProvider>();
            services.AddSingleton<ISystemCodeFinder, SystemCodeFinder>();
            services.AddSingleton<ISchemaVersionFinder, SchemaVersionFinder>();
            services.AddSingleton<IFormCodeFinder, FormCodeFinder>();
            services.AddSingleton<IXmlPropertyReader, XmlPropertyReader>();
            services.AddSingleton<ILicenseLoader, LicenseLoader>();
            services.AddSingleton<INipFinder, NipFinder>();
            services.AddSingleton<ILicenseValidator, LicenseValidator>();
            services.AddSingleton<ILicenseHashCalculator, LicenseHashCalculator>();
            services.AddSingleton<IUpoPathProvider, UpoPathProvider>();            
            services.AddSingleton<IAppConfigurationManager, AppConfigurationManager>();

            services.AddSingleton<IConfigFilenameProvider, ConfigFilenameProvider>();
            services.AddSingleton<IDefaultConfigurationValueProvider, DefaultConfigurationValueProvider>();
            services.AddSingleton<ICommandFactory, CommandFactory>();
            services.AddSingleton<IConfigurationViewModel, ConfigurationViewModel>();
            services.AddSingleton<ILogViewModelFactory, LogViewModelFactory>();
            services.AddSingleton<IInitUploadSerializer, InitUploadSerializer>();
            services.AddSingleton<IZipFilenameProvider, ZipFilenameProvider>();
            services.AddSingleton<IHttpHelper, HttpHelper>();
            services.AddSingleton<IFilenameProviderFactory, FilenameProviderFactory>();
            services.AddSingleton<IXmlValidator, XmlValidator>();
            services.AddSingleton<IJpkSenderFactory, JpkSenderFactory>();
            services.AddSingleton<IRequestsFactory, RequestsFactory>();
            services.AddSingleton<IResponseFactory, ResponseFactory>();
            services.AddSingleton<IHttpAddressProvider, HttpAddressProvider>();
            services.AddSingleton<IShaCalculator, ShaCalculator>();
            services.AddSingleton<IAzureSenderFactory, AzureSenderFactory>();
            services.AddSingleton<IZipFilenameProviderFactory, ZipFilenameProviderFactory>();
            services.AddSingleton<IFilePreparer, FilePreparer>();
            services.AddSingleton<IReferenceNumberArchiver, ReferenceNumberArchiver>();
            services.AddSingleton<ICertificateFilenameProvider, CertificateFilenameProvider>();
            services.AddSingleton<IRequestContextFactory, RequestContextFactory>();
            services.AddSingleton<IRequestsViewCommandsFactory, RequestsViewCommandsFactory>();
            services.AddSingleton<IRequestViewModelFactory, RequestViewModelFactory>();
            services.AddSingleton<IFilterViewModelFactory, FilterViewModelFactory>();
            services.AddSingleton<IMainViewModel, MainViewModel>();

            services.AddSingleton<IRequestFactory, RequestFactory>();
            services.AddSingleton<IRequestUpdater, RequestUpdater>();
            services.AddSingleton<IUpoSaver, UpoDatabaseSaver>();
            services.AddSingleton<IJpkSigner, JpkSigner>();
            services.AddSingleton<IStatusProvider, StatusProvider>();

            services.AddSingleton<IFileInfoFactory, FileInfoFactory>();
            services.AddSingleton<ISystemDateTime, SystemDateTime>();
            services.AddSingleton<IFileWrapper, FileWrapper>();
            services.AddSingleton<IEnvironmentWrapper, EnvironmentWrapper>();
            services.AddSingleton<IProcessWrapper, ProcessWrapper>();
            services.AddSingleton<IPathWrapper, PathWrapper>();
            services.AddSingleton<IDirectoryWrapper, DirectoryWrapper>();
            services.AddSingleton<IClipboardWrapper, ClipboardWrapper>();
            services.AddSingleton<IWaitCursorExtension, WaitCursorExtensionWrapper>();
            services.AddSingleton<IWindowsIdentityWrapper, UnitSoftware.Common.Implementation.Wrappers.System.WindowsIdentityWrapper>();
            services.AddSingleton<IZipHelper, ZipHelper>();

            services.AddSingleton<ITextProvider, TextProvider>();

            var wpfMessageBoxManagerFactory = new WpfMessageBoxManagerFactory();

            var wpfMessageBoxManager = wpfMessageBoxManagerFactory.Create(GetApplicationIcon());

            services.AddSingleton<IWpfMessageBoxManager>(wpfMessageBoxManager);

            services.AddSingleton<IRestClientFactory, RestClientFactory>();
            services.AddSingleton<IStreamFactory, StreamFactory>();
            services.AddSingleton<IXmlHelper, XmlHelper>();
            services.AddSingleton<IXmlFactory, XmlFactory>();
            services.AddSingleton<IUpoFactory, UpoFactory>();
            services.AddSingleton<IUrzadSkarbowyHelper, UrzadSkarbowyHelper>();
            services.AddSingleton<IUpoGenerator, UpoGenerator>();
            services.AddSingleton<ISettingsManager, SettingsManager>();

            services.AddSingleton<IAppConfigurationManagerFactory, AppConfigurationManagerFactory>();
            services.AddSingleton<IReferenceNumberArchiverFactory, ReferenceNumberArchiverFactory>();
            services.AddSingleton<IFilePreparerFactory, FilePreparerFactory>();

            services.AddSingleton<IUpoPathProviderdFactory, UpoPathProviderdFactory>();

            services.AddSingleton<ILicenseValidatorFactory, LicenseValidatorFactory>();
            services.AddSingleton<IXmlPropertyReaderFactory, XmlPropertyReaderFactory>();

            services.AddSingleton<IMainViewModelFactory, MainViewModelFactory>();
            services.AddSingleton<IRequestServiceFactory, RequestServiceFactory>();
            services.AddSingleton<IUpoSaverFactory, UpoSaverFactory>();

            services.AddSingleton<IShaCalculator, ShaCalculator>();
        }

        /// <summary>
        /// Main method for starting application
        /// </summary>
        private void OnStartup(object sender, StartupEventArgs e)
        {
            var ci = new CultureInfo("pl");
            
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;

            UI.Properties.Settings.Default.Upgrade();
            UI.Properties.Settings.Default.Save();
            
            AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionHandler.HandleUnhandledException;

            Dispatcher.UnhandledException += UnhandledExceptionHandler.HandleDispatherUnhandledException;
            
            var configurationManagerFactory = _serviceProvider.GetService<IAppConfigurationManagerFactory>();

            var configurationManager = configurationManagerFactory.Create(GetApplicationPath());

            var configuration = configurationManager.Configuration;

            ResourceTranslator.SetLanguage(configuration.Language);

            var wpfMessageBoxManager = _serviceProvider.GetService<IWpfMessageBoxManager>();
            
            try
            {
                var mainView = new MainWindow();

                try
                {
                    DirectoryWrapper.CreateDirectory(configuration.DataFolderPath);
                    
                    var tmpFilename = PathWrapper.Combine(configuration.DataFolderPath, "tmpFile.txt");

                    using (FileWrapper.Create(tmpFilename))
                    { }

                    if (FileWrapper.Exists(tmpFilename))
                        FileWrapper.Delete(tmpFilename);
                }
                catch (Exception)
                {
                    wpfMessageBoxManager.ShowDialogWithIcon(ResourceTranslator.GetString("Common_WritePermissionsTitle"), ResourceTranslator.GetString("Common_WritePermissionsMessage"), string.Format(ResourceTranslator.GetString("Common_WritePermissionsDetails"), configuration.DataFolderPath), WpfMessageBoxImage.Error);

                    Environment.Exit(1);
                }

                if (!DirectoryWrapper.Exists(configuration.LogsFolderPath))
                {
                    try
                    {
                        DirectoryWrapper.CreateDirectory(configuration.LogsFolderPath);
                    }
                    catch (Exception)
                    {
                        WpfMessageBox.Show(ResourceTranslator.GetString("Common_CreateFolderTitle"), ResourceTranslator.GetString("Common_CreateLogFolderMessage"), string.Format(ResourceTranslator.GetString("Common_CreateLogFolderDetails"), configuration.LogsFolderPath), WpfMessageBoxImage.Error, GetApplicationIcon(), true);

                        Environment.Exit(1);
                    }
                }

                var licenseFolder = PathWrapper.Combine(GetApplicationPath(), LicenseConsts.LicenseFolder);

                if (!DirectoryWrapper.Exists(licenseFolder))
                {
                    try
                    {
                        DirectoryWrapper.CreateDirectory(licenseFolder);
                    }
                    catch (Exception)
                    {
                        WpfMessageBox.Show(ResourceTranslator.GetString("Common_CreateFolderTitle"), ResourceTranslator.GetString("Common_CreateLicenseFolderMessage"), string.Format(ResourceTranslator.GetString("Common_CreateLicenseFolderDetails"), licenseFolder), WpfMessageBoxImage.Error, GetApplicationIcon(), true);
                        Environment.Exit(1);
                    }
                }

                var licenseManager = CreateLicenseManager(licenseFolder);

                if (licenseManager.IsInDemoMode())
                    WpfMessageBox.Show(ResourceTranslator.GetString("Common_MissingLicenseTitle"), ResourceTranslator.GetString("Common_MissingLicenseMessage"), ResourceTranslator.GetString("Common_MissingLicenseDetails"),
                        WpfMessageBoxImage.Information, GetApplicationIcon(), true);

                IMainViewModelFactory mainViewModelfactory = _serviceProvider.GetService<IMainViewModelFactory>();

                var mainViewModel = mainViewModelfactory.Create(mainView, GetApplicationPath(), configuration, licenseManager);
                
                if (e.Args.Length > 0)
                    mainViewModel.OpenFileViewModel.FilePath = e.Args[0];
                
                if (configuration.IsAutoupdateEnabled)
                {
                    AutoUpdater.CurrentCulture = CultureInfo.CreateSpecificCulture("pl");
                    AutoUpdater.Start(configuration.UpdaterCastUrl);
                }

                mainView.DataContext = mainViewModel;

                mainView.Show();
            }
            catch (Exception ex)
            {
                WpfMessageBox.Show(ResourceTranslator.GetString("Common_ApplicationErrorTitle"), ResourceTranslator.GetString("Common_ApplicationErrorMessage"), string.Format(ResourceTranslator.GetString("Common_ApplicationErrorDetails"), ex.Message), WpfMessageBoxImage.Error, GetApplicationIcon(), true);
                Environment.Exit(2);
            }            
        }

        private LicenseManager CreateLicenseManager(string path)
        {
            var factory = _serviceProvider.GetService<ILicenseValidatorFactory>();

            var validator = factory.Create(LicenseConsts.JPK_WysylkaXMLType);

            var licenseManager = new LicenseManager(_serviceProvider.GetService<IFileWrapper>(), _serviceProvider.GetService<ILicenseLoader>(), validator, _serviceProvider.GetService<IDirectoryWrapper>(), _serviceProvider.GetService<IPathWrapper>());

            licenseManager.LoadLicenseFromDictionary(path);

            return licenseManager;
        }

        private void OnExit(object sender, ExitEventArgs e)
        {
            
        }

        private static Icon GetApplicationIcon()
        {
            var iconStream = AsStream(Assembly.GetExecutingAssembly(), "JPK_WysylkaXML.UI.AppIcon.ico");

            var icon = new Icon(iconStream);

            return icon;
        }

        private static Stream AsStream(Assembly assembly, string name)
        {
            var resources = assembly.GetManifestResourceNames()
                .Where(x => x.EndsWith(name))
                .ToList();

            if (resources.Count == 0)
                throw new ArgumentException($"Embedded resource with name '{name}' cannot be found in assembly '{assembly.FullName}");

            if (resources.Count > 1)
                throw new ArgumentException($"Multiple resource with name '{name}' found in assembly '{assembly.FullName}");

            var fullName = resources[0];

            return assembly.GetManifestResourceStream(fullName);
        }
    }
}
