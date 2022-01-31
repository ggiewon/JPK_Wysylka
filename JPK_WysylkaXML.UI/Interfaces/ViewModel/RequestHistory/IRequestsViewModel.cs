using System.Collections.ObjectModel;
using System.Windows.Input;

namespace JPK_WysylkaXML.UI.Interfaces.ViewModel.RequestHistory
{
    public interface IRequestsViewModel
    {
        bool IsTestServer { get; }

        ObservableCollection<IRequestViewModel> RequestList { get; }

        ICommand RefreshAllCommand { get; }

        ICommand CloseCommand { get; }

        ICommand DownloadUpoCommand { get; }
    }
}