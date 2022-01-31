using RestSharp;

namespace JPK.Interfaces.Helpers.Responses.Factories
{
    public interface IResponseFactory
    {
        IFinishUploadResponse CreateFinishUploadResponse(IRestResponse response);

        IInitUploadSignedResponse CreateInitUploadSignedResponse(IRestResponse response);

        IStatusResponse CreateStatusResponse(IRestResponse response);
    }
}