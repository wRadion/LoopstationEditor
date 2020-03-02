using System.Xml.Serialization;

using Loopstation.Xml.Interfaces;
using Loopstation.Xml.Utils;

namespace Loopstation.Xml.Memory
{
    public class XmlBeatFxSettings : ICloneable<XmlBeatFxSettings>
    {
        private int _beatRepeatType;
        private int _beatRepeatLength;
        private int _beatShiftType;
        private int _beatShiftShift;
        private int _beatScatterType;
        private int _beatScatterLength;
        private int _vinylFlick;

        [XmlElement("RepTyp")]
        public int BeatRepeatType
        {
            get => _beatRepeatType;
            set => _beatRepeatType = Range.Guard(value, max: 2);
        }

        [XmlElement("RepLen")]
        public int BeatRepeatLength
        {
            get => _beatRepeatLength;
            set => _beatRepeatLength = Range.Guard(value, max: 6);
        }

        [XmlElement("ShftTyp")]
        public int BeatShiftType
        {
            get => _beatShiftType;
            set => _beatShiftType = Range.Guard(value, max: 1);
        }

        [XmlElement("ShftShft")]
        public int BeatShiftShift
        {
            get => _beatShiftShift;
            set => _beatShiftShift = Range.Guard(value, max: 5);
        }

        [XmlElement("ScatTyp")]
        public int BeatScatterType
        {
            get => _beatScatterType;
            set => _beatScatterType = Range.Guard(value, max: 3);
        }

        [XmlElement("ScatLen")]
        public int BeatScatterLength
        {
            get => _beatScatterLength;
            set => _beatScatterLength = Range.Guard(value, max: 4);
        }

        [XmlElement("Flick")]
        public int VinylFlick
        {
            get => _vinylFlick;
            set => _vinylFlick = Range.Guard(value);
        }

        public XmlBeatFxSettings() : this(null) { }
        public XmlBeatFxSettings(XmlBeatFxSettings other)
        {
            BeatRepeatType = other?.BeatRepeatType ?? 0;
            BeatRepeatLength = other?.BeatRepeatLength ?? 5;
            BeatShiftType = other?.BeatShiftType ?? 0;
            BeatShiftShift = other?.BeatShiftShift ?? 3;
            BeatScatterType = other?.BeatScatterType ?? 0;
            BeatScatterLength = other?.BeatScatterLength ?? 3;
            VinylFlick = other?.VinylFlick ?? 50;
        }

        public XmlBeatFxSettings Clone() => new XmlBeatFxSettings(this);
    }
}
