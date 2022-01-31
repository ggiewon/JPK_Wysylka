using System;
using System.Linq;
using System.Threading.Tasks;
using JPK.Interfaces.Configuration;
using JPK_Wysylka.DB.Implementation.BO;
using JPK_Wysylka.DB.Interfaces.Services;

namespace JPK_Wysylka.DB.Implementation.Services
{
    public class RequestUpdater : IRequestUpdater
    {
        private readonly IRequestServiceFactory _requestServiceFactory;

        public RequestUpdater(IRequestServiceFactory requestServiceFactory)
        {
            _requestServiceFactory = requestServiceFactory ?? throw new ArgumentNullException(nameof(requestServiceFactory));
        }

        public async Task AddOrUpdateAsync(string referenceNo, IConfiguration configuration, string statusCode, string statusDescription, DateTime? sendDate)
        {
            var requestService = _requestServiceFactory.Create(configuration);

            var requests = await requestService.GetListAsync();

            var request = requests.SingleOrDefault(r => (r.ReferenceNo == referenceNo) && (r.ServerType ==  configuration.SelectedServer));

            if (request == null)
            {

                var req = new Request(-1, referenceNo, sendDate,  configuration.SelectedServer, statusCode, statusDescription, string.Empty);

                await requestService.AddRequestAsync(req);

                return;
            }

            request.LastStatus = int.Parse(statusCode);
            request.LastStatusDescription = statusDescription;

            await requestService.UpdateRequestAsync(request);
        }
    }


}