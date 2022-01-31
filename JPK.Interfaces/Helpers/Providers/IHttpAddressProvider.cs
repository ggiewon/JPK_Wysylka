using JPK.Interfaces.Configuration;

namespace JPK.Interfaces.Helpers.Providers
{
    public interface IHttpAddressProvider
    {
        string GetInitUploadSignedAddress(IConfiguration configuration);

        string GetFinishUploadAddress(IConfiguration configuration);

        string GetStatusAddress(string referenceNumber, IConfiguration configuration);
    }
}