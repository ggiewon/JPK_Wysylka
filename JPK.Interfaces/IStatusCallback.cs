using System;
using JPK.Interfaces.Configuration;

namespace JPK.Interfaces
{
    public interface IStatusCallback
    {
        string RequestNo { get; }

        string StatusCode { get; }

        string StatusDescription { get; }

        IConfiguration Configuration { get; }

        DateTime? SendDate { get; }
    }
}