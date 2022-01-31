using System;
using System.Threading.Tasks;
using JPK.Interfaces;
using JPK.Interfaces.Configuration;

namespace JPK_Wysylka.DB.Interfaces.Services
{
    public interface IRequestUpdater
    {
        Task AddOrUpdateAsync(string requestNo, IConfiguration configuration, string statusCode, string statusDescription, DateTime? sendDate);
    }
}