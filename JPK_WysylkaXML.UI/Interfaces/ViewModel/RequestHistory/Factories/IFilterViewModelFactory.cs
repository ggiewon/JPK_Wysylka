using System.Collections.ObjectModel;
using JPK.Interfaces;

namespace JPK_WysylkaXML.UI.Interfaces.ViewModel.RequestHistory.Factories
{
    public interface IFilterViewModelFactory
    {
        IFilterViewModel Create(ServerType selectedServerType);
    }
}