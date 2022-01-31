namespace JPK.Interfaces.Files
{
    public interface IJpkSigner
    {
        void DoSign(string path, string exportPath);
    }
}