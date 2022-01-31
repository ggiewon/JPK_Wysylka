using System;
using System.ComponentModel;
using System.Configuration;
using JPK.Interfaces;
using JPK.Interfaces.Configuration;
using JPK_WysylkaXML.UI.Configuration.Exceptions;
using JPK_WysylkaXML.UI.Interfaces.Configuration;
using NLog;
using UnitSoftware.Common.Interfaces.Helpers;
using UnitSoftware.Common.Interfaces.Wrappers.IO;
using UnitSoftware.Common.Interfaces.Wrappers.System;

namespace JPK_WysylkaXML.UI.Configuration
{
    /// <summary>
    /// Application configuration manager class for load and save configuration
    /// </summary>
    public class AppConfigurationManager : IAppConfigurationManager
    {
        public IConfiguration Configuration
        {
            get { return _configuration ??= ReadConfiguration(_environmentWrapper.UserName); }
        }

        private readonly string _configFilePath;

        private readonly IPathWrapper _pathWrapper;

        private readonly IEnvironmentWrapper _environmentWrapper;

        private IConfiguration _configuration;

        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Main constructor for configuration manager
        /// </summary>        
        /// <param name="pathWrapper">Not null Path wrapper</param>
        /// <param name="environmentWrapper"></param>
        /// <param name="configFilenameProvider"></param>
        /// <param name="applicationConfigPath"></param>
        public AppConfigurationManager(IPathWrapper pathWrapper, IEnvironmentWrapper environmentWrapper,
            IConfigFilenameProvider configFilenameProvider, string applicationConfigPath)
        {
            if (configFilenameProvider == null) throw new ArgumentNullException(nameof(configFilenameProvider));

            _pathWrapper = pathWrapper ?? throw new ArgumentNullException(nameof(pathWrapper));
            _environmentWrapper = environmentWrapper ?? throw new ArgumentNullException(nameof(environmentWrapper));

            Logger.Debug("ApplicationConfigPath: {0}", applicationConfigPath);

            _configFilePath = pathWrapper.Combine(applicationConfigPath, configFilenameProvider.GetDefaultConfigFilename());
        }

        /// <summary>
        /// See <see cref="IAppConfigurationManager"/> interface documentation
        /// </summary>
        public IConfiguration ReadConfiguration(string username = null)
        {
            try
            {
                var config = OpenConfigFile();

                var productionServerUrl = ReadSettingsProperty(config.AppSettings.Settings, AppConsts.AppConfigurationPropertyProductionServerUrl);
                var testServerUrl = ReadSettingsProperty(config.AppSettings.Settings, AppConsts.AppConfigurationPropertyTestServerUrl);

                if (string.IsNullOrEmpty(testServerUrl) || !testServerUrl.ToUpper().Contains("TEST"))
                    throw new InvalidConfigurationException(string.Format("{0} nie jest adresem serwera testowego", testServerUrl));

                var updateUrl = ReadSettingsProperty(config.AppSettings.Settings, AppConsts.AppConfigurationPropertyUpdateUrl);
                
                var isAutoupdateEnabled = ReadSettingsProperty(config.AppSettings.Settings, AppConsts.AppConfigurationPropertyIsAutoupdateEnabled, false);

                var testCertificateFilename = ReadSettingsProperty(config.AppSettings.Settings, AppConsts.AppConfigurationPropertyTestEncryptionCertificateFilename);
                var productionCertificateFilename = ReadSettingsProperty(config.AppSettings.Settings, AppConsts.AppConfigurationPropertyProductionEncryptionCertificateFilename);

                var defaultDataFolder = ReadSettingsProperty(config.AppSettings.Settings, AppConsts.AppConfigurationPropertyDataFolderPath);

                string dataFolderPath = !string.IsNullOrEmpty(Properties.Settings.Default.DataFolderPath) ? Properties.Settings.Default.DataFolderPath : defaultDataFolder;

                var serverTypeStr = string.IsNullOrEmpty(Properties.Settings.Default.ServerType) ? EnumHelper<ServerType>.GetStringValue(ServerType.Test) : Properties.Settings.Default.ServerType;

                var language = string.IsNullOrEmpty(Properties.Settings.Default.Language) ? "pl" : Properties.Settings.Default.Language;

                var logsFolderPath = _pathWrapper.Combine(dataFolderPath, "Logs");

                Logger.Debug("Application configuration: {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", productionServerUrl, testServerUrl, updateUrl, testCertificateFilename, productionCertificateFilename, isAutoupdateEnabled, dataFolderPath, serverTypeStr);

                var serverType = EnumHelper<ServerType>.FromStringValue(serverTypeStr);

                if (_configuration != null)
                    _configuration.PropertyChanged -= OnPropertyChanged;

                _configuration = new Configuration(isAutoupdateEnabled, updateUrl, testCertificateFilename, productionCertificateFilename, serverType, testServerUrl, productionServerUrl, dataFolderPath, logsFolderPath, language);

                _configuration.PropertyChanged += OnPropertyChanged;

                return _configuration;
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);

                throw;
            }
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Properties.Settings.Default.ServerType = EnumHelper<ServerType>.GetStringValue(_configuration.SelectedServer);
            Properties.Settings.Default.DataFolderPath = _configuration.DataFolderPath;
            Properties.Settings.Default.Language = _configuration.Language;

            Properties.Settings.Default.Save();
        }

        private System.Configuration.Configuration OpenConfigFile()
        {
            ExeConfigurationFileMap filemap = new()
            {
                ExeConfigFilename = _configFilePath,
            };

            ConfigurationUserLevel configLvl = ConfigurationUserLevel.None;


            return ConfigurationManager.OpenMappedExeConfiguration(filemap, configLvl);
        }

        private static string ReadSettingsProperty(KeyValueConfigurationCollection appSettings, string propertyName)
        {
            return appSettings[propertyName] != null ? appSettings[propertyName].Value : null;
        }

        private static bool ReadSettingsProperty(KeyValueConfigurationCollection appSettings, string propertyName, bool defaultValue) 
        {
            return appSettings[propertyName] != null ? ((appSettings[propertyName].Value.ToUpper() == "TRUE") || (appSettings[propertyName].Value == "1")) : defaultValue;
        }
    }
}