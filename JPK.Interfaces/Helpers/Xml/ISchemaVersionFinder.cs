using System.Xml;

namespace JPK.Interfaces.Helpers.Xml
{
    public interface ISchemaVersionFinder
    {
        string FindInFile(string filePath);

        string FindInXmlDocument(XmlDocument xDocument);
    }
}