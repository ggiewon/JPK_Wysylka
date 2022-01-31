using System;
using JPK_WysylkaXML.License.Exceptions;
using JPK_WysylkaXML.License.Interfaces;
using JPK_WysylkaXML.License.Interfaces.Helpers;
using JPK_WysylkaXML.License.Interfaces.Validators;
using JPK_WysylkaXML.License.Validators.Factories;

namespace JPK_WysylkaXML.License.Validators
{
    public class LicenseValidatorFactory : ILicenseValidatorFactory
    {
        private readonly ILicenseHashCalculator _licenseHashCalculator;

        public LicenseValidatorFactory(ILicenseHashCalculator licenseHashCalculator)
        {
            _licenseHashCalculator = licenseHashCalculator ?? throw new ArgumentNullException(nameof(licenseHashCalculator));
        }

        public ILicenseValidator Create(string applicationType)
        {
            return new LicenseValidator(_licenseHashCalculator, applicationType);
        }
    }

    public class LicenseValidator : ILicenseValidator
    {
        private readonly ILicenseHashCalculator _licenseHashCalculator;

        private readonly string _applicationType;

        public LicenseValidator(ILicenseHashCalculator licenseHashCalculator, string applicationType)
        {
            if (licenseHashCalculator == null) throw new ArgumentNullException("licenseHashCalculator");
            if (string.IsNullOrEmpty(applicationType)) throw new ArgumentNullException("applicationType");

            _licenseHashCalculator = licenseHashCalculator;
            _applicationType = applicationType;
        }

        /// <summary>
        /// See <see cref="ILicenseValidator.Validate"/> method documentation
        /// </summary>
        public bool Validate(ILicense license)
        {
            if (license == null) throw new ArgumentNullException("license");

            if (license.Application != _applicationType)
                throw new InvalidLicenseFileException("Licencja nie dotyczy danej aplikacji.");

            var hashString = _licenseHashCalculator.CalculateHash(license);

            return license.Hash.Equals(hashString);
        }
    }
}