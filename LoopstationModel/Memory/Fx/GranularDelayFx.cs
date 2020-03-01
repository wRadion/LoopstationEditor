using System;

namespace Loopstation.Model.Memory.Fx
{
    public class GranularDelayFx : ICloneable
    {
        public int Time { get; set; } = 50;
        public int Feedback { get; set; } = 70;
        public int Level { get; set; } = 50;

        public GranularDelayFx() { }
        public GranularDelayFx(GranularDelayFx other)
        {
            Time = other.Time;
            Feedback = other.Feedback;
            Level = other.Level;
        }

        public object Clone() => new GranularDelayFx(this);
    }
}
