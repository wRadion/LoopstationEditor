using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace LoopstationEditor.Models.Settings.System
{
    [XmlRoot("database")]
    public class SystemFileModel : FileModel
    {
        public const string FileName = "SYSTEM.RC0";

        public static SystemFileModel Load(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(SystemFileModel));
            XmlReaderSettings settings = new XmlReaderSettings() { CloseInput = true };
            using (XmlReader reader = XmlReader.Create(File.OpenRead(path), settings))
                return (SystemFileModel)serializer.Deserialize(reader);
        }

        [XmlElement("sys")]
        public SystemModel System { get; set; }

        public SystemFileModel() : base()
        {
            System = new SystemModel();
        }

        public void Save(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(SystemFileModel));
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
