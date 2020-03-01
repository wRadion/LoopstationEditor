using System;
using System.Xml.Serialization;

namespace Loopstation.Xml.System
{
    [XmlRoot("USB")]
    public class XmlUSBSettings : ICloneable
    {
        [XmlElement("Mod")]
        public int Mode { get; set; } = 0;

        [XmlElement("AuRouting")]
        public int AudioRouting { get; set; } = 0;

        [XmlElement("InLvl")]
        public int InputLevel { get; set; } = 50;

        [XmlElement("OutLvl")]
        public int OutputLevel { get; set; } = 50;

        public XmlUSBSettings() { }
        public XmlUSBSettings(XmlUSBSettings other)
        {
            if (other == null) return;

            Mode = other.Mode;
            AudioRouting = other.AudioRouting;
            InputLevel = other.InputLevel;
            OutputLevel = other.OutputLevel;
        }

        public object Clone() => new XmlUSBSettings(this);
    }
}
