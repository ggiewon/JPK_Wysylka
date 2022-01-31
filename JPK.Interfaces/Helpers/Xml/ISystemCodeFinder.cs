using System.Xml;

namespace JPK.Interfaces.Helpers.Xml
{
    public interface ISystemCodeFinder
    {
        string FindInFile(string filePath);

        string FindInXmlDocument(XmlDocument xDocument);
    }
}