namespace JPK.Interfaces.Files.Factories
{
    public interface IFileSignatureFactory
    {
        IFileSignature Create(int no, string filename);
    }
}