using System.IO;
using JPK.Interfaces;

namespace JPK_WysylkaXML.UI
{
    public class SettingsManager : ISettingsManager
    {
        public bool SaleSettingExists => !string.IsNullOrEmpty(Properties.Settings.Default.SaleGridSettings);

        public bool PurchaseSettingExists => !string.IsNullOrEmpty(Properties.Settings.Default.PurchaseGridSettings);

        public void SetPurchaseGridSettings(string settings)
        {
            Properties.Settings.Default.PurchaseGridSettings = settings;
            Properties.Settings.Default.Save();
        }

        public void SetSaleGridSettings(string settings)
        {
            Properties.Settings.Default.SaleGridSettings = settings;
            Properties.Settings.Default.Save();
        }

        public Stream GetPurchaseGridSettings()
        {
            var settings = Properties.Settings.Default.PurchaseGridSettings;
            
            return GenerateStreamFromString(settings);
        }

        public Stream GetSaleGridSettings()
        {
            var settings = UI.Properties.Settings.Default.SaleGridSettings;

            return GenerateStreamFromString(settings);
        }

        private Stream GenerateStreamFromString(string s)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);

            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
    }
}