using System.Xml;

namespace JPK.Interfaces.Helpers.Xml
{
    public interface INipFinder
    {
        string FindInFile(string inputFilename);

        string FindInXmlDocument(XmlDocument xDocument);
    }
}