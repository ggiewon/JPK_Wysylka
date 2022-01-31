namespace JPK_WysylkaXML.EditXML.Interfaces
{
    public interface IJpkVersionProvider
    {
        JpkType GetVersion(string filePath);
    }
}