using System.Xml.Serialization;

using Loopstation.Xml.Interfaces;
using Loopstation.Xml.Utils;

namespace Loopstation.Xml.Memory
{
    [XmlRoot("RHYTHM")]
    public class XmlRhythmSettings : ICloneable<XmlRhythmSettings>
    {
        private int _switch;
        private int _level;
        private int _pattern;
        private int _beat;
        private int _lineOut;
        private int _recCount;
        private int _playCount;
        private int _stopMode;

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
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("Lvl")]
        public int Level
        {
            get => _level;
            set => _level = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>57</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("Ptn")]
        public int Pattern
        {
            get => _pattern;
            set => _pattern = Range.Guard(value, max: 57);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>16</c>.
        /// <para>Default value is <c>2</c>.</para>
        /// </summary>
        [XmlElement("Bt")]
        public int Beat
        {
            get => _beat;
            set => _beat = Range.Guard(value, max: 16);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>1</c>.
        /// <para>Default value is <c>1</c>.</para>
        /// </summary>
        [XmlElement("LineOut")]
        public int LineOut
        {
            get => _lineOut;
            set => _lineOut = Range.Guard(value, max: 1);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>1</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("RecCnt")]
        public int RecCount
        {
            get => _recCount;
            set => _recCount = Range.Guard(value, max: 1);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>1</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("PlyCnt")]
        public int PlayCount
        {
            get => _playCount;
            set => _playCount = Range.Guard(value, max: 1);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>2</c>.
        /// <para>Default value is <c>1</c>.</para>
        /// </summary>
        [XmlElement("Stp")]
        public int StopMode
        {
            get => _stopMode;
            set => _stopMode = Range.Guard(value, max: 2);
        }

        public XmlRhythmSettings() : this(null) { }
        public XmlRhythmSettings(XmlRhythmSettings other)
        {
            Switch    = other?.Switch    ?? 0;
            Level     = other?.Level     ?? 50;
            Pattern   = other?.Pattern   ?? 0;
            Beat      = other?.Beat      ?? 2;
            LineOut   = other?.LineOut   ?? 1;
            RecCount  = other?.RecCount  ?? 0;
            PlayCount = other?.PlayCount ?? 0;
            StopMode  = other?.StopMode  ?? 1;
        }

        public XmlRhythmSettings Clone() => new XmlRhythmSettings(this);
    }
}
