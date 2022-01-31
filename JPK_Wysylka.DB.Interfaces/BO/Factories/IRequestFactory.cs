using JPK_Wysylka.DB.Interfaces.Entities;

namespace JPK_Wysylka.DB.Interfaces.BO.Factories
{
    public interface IRequestFactory
    {
        IRequest Create(IRequestEntity requestEntity);
    }
}