using System.Xml.Serialization;

using Loopstation.Xml.Interfaces;
using Loopstation.Xml.Utils;

namespace Loopstation.Xml.Memory
{
    [XmlRoot("NAME")]
    public class XmlNameSettings : ICloneable<XmlNameSettings>
    {
        public const char MINIMUM_CHAR = (char)32;
        public const char MAXIMUM_CHAR = (char)126;

        private int _character01;
        private int _character02;
        private int _character03;
        private int _character04;
        private int _character05;
        private int _character06;
        private int _character07;
        private int _character08;
        private int _character09;
        private int _character10;
        private int _character11;
        private int _character12;

        [XmlElement("C01")]
        public int Character01
        {
            get => _character01;
            set => _character01 = Range.Guard(value, min: MINIMUM_CHAR, max: MAXIMUM_CHAR);
        }

        [XmlElement("C02")]
        public int Character02
        {
            get => _character02;
            set => _character02 = Range.Guard(value, min: MINIMUM_CHAR, max: MAXIMUM_CHAR);
        }

        [XmlElement("C03")]
        public int Character03
        {
            get => _character03;
            set => _character03 = Range.Guard(value, min: MINIMUM_CHAR, max: MAXIMUM_CHAR);
        }

        [XmlElement("C04")]
        public int Character04
        {
            get => _character04;
            set => _character04 = Range.Guard(value, min: MINIMUM_CHAR, max: MAXIMUM_CHAR);
        }

        [XmlElement("C05")]
        public int Character05
        {
            get => _character05;
            set => _character05 = Range.Guard(value, min: MINIMUM_CHAR, max: MAXIMUM_CHAR);
        }

        [XmlElement("C06")]
        public int Character06
        {
            get => _character06;
            set => _character06 = Range.Guard(value, min: MINIMUM_CHAR, max: MAXIMUM_CHAR);
        }

        [XmlElement("C07")]
        public int Character07
        {
            get => _character07;
            set => _character07 = Range.Guard(value, min: MINIMUM_CHAR, max: MAXIMUM_CHAR);
        }

        [XmlElement("C08")]
        public int Character08
        {
            get => _character08;
            set => _character08 = Range.Guard(value, min: MINIMUM_CHAR, max: MAXIMUM_CHAR);
        }

        [XmlElement("C09")]
        public int Character09
        {
            get => _character09;
            set => _character09 = Range.Guard(value, min: MINIMUM_CHAR, max: MAXIMUM_CHAR);
        }

        [XmlElement("C10")]
        public int Character10
        {
            get => _character10;
            set => _character10 = Range.Guard(value, min: MINIMUM_CHAR, max: MAXIMUM_CHAR);
        }

        [XmlElement("C11")]
        public int Character11
        {
            get => _character11;
            set => _character11 = Range.Guard(value, min: MINIMUM_CHAR, max: MAXIMUM_CHAR);
        }

        [XmlElement("C12")]
        public int Character12
        {
            get => _character12;
            set => _character12 = Range.Guard(value, min: MINIMUM_CHAR, max: MAXIMUM_CHAR);
        }

        public XmlNameSettings() : this(null) { }
        public XmlNameSettings(XmlNameSettings other)
        {
            Character01 = other?.Character01 ?? 73;
            Character02 = other?.Character02 ?? 78;
            Character03 = other?.Character03 ?? 73;
            Character04 = other?.Character04 ?? 84;
            Character05 = other?.Character05 ?? 32;
            Character06 = other?.Character06 ?? 77;
            Character07 = other?.Character07 ?? 69;
            Character08 = other?.Character08 ?? 77;
            Character09 = other?.Character09 ?? 79;
            Character10 = other?.Character10 ?? 82;
            Character11 = other?.Character11 ?? 89;
            Character12 = other?.Character12 ?? 32;
        }

        public XmlNameSettings Clone() => new XmlNameSettings(this);
    }
}
