using System;
using System.Xml.Serialization;

namespace Loopstation.Xml.Memory
{
    [XmlRoot("RHYTHM")]
    public class XmlRhythmSettings : ICloneable
    {
        [XmlElement("Sw")]
        public int Switch { get; set; } = 0;

        [XmlElement("Lvl")]
        public int Volume { get; set; } = 50;

        [XmlElement("Ptn")]
        public int Pattern { get; set; } = 0;

        [XmlElement("Bt")]
        public int Beat { get; set; } = 2;

        [XmlElement("LineOut")]
        public int LineOut { get; set; } = 1;

        [XmlElement("RecCnt")]
        public int RecCount { get; set; } = 0;

        [XmlElement("PlyCnt")]
        public int PlayCount { get; set; } = 0;

        [XmlElement("Stp")]
        public int StopMode { get; set; } = 1;

        public XmlRhythmSettings() { }
        public XmlRhythmSettings(XmlRhythmSettings other)
        {
            if (other == null) return;

            Switch = other.Switch;
            Volume = other.Volume;
            Pattern = other.Pattern;
            Beat = other.Beat;
            LineOut = other.LineOut;
            RecCount = other.RecCount;
            PlayCount = other.PlayCount;
            StopMode = other.StopMode;
        }

        public object Clone() => new XmlRhythmSettings(this);
    }
}
