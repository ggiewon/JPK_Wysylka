using JPK_Wysylka.DB.Interfaces.BO;

namespace JPK_WysylkaXML.UI.Interfaces.ViewModel.RequestHistory.Factories
{
    public interface IRequestViewModelFactory
    {
        IRequestViewModel Create(IRequest request);
    }
}