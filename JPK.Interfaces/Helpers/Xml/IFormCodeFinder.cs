using System.Xml;

namespace JPK.Interfaces.Helpers.Xml
{
    public interface IFormCodeFinder
    {
        string FindInFile(string filePath);

        string FindInXmlDocument(XmlDocument xDocument);
    }
}