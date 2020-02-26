using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;

using LoopstationModels;

namespace LoopstationXml.Extensions
{
    public static class SettingsExtensions
    {
        public const string SYSTEM_TAG = "sys";
        public const string MEMORY_TAG = "mem";

        public const string SYSTEM_FILENAME = "SYSTEM.RC0";
        public const string MEMORY_FILENAME = "MEMORY.RC0";

        public static void ReadXml(this Settings settings, string inputFolder)
        {
            XElement systemXml = XElement.Load(Path.Combine(inputFolder, SYSTEM_FILENAME));
            XElement memoryXml = XElement.Load(Path.Combine(inputFolder, MEMORY_FILENAME));

            settings.System.ReadXml(systemXml.Element(SYSTEM_TAG));

            foreach (XElement mem in memoryXml.Descendants(MEMORY_TAG))
            {
                int memId = int.Parse(mem.Attribute("id").Value);
                settings.Memories[memId].ReadXml(mem);
            }
        }

        private static XElement CreateDatabaseXmlElement()
        {
            XElement databaseXml = new XElement("database");
            databaseXml.SetAttributeValue("name", "RC-505");
            databaseXml.SetAttributeValue("revision", "2");

            return new XElement(databaseXml);
        }

        public static void WriteXml(this Settings settings, string outputFolder)
        {
            XElement databaseSystemXml = CreateDatabaseXmlElement();
            XElement databaseMemoryXml = CreateDatabaseXmlElement();

            XElement systemXml = new XElement(SYSTEM_TAG);

            settings.System.WriteXml(systemXml);

            foreach (MemorySettings memory in settings.Memories)
            {
                XElement memoryXml = new XElement(MEMORY_TAG);
                memoryXml.SetAttributeValue("id", memory.MemoryId);

                memory.WriteXml(memoryXml);

                databaseMemoryXml.Add(memoryXml);
            }

            databaseSystemXml.Add(systemXml);

            XmlWriterSettings xmlSettings = new XmlWriterSettings()
            {
                Indent = true,
                CloseOutput = true,
                NewLineChars = "\n",
                OmitXmlDeclaration = false,
                Encoding = Encoding.UTF8,
                NewLineHandling = NewLineHandling.Replace
            };

            FileStream systemFile = new FileStream(Path.Combine(outputFolder, SYSTEM_FILENAME), FileMode.OpenOrCreate, FileAccess.Write);
            FileStream memoryFile = new FileStream(Path.Combine(outputFolder, MEMORY_FILENAME), FileMode.OpenOrCreate, FileAccess.Write);

            using (XmlWriter systemWriter = XmlWriter.Create(systemFile, xmlSettings))
            {
                using (XmlWriter memoryWriter = XmlWriter.Create(memoryFile, xmlSettings))
                {
                    databaseSystemXml.WriteTo(systemWriter);
                    databaseMemoryXml.WriteTo(memoryWriter);
                }
            }
        }
    }
}
