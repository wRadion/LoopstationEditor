using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Loopstation.Xml
{
    public static class LoopstationXml
    {
        /// <summary>
        /// Serializes the given object into an XML file.
        /// </summary>
        /// <typeparam name="T">The type of the object to serialize</typeparam>
        /// <param name="obj">The object to serialize</param>
        /// <param name="file">The file in which the XML will be written</param>
        public static void Serialize<T>(T obj, string file)
        {
            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings()
            {
                CloseOutput = true,
                Encoding = Encoding.UTF8,
                Indent = true,
                NewLineChars = "\n"
            };

            using (XmlWriter writer = XmlWriter.Create(file, xmlWriterSettings))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(writer, obj, new XmlSerializerNamespaces(new XmlQualifiedName[] { new XmlQualifiedName() }));
            }
        }

        /// <summary>
        /// Deserializes a given XML file into an object of the given type.
        /// </summary>
        /// <typeparam name="T">The type of the object to deserialize</typeparam>
        /// <param name="file">The file in which the XML will be read</param>
        /// <returns>The deserialized object</returns>
        public static T Deserialize<T>(string file)
        {
            XmlReaderSettings xmlReaderSettings = new XmlReaderSettings()
            {
                CloseInput = true
            };

            using (XmlReader reader = XmlReader.Create(file, xmlReaderSettings))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(reader);
            }
        }
    }
}
