using System;
using System.Xml.Serialization;

namespace Loopstation.Xml.Memory
{
    public class XmlBeatFxSettings : ICloneable
    {
        [XmlElement("RepTyp")]
        public int BeatRepeatType { get; set; } = 0;

        [XmlElement("RepLen")]
        public int BeatRepeatLength { get; set; } = 5;

        [XmlElement("ShftTyp")]
        public int BeatShiftType { get; set; } = 0;

        [XmlElement("ShftShft")]
        public int BeatShiftShift { get; set; } = 3;

        [XmlElement("ScatTyp")]
        public int BeatScatterType { get; set; } = 0;

        [XmlElement("ScatLen")]
        public int BeatScatterLength { get; set; } = 3;

        [XmlElement("Flick")]
        public int VinylFlick { get; set; } = 50;

        public XmlBeatFxSettings() { }
        public XmlBeatFxSettings(XmlBeatFxSettings other)
        {
            if (other == null) return;

            BeatRepeatType = other.BeatRepeatType;
            BeatRepeatLength = other.BeatRepeatLength;
            BeatShiftType = other.BeatShiftType;
            BeatShiftShift = other.BeatShiftShift;
            BeatScatterType = other.BeatScatterType;
            BeatScatterLength = other.BeatScatterLength;
            VinylFlick = other.VinylFlick;
        }

        public object Clone() => new XmlBeatFxSettings(this);
    }
}
