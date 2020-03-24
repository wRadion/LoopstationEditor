using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

using LoopstationEditor.Models.Interfaces;

namespace LoopstationEditor.Models.Settings
{
    public abstract class FileModel : IXmlContainer
    {
        protected static T Load<T>(string path) where T : FileModel, IXmlContainer
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            XmlReaderSettings settings = new XmlReaderSettings() { CloseInput = true };
            using (XmlReader reader = XmlReader.Create(File.OpenRead(path), settings))
            {
                T model = (T)serializer.Deserialize(reader);
                model.CurrentPath = path;
                model.ApplyXmlValues();
                return model;
            }
        }

        [XmlAttribute("name")]
        public string Name { get; set; } = "RC-505";

        [XmlAttribute("revision")]
        public int Revision { get; set; } = 2;

        [XmlIgnore]
        public string CurrentPath { get; set; }

        public FileModel() { }

        public void Save() => Save(CurrentPath);
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
            {
                ApplyPropertyValues();
                serializer.Serialize(writer, this, new XmlSerializerNamespaces(new XmlQualifiedName[] { new XmlQualifiedName() }));
                CurrentPath = path;
            }
        }

        public abstract void ApplyXmlValues();
        public abstract void ApplyPropertyValues();
    }
}
