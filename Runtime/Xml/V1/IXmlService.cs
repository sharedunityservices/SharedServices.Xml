namespace SharedServices.Xml.V1
{
    public interface IXmlService
    {
        static T FromXml<T>(string xml)
        {
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
            using var reader = new System.IO.StringReader(xml);
            return (T)serializer.Deserialize(reader);
        }

        static string ToXml<T>(T obj)
        {
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
            using var writer = new System.IO.StringWriter();
            serializer.Serialize(writer, obj);
            return writer.ToString();
        }
    }
}