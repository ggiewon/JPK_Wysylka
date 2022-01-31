using System.Collections.Generic;

namespace JPK.Interfaces.Helpers.Requests
{
    
    public class HeaderElement : IHeaderElement
    {
        public string Key { get; set; }

        public string Value { get; set; }
    }

    public class RequestToUploadFileList : IRequestToUploadFileList
    {
        public string BlobName { get; set; }

        public string FileName { get; set; }

        public string Url { get; set; }

        public List<HeaderElement> HeaderList { get; set; }
    }

    public interface IRequestToUploadFileList
    {
        string BlobName { get; set; }

        string FileName { get; set; }

        string Url { get; set; }

        List<HeaderElement> HeaderList { get; set; }
    }
}