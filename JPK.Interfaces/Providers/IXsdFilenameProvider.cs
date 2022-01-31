namespace JPK.Interfaces.Providers
{
    public interface IXsdFilenameProvider
    {
        string GetXsdFilename(int formVersion, string formCode, string schemaVersion);
    }
}