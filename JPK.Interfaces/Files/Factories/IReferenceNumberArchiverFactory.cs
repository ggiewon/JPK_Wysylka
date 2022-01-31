using JPK.Interfaces.Providers;

namespace JPK.Interfaces.Files.Factories
{
    public interface IReferenceNumberArchiverFactory
    {
        IReferenceNumberArchiver Create(IFilenameProvider filenameProvider);
    }

    
}