namespace JPK_Wysylka.DB.Implementation.Context.Factory
{
    public interface IRequestContextFactory
    {
        RequestContext Create(string appDataFolder);
    }
}