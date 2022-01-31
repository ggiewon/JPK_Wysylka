using System;
using System.Threading.Tasks;

namespace JPK.Interfaces.Xml
{
    public interface IXmlPropertyReader : IDisposable
    {
        Task<string> GetFormCode();

        Task<string> GetSchemaVersion();
        
        Task<string> GetSystemCode();

        Task<string> GetNip();
    }
}