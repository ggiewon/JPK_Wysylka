using System.Net;

namespace JPK.Interfaces.Helpers.Responses
{
    public interface IResponse
    {
        HttpStatusCode Status { get; set; }
    }
}