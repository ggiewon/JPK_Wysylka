using System.IO;

namespace JPK.Interfaces
{
    public interface ISettingsManager
    {
        bool SaleSettingExists { get; }

        bool PurchaseSettingExists { get; }

        void SetPurchaseGridSettings(string settings);

        void SetSaleGridSettings(string settings);

        Stream GetPurchaseGridSettings();

        Stream GetSaleGridSettings();
    }
}