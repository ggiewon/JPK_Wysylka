using System.Threading.Tasks;

namespace JPK.Interfaces.Helpers.Azure
{
    public interface IAzureSender
    {
        Task SendBlobAsync(string url, string filename);
    }
}