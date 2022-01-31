using JPK.Interfaces.Configuration;

namespace JPK.Interfaces.Providers.Factories
{
    public interface IFilenameProviderFactory
    {
        IFilenameProvider Create(IConfiguration configuration);
    }
}