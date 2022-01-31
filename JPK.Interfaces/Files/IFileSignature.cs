namespace JPK.Interfaces.Files
{
    public interface IFileSignature
    {
        int OrdinalNumber { get; }

        string Filename { get; }

        string Md5 { get; }

        int ContentLength { get; }
    }
}