using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace LoopstationEditor.Models.Settings
{
    public abstract class FileModel
    {
        public static T Load<T>(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            XmlReaderSettings settings = new XmlReaderSettings() { CloseInput = true };
            using (XmlReader reader = XmlReader.Create(File.OpenRead(path), settings))
                return (T)serializer.Deserialize(reader);
        }

        [XmlAttribute("name")]
        public string Name { get; set; } = "RC-505";

        [XmlAttribute("revision")]
        public int Revision { get; set; } = 2;

        public FileModel() { }

        public void Save(string path)
        {
            XmlSerializer serializer = new XmlSerializer(GetType());
            XmlWriterSettings settings = new XmlWriterSettings()
            {
                CloseOutput = true,
                Encoding = Encoding.UTF8,
                Indent = true,
                NewLineChars = "\n"
            };
            using (XmlWriter writer = XmlWriter.Create(File.OpenWrite(path), settings))
                serializer.Serialize(writer, this, new XmlSerializerNamespaces(new XmlQualifiedName[] { new XmlQualifiedName() }));
        }
    }
}
