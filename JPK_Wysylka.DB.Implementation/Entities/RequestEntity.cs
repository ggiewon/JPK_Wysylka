using System;
using System.ComponentModel.DataAnnotations;
using JPK_Wysylka.DB.Interfaces.Entities;

namespace JPK_Wysylka.DB.Implementation.Entities
{
    public class RequestEntity : BaseEntity, IRequestEntity
    {
        public DateTime? SendDate { get; set; }

        public int LastStatus { get; set; }

        [MaxLength(33)]
        public string ReferenceNo { get; set; }

        public string LastStatusDescription { get; set; }

        [MaxLength(1)]
        public string ServerType { get; set; }

        [MaxLength(4000)]
        public byte[] UpoField { get; set; }
    }
}