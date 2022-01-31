namespace JPK.Interfaces.Providers.Factories
{
    public interface IUpoPathProviderdFactory
    {
        IUpoPathProvider Create(IFilenameProvider filenameProvider);
    }

    
}