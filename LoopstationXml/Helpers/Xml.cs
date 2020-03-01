using System;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Loopstation.Xml.Helpers
{
    public static class Xml
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
        public static T? Deserialize<T>(string file) where T : struct
        {
            T? result = null;

            XmlReaderSettings xmlReaderSettings = new XmlReaderSettings()
            {
                CloseInput = true
            };

            using (XmlReader reader = XmlReader.Create(file, xmlReaderSettings))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                result = (T)serializer.Deserialize(reader);
            }

            return result;
        }

        /// <summary>
        /// Returns a new instance of the given object type with the same values as the given object.
        /// </summary>
        /// <typeparam name="T">The type of the object to clone</typeparam>
        /// <param name="obj">The object to clone</param>
        /// <returns>A new instance of the object type that has the same properties/fields values as the given object</returns>
        public static T Clone<T>(T obj) where T : ICloneable => (T)obj.Clone();
    }
}
