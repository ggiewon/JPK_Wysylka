using System.Xml;

namespace JPK.Interfaces.Helpers.Xml
{
    public interface IFormVersionFinder
    {
        int FindInFile(string inputFilename);

        int FindInXmlDocument(XmlDocument xmlDocument);
    }
}