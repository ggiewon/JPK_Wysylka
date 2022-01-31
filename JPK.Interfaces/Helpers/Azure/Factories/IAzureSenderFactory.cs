using JPK.Interfaces.Providers;

namespace JPK.Interfaces.Helpers.Azure.Factories
{
    public interface IAzureSenderFactory
    {
        IAzureSender Create(IFilenameProvider filenameProvider);
    }
}