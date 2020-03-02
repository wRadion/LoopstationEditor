using System.Xml.Serialization;

using Loopstation.Common;

namespace Loopstation.Xml.Memory
{
    [XmlRoot("REC_OPTION")]
    public class XmlRecOptionSettings : ICloneable<XmlRecOptionSettings>
    {
        private int _overdubMode;
        private int _recordAction;
        private int _recordQuantize;

        /// <summary>
        /// Integer from <c>0</c> to <c>1</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("DubMod")]
        public int OverdubMode
        {
            get => _overdubMode;
            set => _overdubMode = Range.Guard(value, max: 1);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>1</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("RecAct")]
        public int RecordAction
        {
            get => _recordAction;
            set => _recordAction = Range.Guard(value, max: 1);
        }

        // TODO: RecOption>RecordQuantize ???
        /// <summary>
        /// Integer from <c>0</c> to <c>1</c>.
        /// <para>Default value is <c>1</c>.</para>
        /// </summary>
        [XmlElement("RecQtz")]
        public int RecordQuantize
        {
            get => _recordQuantize;
            set => _recordQuantize = Range.Guard(value, max: 1);
        }

        public XmlRecOptionSettings() : this(null) { }
        public XmlRecOptionSettings(XmlRecOptionSettings other)
        {
            OverdubMode    = other?.OverdubMode    ?? 0;
            RecordAction   = other?.RecordAction   ?? 0;
            RecordQuantize = other?.RecordQuantize ?? 1;
        }

        public XmlRecOptionSettings Clone() => new XmlRecOptionSettings(this);
    }
}
