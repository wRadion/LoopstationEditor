using System;
using System.Xml.Serialization;

namespace Loopstation.Xml.Memory
{
    [XmlRoot("REC_OPTION")]
    public class XmlRecOptionSettings : ICloneable
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

        public object Clone() => new XmlRecOptionSettings(this);
    }
}
