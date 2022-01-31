namespace JPK_WysylkaXML.License.Interfaces
{
    public interface ILicenseManager
    {
        void LoadLicenseFromDictionary(string path);

        //void LoadLicenseFromFile(string licensePath);

        bool IsValidForNip(string nil);

        bool IsInDemoMode();
    }
}