using System.Collections.Generic;
using JPK.Interfaces.Helpers.Requests;

namespace JPK.Interfaces.Helpers.Responses
{
    public interface IInitUploadSignedResponse : IResponse
    {
        string ReferenceNumber { get; set; }

        int TimeoutInSec { get; set; }

        List<RequestToUploadFileList> RequestToUploadFileList { get; set; }

        string Message { get; set; }

        string Code { get; set; }
    }
}