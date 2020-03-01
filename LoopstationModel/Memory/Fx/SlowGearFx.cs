using System;

namespace Loopstation.Model.Memory.Fx
{
    public class SlowGearFx : ICloneable
    {
        public int Sensitivity { get; set; } = 40;
        public int RiseTime { get; set; } = 50;
        public int Level { get; set; } = 50;

        public SlowGearFx() { }
        public SlowGearFx(SlowGearFx other)
        {
            Sensitivity = other.Sensitivity;
            RiseTime = other.RiseTime;
            Level = other.Level;
        }

        public object Clone() => new SlowGearFx(this);
    }
}
