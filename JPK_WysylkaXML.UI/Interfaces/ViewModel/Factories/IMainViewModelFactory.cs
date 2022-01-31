using JPK.Interfaces.Configuration;
using JPK_WysylkaXML.License.Interfaces;
using UnitSoftware.Common.Interfaces.Views;

namespace JPK_WysylkaXML.UI.Interfaces.ViewModel.Factories
{
    public interface IMainViewModelFactory
    {
        IMainViewModel Create(IBaseView mainWindow, string applicationPath, IConfiguration configuration, ILicenseManager licenseManager);
    }
}