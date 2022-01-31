namespace JPK_WysylkaXML.License.Interfaces.Helpers
{
    public interface ILicenseHashCalculator
    {
        string CalculateHash(ILicense license);
    }
}