namespace JPK.Interfaces.Providers
{
    public interface IKeyProvider
    {
        byte[] CreateKey(string password, int keyBytes = 32);
    }
}