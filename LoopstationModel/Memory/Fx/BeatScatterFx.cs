using System;

namespace Loopstation.Model.Memory.Fx
{
    public enum BeatScatterType { P1, P2, P3, P4 }
    public enum BeatScatterLength { THRU, HALF_NOTE, QUARTER_NOTE, EIGHTH_NOTE, SIXTEENTH_NOTE }

    public class BeatScatterFx : ICloneable
    {
        public BeatScatterType Type { get; set; } = BeatScatterType.P1;
        public BeatScatterLength Length { get; set; } = BeatScatterLength.EIGHTH_NOTE;

        public BeatScatterFx() { }
        public BeatScatterFx(BeatScatterFx other)
        {
            Type = other.Type;
            Length = other.Length;
        }

        public object Clone() => new BeatScatterFx(this);
    }
}
