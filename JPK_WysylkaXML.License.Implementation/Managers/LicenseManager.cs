using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using JPK_WysylkaXML.License.Exceptions;
using JPK_WysylkaXML.License.Interfaces;
using JPK_WysylkaXML.License.Interfaces.Validators;
using UnitSoftware.Common.Interfaces.Wrappers.IO;

namespace JPK_WysylkaXML.License.Managers
{
    public class LicenseManager : ILicenseManager
    {
        private readonly Dictionary<string,  ILicense> _licenseList = new Dictionary<string, ILicense>();

        private readonly IFileWrapper _fileWrapper;

        private readonly ILicenseLoader _licenseLoader;

        private readonly ILicenseValidator _licenseValidator;

        private readonly IDirectoryWrapper _directoryWrapper;

        private readonly IPathWrapper _pathWrapper;

        public LicenseManager(IFileWrapper fileWrapper, ILicenseLoader licenseLoader, ILicenseValidator licenseValidator, IDirectoryWrapper directoryWrapper, IPathWrapper pathWrapper)
        {
            if (fileWrapper == null) throw new ArgumentNullException("fileWrapper");
            if (licenseLoader == null) throw new ArgumentNullException("licenseLoader");
            if (licenseValidator == null) throw new ArgumentNullException("licenseValidator");
            if (directoryWrapper == null) throw new ArgumentNullException("directoryWrapper");
            if (pathWrapper == null) throw new ArgumentNullException("pathWrapper");

            _fileWrapper = fileWrapper;
            _licenseLoader = licenseLoader;
            _licenseValidator = licenseValidator;
            _directoryWrapper = directoryWrapper;
            _pathWrapper = pathWrapper;
        }

        public void LoadLicenseFromDictionary(string path)
        {
            if (!_directoryWrapper.Exists(path))
                throw new DirectoryNotFoundException();

            var licFiles = _directoryWrapper.EnumerateFiles(path).Where(f => _pathWrapper.GetExtension(f).Equals(LicenseConsts.LicenseExtension));

            foreach (var file in licFiles)
                LoadLicenseFromFile(file);
        }

        private void LoadLicenseFromFile(string licensePath)
        {
            if (!_fileWrapper.Exists(licensePath))                
                throw new FileNotFoundException();

            ILicense tmpLicense;

            try
            {
                tmpLicense = _licenseLoader.LoadFromFile(licensePath);
            }
            catch (UnauthorizedAccessException)
            {
                throw new LicenseFileAccessException(string.Format("Brak możliwości odczytania licencji! Plik licencji: {0}", licensePath));
            }

            if (!_licenseValidator.Validate(tmpLicense))
                throw new InvalidLicenseFileException(string.Format("Błędna licencja! Plik licencji: {0}", licensePath));

            if (!_licenseList.ContainsKey(tmpLicense.NIP))
                _licenseList.Add(tmpLicense.NIP, tmpLicense);
        }

        public bool IsValidForNip(string nip)
        {
            return nip.Equals("1111111111") || _licenseList.ContainsKey(nip);
        }

        public bool IsInDemoMode()
        {
            return _licenseList.Count == 0;
        }
    }
}