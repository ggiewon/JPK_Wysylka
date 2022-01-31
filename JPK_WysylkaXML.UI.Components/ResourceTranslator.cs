using System.Globalization;
using System.Reflection;
using System.Resources;

namespace JPK_WysylkaXML.UI.Components
{
    public class TextProvider : UnitSoftware.Common.Interfaces.Providers.ITextProvider
    {
        public string GetText(string messageId)
        {
            return ResourceTranslator.GetString(messageId);
        }
    }
    /// <summary>
    /// Object to read texts from resources
    /// </summary>
    public static class ResourceTranslator
    {
        private static readonly ResourceManager ResourceManager;

        private const string ResourceName = "JPK_WysylkaXML.UI.Components.Resources.Strings";

        private static string _language = "pl";

        /// <summary>
        /// Main static constructor
        /// </summary>
        static ResourceTranslator()
        {
            var assembly = Assembly.GetExecutingAssembly();

            ResourceManager = new ResourceManager(ResourceName, assembly);
        }

        public static void SetLanguage(string language)
        {
            _language = language;
        }

        /// <summary>
        /// Read string from resource associated to provided key
        /// </summary>
        public static string GetString(string key)
        {
            var translatedResource = ResourceManager.GetString(key, new CultureInfo(_language));

            return translatedResource;
        }
    }
}