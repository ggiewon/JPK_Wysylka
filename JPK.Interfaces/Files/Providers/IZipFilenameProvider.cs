namespace JPK.Interfaces.Files.Providers
{
    public interface IZipFilenameProvider
    {
        string GetZipFilename(string inputFilename);
    }
}