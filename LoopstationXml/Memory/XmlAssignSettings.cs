using System.Xml.Serialization;

using Loopstation.Common;

namespace Loopstation.Xml.Memory
{
    public class XmlAssignSettings : ICloneable<XmlAssignSettings>
    {
        private int _switch;
        private int _source;
        private int _sourceMode;
        private int _target;
        private int _targetMin;
        private int _targetMax;

        /// <summary>
        /// Integer from <c>0</c> to <c>1</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("Sw")]
        public int Switch
        {
            get => _switch;
            set => _switch = Range.Guard(value, max: 1);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>78</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("Src")]
        public int Source
        {
            get => _source;
            set => _source = Range.Guard(value, max: 78);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>1</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("SrcMod")]
        public int SourceMode
        {
            get => _sourceMode;
            set => _sourceMode = Range.Guard(value, max: 1);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>142</c>.
        /// <para>Default value is <c>20</c>.</para>
        /// </summary>
        [XmlElement("Tgt")]
        public int Target
        {
            get => _target;
            set => _target = Range.Guard(value, max: 142);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>127</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("TgtMin")]
        public int TargetMin
        {
            get => _targetMin;
            set => _targetMin = Range.Guard(value, max: 127);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>127</c>.
        /// <para>Default value is <c>100</c>.</para>
        /// </summary>
        [XmlElement("TgtMax")]
        public int TargetMax
        {
            get => _targetMax;
            set => _targetMax = Range.Guard(value, max: 127);
        }

        public XmlAssignSettings() : this(null) { }
        public XmlAssignSettings(XmlAssignSettings other)
        {
            Switch     = other?.Switch     ?? 0;
            Source     = other?.Source     ?? 0;
            SourceMode = other?.SourceMode ?? 0;
            Target     = other?.Target     ?? 20;
            TargetMin  = other?.TargetMin  ?? 0;
            TargetMax  = other?.TargetMax  ?? 100;
        }

        public XmlAssignSettings Clone() => new XmlAssignSettings(this);
    }
}
