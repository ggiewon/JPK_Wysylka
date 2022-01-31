using System;

namespace JPK_Wysylka.DB.Interfaces.Entities
{
    public interface IBaseEntity
    {
        int Id { get; set; }

        DateTime CreateDate { get; set; }

        DateTime UpdateDate { get; set; }
    }
}