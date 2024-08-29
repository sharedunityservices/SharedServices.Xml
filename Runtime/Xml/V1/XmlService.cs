namespace SharedServices.Xml.V1
{
    [UnityEngine.Scripting.Preserve]
    public class XmlService : IXmlService
    {
        public T FromXml<T>(string xml) =>
            IXmlService.FromXml<T>(xml);

        public string ToXml<T>(T obj) =>
            IXmlService.ToXml(obj);
    }
}