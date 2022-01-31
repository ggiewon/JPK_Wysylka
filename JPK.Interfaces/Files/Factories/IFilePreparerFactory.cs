using JPK.Interfaces.Files.Providers;
using JPK.Interfaces.Providers;

namespace JPK.Interfaces.Files.Factories
{
    public interface IFilePreparerFactory
    {
        IFilePreparer Create(IZipFilenameProvider zipFilenameProvider, IFilenameProvider filenameProvider);
    }

    
}