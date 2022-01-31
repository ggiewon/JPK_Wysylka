namespace JPK.Interfaces.Xml
{
    public interface IXmlPropertyReaderFactory
    {
        IXmlPropertyReader Create(string xmlDocumentPath);
    }

    
}