using System.ComponentModel;

namespace JPK.Interfaces.Configuration
{
    public interface IConfiguration : INotifyPropertyChanged
    {
        bool IsAutoupdateEnabled { get; }

        string UpdaterCastUrl { get; }

        string TestServerUrl { get; }

        string ProductionServerUrl { get; }

        string TestEncryptionCertificateFilename { get; }

        string ProductionEncryptionCertificateFilename { get; }

        ServerType SelectedServer { get; set; }
        
        string DataFolderPath { get; set; }

        string LogsFolderPath { get; set; }

        string Language { get; set; }
    }
}