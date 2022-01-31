using System.ComponentModel;
using System.Runtime.CompilerServices;
using JPK.Interfaces;
using JPK.Interfaces.Configuration;

namespace JPK_WysylkaXML.UI.Configuration
{
    public class Configuration : IConfiguration
    {
        private string _logsFolderPath;

        private string _dataFolderPath;

        private string _language;

        private ServerType _selectedServer;

        public bool IsAutoupdateEnabled { get; private set; }

        public string UpdaterCastUrl { get; private set; }

        public string TestServerUrl { get; private set; }

        public string ProductionServerUrl { get; private set; }

        public string TestEncryptionCertificateFilename { get; private set; }

        public string ProductionEncryptionCertificateFilename { get; private set; }

        public ServerType SelectedServer
        {
            get { return _selectedServer; }
            set
            {
                if (_selectedServer != value)
                {
                    _selectedServer = value;
                    OnPropertyChanged();
                }
            }
        }

        public string DataFolderPath
        {
            get { return _dataFolderPath; }
            set
            {
                if (_dataFolderPath != value)
                {
                    _dataFolderPath = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Language
        {
            get { return _language; }
            set
            {
                if (_language != value)
                {
                    _language = value;
                    OnPropertyChanged();
                }
            }
        }

        public string LogsFolderPath
        {
            get { return _logsFolderPath ; }
            set
            {
                if (_logsFolderPath != value)
                {
                    _logsFolderPath = value;
                    OnPropertyChanged();
                }
            }
        }

        public Configuration(bool isAutoupdateEnabled, string updaterCastUrl, string testEncryptionCertificateFilename, string productionEncryptionCertificateFilename, ServerType selectedServer, 
            string testServer, string productionServer, string dataFolderPath, string logsFolderPath, string language)
        {
            _logsFolderPath = logsFolderPath;
            DataFolderPath = dataFolderPath;
            SelectedServer = selectedServer;

            IsAutoupdateEnabled = isAutoupdateEnabled;
            UpdaterCastUrl = updaterCastUrl;

            TestEncryptionCertificateFilename = testEncryptionCertificateFilename;
            ProductionEncryptionCertificateFilename = productionEncryptionCertificateFilename;

            ProductionServerUrl = productionServer;
            TestServerUrl = testServer;

            Language = language;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;

            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}