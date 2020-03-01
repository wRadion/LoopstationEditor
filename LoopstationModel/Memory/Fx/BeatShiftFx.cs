using System;

namespace Loopstation.Model.Memory.Fx
{
    public enum BeatShiftType { FUTURE, PAST }
    public enum BeatShiftShift { THRU, SIXTEENTH_NOTE, EIGHTH_NOTE, QUARTER_NOTE, HALF_NOTE, WHOLE_NOTE }

    public class BeatShiftFx : ICloneable
    {
        public BeatShiftType Type { get; set; } = BeatShiftType.FUTURE;
        public BeatShiftShift Shift { get; set; } = BeatShiftShift.QUARTER_NOTE;

        public BeatShiftFx() { }
        public BeatShiftFx(BeatShiftFx other)
        {
            Type = other.Type;
            Shift = other.Shift;
        }

        public object Clone() => new BeatShiftFx(this);
    }
}
