using System.Collections.Generic;

namespace JPK_WysylkaXML.Interfaces.Helpers.Requests
{
    public interface IFinishUploadRequest
    {
        string ReferenceNumber { get; set; }

        List<string> AzureBlobNameList { get; set; }
    }
}