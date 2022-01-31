using System.Collections.Generic;

namespace JPK.Interfaces.Helpers.Requests.Factories
{
    public interface IRequestsFactory
    {
        string Create(string referenceNumber, List<string> md5FileList);
    }
}