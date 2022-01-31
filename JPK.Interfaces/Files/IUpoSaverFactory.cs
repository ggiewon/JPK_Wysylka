using JPK.Interfaces.Providers;

namespace JPK.Interfaces.Files
{
    public interface IUpoSaverFactory
    {
        IUpoSaver Create(IUpoPathProvider upoPathProvider);
    }

    
}