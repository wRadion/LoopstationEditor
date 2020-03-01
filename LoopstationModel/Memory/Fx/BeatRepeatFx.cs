using System;

namespace Loopstation.Model.Memory.Fx
{
    public enum BeatRepeatType { FORWARD, REWIND, MIX }
    public enum BeatRepeatLength { THRU, WHOLE_NOTE, HALF_NOTE, QUARTER_NOTE, EIGHTH_NOTE, SIXTEENTH_NOTE, THIRTYSECOND_NOTE }

    public class BeatRepeatFx : ICloneable
    {
        public BeatRepeatType Type { get; set; } = BeatRepeatType.FORWARD;
        public BeatRepeatLength Length { get; set; } = BeatRepeatLength.SIXTEENTH_NOTE;

        public BeatRepeatFx() { }
        public BeatRepeatFx(BeatRepeatFx other)
        {
            Type = other.Type;
            Length = other.Length;
        }

        public object Clone() => new BeatRepeatFx(this);
    }
}
