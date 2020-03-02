using System.Xml.Serialization;

using Loopstation.Common;

namespace Loopstation.Xml.System
{
    [XmlRoot("USB")]
    public class XmlUSBSettings : ICloneable<XmlUSBSettings>
    {
        private int _mode;
        private int _audioRouting;
        private int _inputLevel;
        private int _outputLevel;

        /// <summary>
        /// Integer from <c>0</c> to <c>1</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("Mod")]
        public int Mode
        {
            get => _mode;
            set => _mode = Range.Guard(value, max: 1);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>2</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("AuRouting")]
        public int AudioRouting
        {
            get => _audioRouting;
            set => _audioRouting = Range.Guard(value, max: 2);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("InLvl")]
        public int InputLevel
        {
            get => _inputLevel;
            set => _inputLevel = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("OutLvl")]
        public int OutputLevel
        {
            get => _outputLevel;
            set => _outputLevel = Range.Guard(value);
        }

        public XmlUSBSettings() : this(null) { }
        public XmlUSBSettings(XmlUSBSettings other)
        {
            Mode         = other?.Mode         ?? 0;
            AudioRouting = other?.AudioRouting ?? 0;
            InputLevel   = other?.InputLevel   ?? 50;
            OutputLevel  = other?.OutputLevel  ?? 50;
        }

        public XmlUSBSettings Clone() => new XmlUSBSettings(this);
    }
}
