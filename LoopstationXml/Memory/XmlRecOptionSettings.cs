using System.Xml.Serialization;

using Loopstation.Xml.Interfaces;

namespace Loopstation.Xml.Memory
{
    [XmlRoot("REC_OPTION")]
    public class XmlRecOptionSettings : ICloneable<XmlRecOptionSettings>
    {
        [XmlElement("DubMod")]
        public int OverdubMode { get; set; } = 0;

        [XmlElement("RecAct")]
        public int RecordAction { get; set; } = 0;

        [XmlElement("RecQtz")]
        public int RecordQuantize { get; set; } = 1;

        public XmlRecOptionSettings() { }
        public XmlRecOptionSettings(XmlRecOptionSettings other)
        {
            if (other == null) return;

            OverdubMode = other.OverdubMode;
            RecordAction = other.RecordAction;
            RecordQuantize = other.RecordQuantize;
        }

        public XmlRecOptionSettings Clone() => new XmlRecOptionSettings(this);
    }
}
