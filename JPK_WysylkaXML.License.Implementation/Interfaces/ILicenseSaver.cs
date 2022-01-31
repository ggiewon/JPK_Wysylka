namespace JPK_WysylkaXML.License.Interfaces
{
    public interface ILicenseSaver
    {
        void SaveToFile(ILicense license, string path);
    }
}