using System.Windows.Input;
using UnitSoftware.Common.Interfaces.ViewModels;
using UnitSoftware.Common.Wpf.Interfaces.ViewModels;

namespace JPK_WysylkaXML.UI.Interfaces.ViewModel
{
    public interface IMainViewModel : IBaseViewModel
    {
        IOpenFileViewModel OpenFileViewModel { get; }

        ICommand ValidateCommand { get; }

        ICommand SendCommand { get; }

        bool IsInputFileValid { get; }

        bool IsValidationValidated { get; }
    }
}