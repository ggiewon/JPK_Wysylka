using System;
using JPK.Interfaces;

namespace JPK_WysylkaXML.UI.Interfaces.ViewModel.RequestHistory
{
    public interface IRequestViewModel
    {
        int Id { get; }

        string ReferenceNo { get; }

        DateTime? SendDate { get; }

        int LastStatus { get; set; }

        string LastStatusDescription { get; set; }

        ServerType ServerType { get; }

        bool IsUpo { get; }
    }
}