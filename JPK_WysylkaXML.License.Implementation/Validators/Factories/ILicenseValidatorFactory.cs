using JPK_WysylkaXML.License.Interfaces.Validators;

namespace JPK_WysylkaXML.License.Validators.Factories
{
    public interface ILicenseValidatorFactory
    {
        ILicenseValidator Create(string applicationType);
    }

    
}