namespace JPK.Interfaces.Files
{
    public interface IFilePreparer
    {
        string CompressFile(string inputFilename);

        string CreateFilenamewithUniqueName(string inputFilename);
    }
}