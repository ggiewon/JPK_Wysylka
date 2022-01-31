using System.Collections.Generic;

namespace JPK.Interfaces.Validators.Factories
{
    public interface IXmlValidatorFactory
    {
        IXmlValidator Create(IDictionary<int, string> xsdMapping);
    }
}