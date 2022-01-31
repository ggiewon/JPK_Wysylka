using JPK.Interfaces.Configuration;

namespace JPK.Interfaces.Helpers.Cryptography
{
    public interface ICertificateFilenameProvider
    {
        string GetFilename(ServerType serverType, IConfiguration configuration);
    }
}