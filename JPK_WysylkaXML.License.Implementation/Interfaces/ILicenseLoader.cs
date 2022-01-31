namespace JPK_WysylkaXML.License.Interfaces
{
    public interface ILicenseLoader
    {
        ILicense LoadFromFile(string path);
    }
}