using System;

namespace Loopstation.Model.Memory.Fx
{
    public class EqFx : ICloneable
    {
        // TODO: Eq/Comp (0...40) -20
        public int Low { get; set; } = 20;
        // TODO: Eq/Comp (0...40) -20
        public int LowMid { get; set; } = 20;
        // TODO: Eq/Comp (0...40) -20
        public int HighMid { get; set; } = 20;
        // TODO: Eq/Comp (0...40) -20
        public int High { get; set; } = 20;
        // TODO: Eq/Comp (0...40) -20
        public int Level { get; set; } = 20;

        public EqFx() { }
        public EqFx(EqFx other)
        {
            Low = other.Low;
            LowMid = other.LowMid;
            HighMid = other.HighMid;
            High = other.High;
            Level = other.Level;
        }

        public object Clone() => new EqFx(this);
    }
}
