using System.Xml;
using JPK.Interfaces.Configuration;
using JPK.Interfaces.Helpers.Responses;

namespace JPK.Interfaces.Helpers
{
    public interface IHttpHelper
    {
        /// <summary>
        /// See <see cref="IHttpHelper.CheckSslCertificate"/> property documentation
        /// </summary>
        bool CheckSslCertificate { get; set; }

        IInitUploadSignedResponse SendInitUploadSigned(XmlDocument documentToSend, IConfiguration configuration);

        IFinishUploadResponse SendFinishUpload(IInitUploadSignedResponse initUploadSignedResponse, IConfiguration configuration);

        IStatusResponse SendStatus(string referenceNumber, IConfiguration configuration);
    }
}