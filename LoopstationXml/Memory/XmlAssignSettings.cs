using System.Xml.Serialization;

using Loopstation.Xml.Interfaces;

namespace Loopstation.Xml.Memory
{
    public class XmlAssignSettings : ICloneable<XmlAssignSettings>
    {
        [XmlElement("Sw")]
        public int Switch { get; set; } = 0;

        [XmlElement("Src")]
        public int Source { get; set; } = 0;

        [XmlElement("SrcMod")]
        public int SourceMode { get; set; } = 0;

        [XmlElement("Tgt")]
        public int Target { get; set; } = 20;

        [XmlElement("TgtMin")]
        public int TargetMin { get; set; } = 0;

        [XmlElement("TgtMax")]
        public int TargetMax { get; set; } = 100;

        public XmlAssignSettings() { }
        public XmlAssignSettings(XmlAssignSettings other)
        {
            if (other == null) return;

            Switch = other.Switch;
            Source = other.Source;
            SourceMode = other.SourceMode;
            Target = other.Target;
            TargetMin = other.TargetMin;
            TargetMax = other.TargetMax;
        }

        public XmlAssignSettings Clone() => new XmlAssignSettings(this);
    }
}
