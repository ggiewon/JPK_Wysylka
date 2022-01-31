namespace JPK.Interfaces.Providers
{
    public interface IFilenameProvider
    {
        void InitNewSession();

        string GetInitUploadFilename();

        string GetInitUploadSignedFilename();

        string GetEncryptedFilename(string filename);

        string GetSplitedFilename(string inputFile, int index);

        string GetDirectory();

        string GetUpoDirectory();

        string GetEncryptionCertificate(string encryptionCertificateFilename);
    }
}