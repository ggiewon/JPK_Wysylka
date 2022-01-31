using System.Collections.Generic;
using JPK.Interfaces.Files;
using JPK.XmlTypes;

namespace JPK.Interfaces.Helpers.Xml.Factories
{
    public interface IInitUploadFactory
    {
        InitUploadType Create(byte[] encryptionKey, string filename, string formCodeValue, string schemaVersion, string systemCode, byte[] encriptionVI, long contentLength, string fileHashValue, IList<IFileSignature> fileSignatures);
    }
}