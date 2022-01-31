namespace JPK_WysylkaXML.Interfaces.Helpers.Serializers
{
    public interface IResponseSerializerFactory
    {
        T Create<T>();
    }
}