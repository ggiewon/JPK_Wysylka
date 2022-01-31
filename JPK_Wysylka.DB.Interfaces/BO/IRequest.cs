using System;
using JPK.Interfaces;

namespace JPK_Wysylka.DB.Interfaces.BO
{
    public interface IRequest
    {
        int Id { get; }

        string ReferenceNo { get; }

        DateTime? SendDate { get; }

        int LastStatus { get; set; }

        string LastStatusDescription { get; set; }

        ServerType ServerType { get; }

        string Upo { get; set; }
    }
}