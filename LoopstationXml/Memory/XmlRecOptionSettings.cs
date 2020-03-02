using System.Xml.Serialization;

using Loopstation.Xml.Interfaces;
using Loopstation.Xml.Utils;

namespace Loopstation.Xml.Memory
{
    [XmlRoot("REC_OPTION")]
    public class XmlRecOptionSettings : ICloneable<XmlRecOptionSettings>
    {
        private int _overdubMode;
        private int _recordAction;
        private int _recordQuantize;

        [XmlElement("DubMod")]
        public int OverdubMode
        {
            get => _overdubMode;
            set => _overdubMode = Range.Guard(value, max: 1);
        }

        [XmlElement("RecAct")]
        public int RecordAction
        {
            get => _recordAction;
            set => _recordAction = Range.Guard(value, max: 1);
        }

        // TODO: RecOption>RecordQuantize ???
        [XmlElement("RecQtz")]
        public int RecordQuantize
        {
            get => _recordQuantize;
            set => _recordQuantize = Range.Guard(value, max: 1);
        }

        public XmlRecOptionSettings() : this(null) { }
        public XmlRecOptionSettings(XmlRecOptionSettings other)
        {
            OverdubMode = other?.OverdubMode ?? 0;
            RecordAction = other?.RecordAction ?? 0;
            RecordQuantize = other?.RecordQuantize ?? 1;
        }

        public XmlRecOptionSettings Clone() => new XmlRecOptionSettings(this);
    }
}
