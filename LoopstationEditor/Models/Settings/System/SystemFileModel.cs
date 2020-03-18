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

        public static SystemFileModel Load(string file) => Load<SystemFileModel>(file);

        [XmlElement("sys")]
        public SystemModel System { get; set; }

        public SystemFileModel() : base()
        {
            System = new SystemModel();
        }
    }
}
