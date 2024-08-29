namespace SharedServices.Xml.V1
{
    public class XmlService : IXmlService
    {
        public T FromXml<T>(string xml) =>
            IXmlService.FromXml<T>(xml);

        public string ToXml<T>(T obj) =>
            IXmlService.ToXml(obj);
    }
}