using UnitSoftware.Helpers.Implementation.UnitTests;

namespace JPK_WysylkaXML.UI
{
    [UnitTestExclude("This in only const class")]
    public class AppConsts
    {
        public const string AppConfigurationPropertyProductionServerUrl = "ProductionServerUrl";

        public const string AppConfigurationPropertyTestServerUrl = "TestServerUrl";

        public const string AppConfigurationPropertyUpdateUrl = "UpdateUrl";

        public const string AppConfigurationPropertyIsAutoupdateEnabled = "IsAutoupdateEnabled";

        public const string AppConfigurationPropertyTestEncryptionCertificateFilename = "TestCertificate";

        public const string AppConfigurationPropertyProductionEncryptionCertificateFilename = "ProductionCertificate";

        public const string AppConfigurationPropertyServerType = "ServerType";

        public const string AppConfigurationPropertyDataFolderPath = "DataFolderPath";

        public const string AppConfigurationPropertyServerUrl = "ServerUrl";
    }
}