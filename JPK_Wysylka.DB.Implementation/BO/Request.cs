using System;
using JPK.Interfaces;
using JPK_Wysylka.DB.Interfaces.BO;

namespace JPK_Wysylka.DB.Implementation.BO
{
    public class Request : IRequest
    {
        public Request(int id, string referenceNo, DateTime? sendDate, ServerType serverType, int code, string description, string upo)
        {
            Upo = upo;

            Id = id;

            ReferenceNo = referenceNo;

            SendDate = sendDate;

            ServerType = serverType;

            LastStatus = code;

            LastStatusDescription = description;
        }

        public Request(int id, string referenceNo, DateTime? sendDate, ServerType serverType, string code, string description, string upo) : this(id, referenceNo, sendDate, serverType, int.Parse(code), description, upo)
        {            
        }

        public string Upo { get; set; }

        public int Id { get; private set; }

        public string ReferenceNo { get; private set; }

        public DateTime? SendDate { get; private set; }
        
        public int LastStatus { get; set; }

        public string LastStatusDescription { get;  set; }

        public ServerType ServerType { get; private set; }
    }
}