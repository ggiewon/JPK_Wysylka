using System;
using System.IO;
using System.Xml.Serialization;
using JPK_WysylkaXML.License.Interfaces;
using UnitSoftware.Common.Interfaces.Wrappers.IO;

namespace JPK_WysylkaXML.License
{
    public class LicenseSaver : ILicenseSaver
    {
        private readonly IFileWrapper _fileWrapper;

        public LicenseSaver(IFileWrapper fileWrapper)
        {
            if (fileWrapper == null) throw new ArgumentNullException("fileWrapper");

            _fileWrapper = fileWrapper;
        }

        public void SaveToFile(ILicense license, string path)
        {
            var serializer = new XmlSerializer(typeof(License));

            using (var file = _fileWrapper.Open(path, FileMode.Create))
            {
                serializer.Serialize(file, license);

                file.Close();
            }
        }
    }
}