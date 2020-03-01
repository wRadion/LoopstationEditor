using System;

namespace Loopstation.Model.Memory.Fx
{
    public class PanningDelayFx : ICloneable
    {
        // TODO: DelayTime Default Value 200
        public DelayTime Time { get; set; }
        public int Feedback { get; set; } = 20;
        public int Level { get; set; } = 50;

        public PanningDelayFx() { }
        public PanningDelayFx(PanningDelayFx other)
        {
            Time = other.Time;
            Feedback = other.Feedback;
            Level = other.Level;
        }

        public object Clone() => new PanningDelayFx(this);
    }
}
