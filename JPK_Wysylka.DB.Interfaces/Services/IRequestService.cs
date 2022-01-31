using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JPK.Interfaces;
using JPK_Wysylka.DB.Interfaces.BO;

namespace JPK_Wysylka.DB.Interfaces.Services
{
    public interface IRequestService : IDisposable
    {
        Task<List<IRequest>> GetListAsync();

        Task AddRequestAsync(IRequest request);

        Task UpdateRequestAsync(IRequest request);

        Task StoreUpoAsync(string referenceNo, string upo, ServerType serverType);

        Task<IRequest> GetByReferenceNoAsync(string requestNo, ServerType serverType);
    }
}