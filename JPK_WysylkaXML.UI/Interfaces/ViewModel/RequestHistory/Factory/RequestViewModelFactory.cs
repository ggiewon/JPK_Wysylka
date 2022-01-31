using System;
using JPK_Wysylka.DB.Interfaces.BO;
using JPK_WysylkaXML.UI.Interfaces.ViewModel.RequestHistory.Factories;
using JPK_WysylkaXML.UI.ViewModel.RequestHistory;

namespace JPK_WysylkaXML.UI.Interfaces.ViewModel.RequestHistory.Factory
{
    class RequestViewModelFactory : IRequestViewModelFactory
    {
        public IRequestViewModel Create(IRequest request)
        {
            if (request == null) throw new ArgumentNullException("request");

            return new RequestViewModel(request.Id, request.ReferenceNo, request.LastStatus, request.LastStatusDescription, request.SendDate, request.ServerType, !string.IsNullOrEmpty(request.Upo));
        }
    }
}