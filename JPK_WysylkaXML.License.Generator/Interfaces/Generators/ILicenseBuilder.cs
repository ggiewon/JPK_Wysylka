using JPK_WysylkaXML.License.Interfaces;

namespace JPK_WysylkaXML.License.Generator.Interfaces.Generators
{
    public interface ILicenseBuilder
    {
        ILicense BuildLicense(string nip, string applicationType);
    }
}