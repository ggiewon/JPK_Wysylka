using JPK.Interfaces.Configuration;

namespace JPK.Interfaces.Cryptography
{
    public interface IRsaEncryptor
    {
        string Encrypt(byte[] key, IConfiguration configuration);
    }
}