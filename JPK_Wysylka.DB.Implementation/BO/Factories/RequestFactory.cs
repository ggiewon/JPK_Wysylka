using System;
using JPK.Interfaces;
using JPK_Wysylka.DB.Interfaces.BO;
using JPK_Wysylka.DB.Interfaces.BO.Factories;
using JPK_Wysylka.DB.Interfaces.Entities;
using UnitSoftware.Common.Interfaces.Helpers;

namespace JPK_Wysylka.DB.Implementation.BO.Factories
{
    public class RequestFactory : IRequestFactory
    {
        private readonly IZipHelper _zipHelper;

        public RequestFactory(IZipHelper zipHelper)
        {
            if (zipHelper == null) throw new ArgumentNullException("zipHelper");

            _zipHelper = zipHelper;
        }

        public IRequest Create(IRequestEntity requestEntity)
        {
            var serverType = EnumHelper<ServerType>.FromStringValue(requestEntity.ServerType);

            var upo = string.Empty;

            if (requestEntity.UpoField != null)
                upo = _zipHelper.Unzip(requestEntity.UpoField);

            var request = new Request(requestEntity.Id, requestEntity.ReferenceNo, requestEntity.SendDate, serverType, requestEntity.LastStatus, requestEntity.LastStatusDescription, upo);

            return request;
        }        
    }
}