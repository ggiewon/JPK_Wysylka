using System;
using System.Windows.Markup;

namespace JPK_WysylkaXML.UI.Components
{
    public class TranslateXamlExtension : MarkupExtension
    {
        private readonly string _key;

        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="key">Value to be translated.</param>
        public TranslateXamlExtension(string key)
        {
            _key = key;
        }

        /// <summary>
        /// Overrided MarkupExtension member which does the translation.
        /// </summary>
        /// <param name="serviceProvider">IServiceProvider member.</param>
        /// <returns>Translated value.</returns>
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return ResourceTranslator.GetString(_key);
        }
    }

    
}