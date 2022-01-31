using System;
using JPK.Interfaces.Configuration;
using JPK_WysylkaXML.UI.Configuration;
using UnitSoftware.Common.Interfaces.Wrappers.IO;
using UnitSoftware.Common.Interfaces.Wrappers.System;

namespace JPK_WysylkaXML.UI.Interfaces.Configuration.Factories
{
    public interface IAppConfigurationManagerFactory
    {
        IAppConfigurationManager Create(string applicationConfigPath);
    }

    class AppConfigurationManagerFactory : IAppConfigurationManagerFactory
    {
        private readonly IPathWrapper _pathWrapper;
        private readonly IEnvironmentWrapper _environmentWrapper;
        private readonly IConfigFilenameProvider _configFilenameProvider;

        public AppConfigurationManagerFactory(IPathWrapper pathWrapper, IEnvironmentWrapper environmentWrapper, IConfigFilenameProvider configFilenameProvider)
        {
            _pathWrapper = pathWrapper ?? throw new ArgumentNullException(nameof(pathWrapper));
            _environmentWrapper = environmentWrapper ?? throw new ArgumentNullException(nameof(environmentWrapper));
            _configFilenameProvider = configFilenameProvider ?? throw new ArgumentNullException(nameof(configFilenameProvider));
        }

        public IAppConfigurationManager Create(string applicationConfigPath)
        {
            return new AppConfigurationManager(_pathWrapper, _environmentWrapper, _configFilenameProvider, applicationConfigPath);
        }
    }
}