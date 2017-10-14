using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MALAPI
{
    class GenericXMLDeserializer
    {
        public static T XMLDeserialize<T>(string xml)
        {
            var serializer = new XmlSerializer(typeof(T));
            using(var reader = new StringReader(xml))
            {
                return (T)serializer.Deserialize(reader);
            }
        }

        public static string XMLSerialize<T>(T o)
        {
            var ns = new XmlSerializerNamespaces();
            ns.Add(string.Empty, string.Empty);
            var serializer = new XmlSerializer(typeof(T));
            var writer = new UTF8StringWriter();
            serializer.Serialize(writer, o, ns);
            return writer.ToString();
        }
    }

    internal sealed class UTF8StringWriter : StringWriter
    {
        public override Encoding Encoding => Encoding.UTF8;
    }
}
