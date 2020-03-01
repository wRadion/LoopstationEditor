using System;

namespace Loopstation.Model.Memory.Fx
{
    public class ReverbFx : ICloneable
    {
        // TODO: Reverb Time (1...100) /10 (sec)
        public int Time { get; set; } = 27;
        public int Level { get; set; } = 50;
        public int DryLevel { get; set; } = 100;

        public ReverbFx() { }
        public ReverbFx(ReverbFx other)
        {
            Time = other.Time;
            Level = other.Level;
            DryLevel = other.DryLevel;
        }

        public object Clone() => new ReverbFx(this);
    }
}
