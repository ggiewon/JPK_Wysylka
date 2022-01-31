namespace JPK_WysylkaXML.UI.Interfaces.Providers.Configuration
{
    public interface IDefaultConfigurationValueProvider
    {
        string GetValueForDataFolder(string defaultDataFolder);

        string GetValueForServerType(string serverUrl);

        string GetValueForProductionServerUrl();
        
        string GetValueForTestServerUrl();
    }
}