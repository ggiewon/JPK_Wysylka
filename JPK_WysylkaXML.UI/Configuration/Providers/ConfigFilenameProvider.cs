using JPK_WysylkaXML.UI.Interfaces.Configuration;

namespace JPK_WysylkaXML.UI.Configuration.Providers
{
    public class ConfigFilenameProvider : IConfigFilenameProvider
    {
        private readonly string _defaultConfigFilename = "JPK_WysylkaXML.UI.dll.Config";

        /// <summary>
        /// See <see cref="IConfigFilenameProvider"/> interface documentation
        /// </summary>
        public string GetDefaultConfigFilename()
        {
            return _defaultConfigFilename;
        }
    }
}