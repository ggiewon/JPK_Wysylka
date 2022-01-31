using System.Windows.Input;
using JPK_WysylkaXML.UI.Interfaces.Views;
using UnitSoftware.Common.Interfaces.Commands;

namespace JPK_WysylkaXML.UI.Interfaces.ViewModel
{
    public interface IConfigurationViewModel
    {
        IRefreshableCommand SaveCommand { get; }

        IRefreshableCommand CancelCommand { get; }

        string DataFolder { get; set; }

        ICommand OpenFolderDialogCommand { get; }

        IConfigurationView View { get; set; }

        bool IsConfigurationModified { get; set; }
    }
}