using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using JPK.Interfaces;
using JPK.Interfaces.Configuration;
using JPK_Wysylka.DB.Implementation.Context;
using JPK_Wysylka.DB.Implementation.Context.Factory;
using JPK_Wysylka.DB.Implementation.Entities;
using JPK_Wysylka.DB.Interfaces.BO;
using JPK_Wysylka.DB.Interfaces.BO.Factories;
using JPK_Wysylka.DB.Interfaces.Services;
using Microsoft.EntityFrameworkCore;
using UnitSoftware.Common.Interfaces.Helpers;
using UnitSoftware.Common.Interfaces.Wrappers.System;

namespace JPK_Wysylka.DB.Implementation.Services
{
    public class RequestServiceFactory : IRequestServiceFactory
    {
        private readonly ISystemDateTime _systemDateTime;
        private readonly IRequestFactory _requestFactory;
        private readonly IRequestContextFactory _requestContextFactory;
        private readonly IZipHelper _zipHelper;

        public RequestServiceFactory(ISystemDateTime systemDateTime, IRequestFactory requestFactory, IRequestContextFactory requestContextFactory,  IZipHelper zipHelper)
        {
            _systemDateTime = systemDateTime;
            _requestFactory = requestFactory;
            _requestContextFactory = requestContextFactory;
            _zipHelper = zipHelper;
        }

        public IRequestService Create(IConfiguration configuration)
        {
            return new RequestService1(_systemDateTime, _requestFactory, _requestContextFactory, configuration, _zipHelper);
        }
    }

    public interface IRequestServiceFactory
    {
        IRequestService Create(IConfiguration configuration);
    }

    public class RequestService1 : IRequestService
    {
        private readonly ISystemDateTime _systemDateTime;

        private readonly IRequestFactory _requestFactory;
        
        private readonly IRequestContextFactory _requestContextFactory;

        private readonly IConfiguration _configuration;

        private readonly IZipHelper _zipHelper;

        private RequestContext _requestContext;

        private bool _disposed;

        public RequestService1(ISystemDateTime systemDateTime, IRequestFactory requestFactory, IRequestContextFactory requestContextFactory, IConfiguration configuration, IZipHelper zipHelper)
        {
            _systemDateTime = systemDateTime ?? throw new ArgumentNullException(nameof(systemDateTime));
            _requestFactory = requestFactory ?? throw new ArgumentNullException(nameof(requestFactory));
            _requestContextFactory = requestContextFactory ?? throw new ArgumentNullException(nameof(requestContextFactory));
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _zipHelper = zipHelper ?? throw new ArgumentNullException(nameof(zipHelper));

            _configuration.PropertyChanged += OnConfigurationChange;

            _requestContext = requestContextFactory.Create(configuration.DataFolderPath);

        }

        private void OnConfigurationChange(object sender, PropertyChangedEventArgs e)
        {
            _requestContext = _requestContextFactory.Create(_configuration.DataFolderPath);
        }

        public async Task<List<IRequest>> GetListAsync()
        {
            var reqEn = await _requestContext.Requests.ToListAsync();

            var req = reqEn.Select(r => _requestFactory.Create(r)).ToList();

            return req;
        }

        public async Task AddRequestAsync(IRequest request)
        {
            byte[] compressedUpo = null;

            if (!string.IsNullOrEmpty(request.Upo))
                compressedUpo = _zipHelper.Zip(request.Upo);

            var entity = new RequestEntity
            {
                CreateDate = _systemDateTime.Now(),
                UpdateDate = _systemDateTime.Now(),                
                SendDate = request.SendDate,
                ServerType =  EnumHelper<ServerType>.GetStringValue(request.ServerType),
                LastStatus = request.LastStatus,
                ReferenceNo = request.ReferenceNo,
                LastStatusDescription = request.LastStatusDescription,
                UpoField = compressedUpo
            };

            _requestContext.Requests.Add(entity);
            await _requestContext.SaveChangesAsync();
        }

        public async Task UpdateRequestAsync(IRequest request)
        {
            if (request == null) throw new ArgumentNullException("request");

            var requestEntity = await _requestContext.Requests.SingleOrDefaultAsync(r => r.Id == request.Id);

            if (requestEntity == null)
                throw new Exception();

            byte[] compressedUpo = null;

            if (!string.IsNullOrEmpty(request.Upo))
                compressedUpo = _zipHelper.Zip(request.Upo);

            requestEntity.UpoField = compressedUpo;
            requestEntity.LastStatus = request.LastStatus;
            requestEntity.LastStatusDescription = request.LastStatusDescription;
            requestEntity.UpdateDate = _systemDateTime.Now();

            await _requestContext.SaveChangesAsync();
        }

        public async Task StoreUpoAsync(string referenceNo, string upo, ServerType serverType)
        {
            byte[] compressedUpo = null;

            if (!string.IsNullOrEmpty(upo))
                compressedUpo = _zipHelper.Zip(upo);

            var strServerType = EnumHelper<ServerType>.GetStringValue(serverType);

            var requestEntity = await _requestContext.Requests.SingleOrDefaultAsync(r => (r.ReferenceNo == referenceNo) && (r.ServerType == strServerType));

            if (requestEntity == null)
                throw new Exception();

            requestEntity.UpoField = compressedUpo;
            requestEntity.UpdateDate = _systemDateTime.Now();

            await _requestContext.SaveChangesAsync();
        }

        public async Task<IRequest> GetByReferenceNoAsync(string requestNo, ServerType serverType)
        {
            var strServerType = EnumHelper<ServerType>.GetStringValue(serverType);

            var req = await _requestContext.Requests.SingleAsync(r => r.ReferenceNo.Equals(requestNo) && (r.ServerType == strServerType));

            return _requestFactory.Create(req);
        }

        public void Dispose()
        {
            if (_disposed)
                return;

            _configuration.PropertyChanged -= OnConfigurationChange;

            _disposed = true;

            _requestContext.Dispose();
            _requestContext = null;
        }
    }
}