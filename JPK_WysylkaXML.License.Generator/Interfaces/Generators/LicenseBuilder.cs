using System;
using JPK_WysylkaXML.License.Interfaces;
using JPK_WysylkaXML.License.Interfaces.Helpers;

namespace JPK_WysylkaXML.License.Generator.Interfaces.Generators
{
    public class LicenseBuilder : ILicenseBuilder
    {
        private readonly ILicenseHashCalculator _licenseHashCalculator;

        public LicenseBuilder(ILicenseHashCalculator licenseHashCalculator)
        {
            if (licenseHashCalculator == null) throw new ArgumentNullException("licenseHashCalculator");

            _licenseHashCalculator = licenseHashCalculator;
        }

        public ILicense BuildLicense(string nip, string applicationType)
        {
            var license = new License {NIP = nip, Application = applicationType};

            var licenseHash = _licenseHashCalculator.CalculateHash(license);

            license.Hash = licenseHash;

            return license;
        }
    }
}