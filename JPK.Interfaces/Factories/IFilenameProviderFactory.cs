using JPK.Interfaces.Configuration;
using JPK.Interfaces.Providers;

namespace JPK.Interfaces.Factories
{
    public interface IFilenameProviderFactory
    {
        IFilenameProvider Create(string basePath, IConfiguration configuration);
    }
}