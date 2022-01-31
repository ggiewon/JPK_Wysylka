namespace JPK.Interfaces.Files
{
    public interface IFileEncryptor
    {
        byte[] Key { get; }

        byte[] IV { get; }

        string EncryptFile(string filename);
    }
}