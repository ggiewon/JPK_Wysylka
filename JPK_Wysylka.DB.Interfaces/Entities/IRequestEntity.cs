using System;

namespace JPK_Wysylka.DB.Interfaces.Entities
{
    public interface IRequestEntity : IBaseEntity
    {
        DateTime? SendDate { get; set; }

        string ReferenceNo { get; set; }

        int LastStatus { get; set; }

        string LastStatusDescription { get; set; }

        string ServerType { get; set; }

        byte[] UpoField { get; set; }
    }
}