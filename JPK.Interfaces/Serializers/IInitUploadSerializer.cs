using JPK.XmlTypes;

namespace JPK.Interfaces.Serializers
{
    public interface IInitUploadSerializer
    {
        void SerializeToFile(InitUploadType path, string outputFilename);
    }
}