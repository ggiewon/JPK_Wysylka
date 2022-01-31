using System;
using JPK.Interfaces;
using JPK_WysylkaXML.UI.Interfaces.Providers.Configuration;
using UnitSoftware.Common.Interfaces.Helpers;
using UnitSoftware.Common.Interfaces.Wrappers.IO;

namespace JPK_WysylkaXML.UI.Providers.Configuration
{
    public class DefaultConfigurationValueProvider : IDefaultConfigurationValueProvider
    {
        private readonly IPathWrapper _pathWrapper;

        public DefaultConfigurationValueProvider(IPathWrapper pathWrapper)
        {
            if (pathWrapper == null) throw new ArgumentNullException("pathWrapper");

            _pathWrapper = pathWrapper;
        }

        public string GetValueForDataFolder(string defaultDataFolder)
        {
            if (string.IsNullOrEmpty(defaultDataFolder) || defaultDataFolder.Equals("[DefaultDataFolder]"))
                return _pathWrapper.GetFullPath("Data");

            return defaultDataFolder;
        }

        public string GetValueForServerType(string serverUrl)
        {
            if (serverUrl == "https://e-dokumenty.mf.gov.pl")
                return EnumHelper<ServerType>.GetStringValue(ServerType.Production);

            return EnumHelper<ServerType>.GetStringValue(ServerType.Test);
        }

        public string GetValueForProductionServerUrl()
        {
            return "https://e-dokumenty.mf.gov.pl";
        }

        public string GetValueForTestServerUrl()
        {
            return "https://test-e-dokumenty.mf.gov.pl";
        }
    }
}