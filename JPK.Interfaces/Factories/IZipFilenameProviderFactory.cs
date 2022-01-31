using JPK.Interfaces.Files.Providers;
using JPK.Interfaces.Providers;

namespace JPK.Interfaces.Factories
{
    public interface IZipFilenameProviderFactory
    {
        IZipFilenameProvider Create(IFilenameProvider filenameProvider);
    }
}