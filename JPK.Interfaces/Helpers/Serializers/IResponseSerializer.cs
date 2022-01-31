namespace JPK.Interfaces.Helpers.Serializers
{
    public interface IResponseSerializer<out T>
    {
        T Serialize(string content);
    }
}