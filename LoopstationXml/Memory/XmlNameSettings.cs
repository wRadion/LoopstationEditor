using System.Xml.Serialization;

using Loopstation.Xml.Interfaces;

namespace Loopstation.Xml.Memory
{
    [XmlRoot("NAME")]
    public class XmlNameSettings : ICloneable<XmlNameSettings>
    {
        [XmlElement("C01")]
        public int Character01 { get; set; } = 73;

        [XmlElement("C02")]
        public int Character02 { get; set; } = 78;

        [XmlElement("C03")]
        public int Character03 { get; set; } = 73;

        [XmlElement("C04")]
        public int Character04 { get; set; } = 84;

        [XmlElement("C05")]
        public int Character05 { get; set; } = 32;

        [XmlElement("C06")]
        public int Character06 { get; set; } = 77;

        [XmlElement("C07")]
        public int Character07 { get; set; } = 69;

        [XmlElement("C08")]
        public int Character08 { get; set; } = 77;

        [XmlElement("C09")]
        public int Character09 { get; set; } = 79;

        [XmlElement("C10")]
        public int Character10 { get; set; } = 82;

        [XmlElement("C11")]
        public int Character11 { get; set; } = 89;

        [XmlElement("C12")]
        public int Character12 { get; set; } = 32;

        public XmlNameSettings() { }
        public XmlNameSettings(XmlNameSettings other)
        {
            if (other == null) return;

            Character01 = other.Character01;
            Character02 = other.Character02;
            Character03 = other.Character03;
            Character04 = other.Character04;
            Character05 = other.Character05;
            Character06 = other.Character06;
            Character07 = other.Character07;
            Character08 = other.Character08;
            Character09 = other.Character09;
            Character10 = other.Character10;
            Character11 = other.Character11;
            Character12 = other.Character12;
        }

        public XmlNameSettings Clone() => new XmlNameSettings(this);
    }
}
