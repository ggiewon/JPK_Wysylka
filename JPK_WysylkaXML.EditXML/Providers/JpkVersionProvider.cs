using System;
using System.IO;
using System.Xml.Serialization;
using JPK_WysylkaXML.EditXML.Interfaces;

namespace JPK_WysylkaXML.EditXML.Providers
{
    public class JpkVersionProvider : IJpkVersionProvider
    {
        public JpkType GetVersion(string filePath)
        {
            if (TrySerializeTo<XmlTypes.Version3_v7m.v1_0.JPK>(filePath))
                return JpkType.JPK_V7M_1_0;

            if (TrySerializeTo<XmlTypes.Version3_v7m.v1_1.JPK>(filePath))
                return JpkType.JPK_V7M_1_1;

            if (TrySerializeTo<XmlTypes.Version3_v7m.v1_2E.JPK>(filePath))
                return JpkType.JPK_V7M_1_2E;

            if (TrySerializeTo<XmlTypes.Version3_v7m.v2_1E.JPK>(filePath))
                return JpkType.JPK_V7M_2_1E;

            throw new ArgumentOutOfRangeException("Plik zawiera błędną strukturę lub jego wersja jest nie obsługiwana w aktualnej wersji programu.");
        }

        private static bool TrySerializeTo<T>(string path)
        {
            var serializer = new XmlSerializer(typeof(T));
            try
            {
                using (var fileStream = new FileStream(path, FileMode.Open))
                {
                    var unused = (T)serializer.Deserialize(fileStream);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}