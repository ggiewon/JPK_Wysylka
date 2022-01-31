using JPK.Interfaces.Configuration;
using JPK_WysylkaXML.License.Interfaces;

namespace JPK.Interfaces.Factories
{
    public interface IJpkSenderFactory
    {
        IJpkSender Create(string basePath, IConfiguration configuration, ILicenseManager _licenseManager);
    }
}