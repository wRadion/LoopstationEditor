using System.Xml.Serialization;

using Loopstation.Xml.Base;

namespace Loopstation.Xml
{
    [XmlRoot("mem")]
    public class XmlMemorySettings : XmlMemorySettingsBase
    {
        [XmlAttribute("id")]
        public int Id { get; set; } = 0;

        public XmlMemorySettings() : this(null) { }
        public XmlMemorySettings(XmlMemorySettings other) : base(other) { }

        public override object Clone() => new XmlMemorySettings(this);
    }
}
