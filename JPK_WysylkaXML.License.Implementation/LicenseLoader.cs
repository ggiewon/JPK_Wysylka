using System;
using System.IO;
using System.Xml.Serialization;
using JPK_WysylkaXML.License.Interfaces;
using UnitSoftware.Common.Interfaces.Wrappers.IO;

namespace JPK_WysylkaXML.License
{
    public class LicenseLoader : ILicenseLoader
    {
        private readonly IFileWrapper _fileWrapper;

        public LicenseLoader(IFileWrapper fileWrapper)
        {
            if (fileWrapper == null) throw new ArgumentNullException("fileWrapper");

            _fileWrapper = fileWrapper;
        }

        public ILicense LoadFromFile(string path)
        {
            if (!_fileWrapper.Exists(path))
                throw new FileNotFoundException(string.Format("Brak pliku licencji{0}", path));

            ILicense license;

            var serializer = new XmlSerializer(typeof(License));

            using (var reader = _fileWrapper.Open(path, FileMode.Open))
            {
                license = (License)serializer.Deserialize(reader);
                reader.Close();
            }

            return license;
        }
    }
}