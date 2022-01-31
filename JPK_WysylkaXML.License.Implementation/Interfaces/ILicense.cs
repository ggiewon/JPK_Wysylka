namespace JPK_WysylkaXML.License.Interfaces
{
    public interface ILicense
    {
        string NIP { get; }

        string Application { get; }

        string Hash { get; }
    }
}