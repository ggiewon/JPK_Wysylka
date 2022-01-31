using JPK.Interfaces;
using JPK_WysylkaXML.UI.Interfaces.ViewModel.RequestHistory;
using JPK_WysylkaXML.UI.Interfaces.ViewModel.RequestHistory.Factories;

namespace JPK_WysylkaXML.UI.ViewModel.RequestHistory.Factories
{
    public class FilterViewModelFactory : IFilterViewModelFactory
    {
        public IFilterViewModel Create(ServerType selectedServerType)
        {
            return new FilterViewModel(selectedServerType);
        }
    }
}