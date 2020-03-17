using System;
using System.Xml.Serialization;

namespace LoopstationEditor.Models.Settings
{
    public abstract class FileModel
    {
        [XmlAttribute("name")]
        public string Name { get; set; } = "RC-505";

        [XmlAttribute("revision")]
        public int Revision { get; set; } = 2;
    }
}
