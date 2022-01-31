using System;
using JPK_WysylkaXML.License.Interfaces;
using JPK_WysylkaXML.License.Interfaces.Helpers;
using UnitSoftware.Common.Implementation.Cryptography;

namespace JPK_WysylkaXML.License.Helpers
{
    public class LicenseHashCalculator : ILicenseHashCalculator
    {
        private readonly byte[] _salt = {0x22, 0x21, 0x4, 0x2, 0x25, 0x23, 0x6};

        public string CalculateHash(ILicense license)
        {
            if (license == null) throw new ArgumentNullException("license");

            var inputData = string.Concat((object) license.NIP.Replace("-", string.Empty), license.Application);

            return SimpleHash.ComputeHash(inputData, "SHA256", _salt);
        }
    }
}