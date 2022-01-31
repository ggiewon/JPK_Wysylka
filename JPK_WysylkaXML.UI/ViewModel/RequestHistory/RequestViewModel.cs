using System;
using JPK.Interfaces;
using JPK_WysylkaXML.UI.Interfaces.ViewModel.RequestHistory;
using UnitSoftware.Common.Implementation.ViewModels;
using UnitSoftware.Common.Implementation.ExtensionMethods;

namespace JPK_WysylkaXML.UI.ViewModel.RequestHistory
{
    internal class RequestViewModel : BaseViewModel, IRequestViewModel
    {
        private int _lastStatus;

        private string _lastStatusDescription;

        public RequestViewModel(int id, string referenceNo, int status, string statusDescription, DateTime? sendDate, ServerType serverType, bool isUpo)
        {
            Id = id;

            ReferenceNo = referenceNo;

            LastStatus = status;

            LastStatusDescription = statusDescription;

            SendDate = sendDate;

            ServerType = serverType;

            IsUpo = isUpo;
        }

        public int Id { get; private set; }

        public string ReferenceNo { get; private set; }

        public DateTime? SendDate { get; private set; }

        public int LastStatus
        {
            get { return _lastStatus; }
            set
            {
                if (_lastStatus != value)
                {
                    _lastStatus = value;

                    this.RaisePropertyChanged(p => p.LastStatus);
                }
            }
        }

        public string LastStatusDescription
        {
            get { return _lastStatusDescription; }
            set
            {
                if (_lastStatusDescription != value)
                {
                    _lastStatusDescription = value;
                    this.RaisePropertyChanged(p => p.LastStatusDescription);
                }
            }
        }

        public ServerType ServerType { get; private set; }

        public bool IsUpo { get; private set; }
    }
}