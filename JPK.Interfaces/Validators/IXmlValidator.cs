using System;
using System.Threading.Tasks;

namespace JPK.Interfaces.Validators
{
    public interface IXmlValidator
    {
        bool Validate(string xmlDocument, Action<string> logCallback);

        Task<bool> ValidateAsync(string xmlDocument, Action<string> addLogMessage);
    }
}