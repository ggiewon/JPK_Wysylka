using System;

namespace JPK.Interfaces.Helpers.Responses
{
    public interface IStatusResponse : IResponse
    {
        string Code { get; set; }

        string Description { get; set; }

        string Details { get; set; }

        DateTime Timestamp { get; set; }

        string Upo { get; set; }
    }
}