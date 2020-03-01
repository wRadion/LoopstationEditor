using System;

namespace Loopstation.Model.Memory.Fx
{
    public enum RollMode { OFF, HALF, QUARTER, EIGHTH, SIXTEENTH }

    public class RollFx : ICloneable
    {
        // TODO: DelayTime Default Value 1008
        public DelayTime Time { get; set; }
        public RollMode Mode { get; set; } = RollMode.QUARTER;
        public int Feedback { get; set; } = 20;
        public int Level { get; set; } = 50;

        public RollFx() { }
        public RollFx(RollFx other)
        {
            Time = other.Time;
            Mode = other.Mode;
            Feedback = other.Feedback;
            Level = other.Level;
        }


        public object Clone() => new RollFx(this);
    }
}
