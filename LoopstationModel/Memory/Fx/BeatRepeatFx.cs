using Loopstation.Xml.Memory;
using Loopstation.Common;

namespace Loopstation.Model.Memory.Fx
{
    public enum BeatRepeatType   { FORWARD, REWIND, MIX }
    public enum BeatRepeatLength { THRU, WHOLE_NOTE, HALF_NOTE, QUARTER_NOTE, EIGHTH_NOTE, SIXTEENTH_NOTE, THIRTYSECOND_NOTE }

    public class BeatRepeatFx : ICloneable<BeatRepeatFx>
    {
        public   BeatRepeatType Type   { get; set; }
        public BeatRepeatLength Length { get; set; }

        public BeatRepeatFx(XmlBeatFxSettings xmlBeatFx)
        {
            Type   = (BeatRepeatType)xmlBeatFx.BeatRepeatType;
            Length = (BeatRepeatLength)xmlBeatFx.BeatRepeatLength;
        }
        public BeatRepeatFx(BeatRepeatFx other)
        {
            Type   = other.Type;
            Length = other.Length;
        }

        public BeatRepeatFx Clone() => new BeatRepeatFx(this);
    }
}
