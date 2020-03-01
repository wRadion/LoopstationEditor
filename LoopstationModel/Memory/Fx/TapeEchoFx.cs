using System;

namespace Loopstation.Model.Memory.Fx
{
    public class TapeEchoFx : ICloneable
    {
        public int Rate { get; set; } = 50;
        public int Intensity { get; set; } = 50;
        public int Level { get; set; } = 50;

        public TapeEchoFx() { }
        public TapeEchoFx(TapeEchoFx other)
        {
            Rate = other.Rate;
            Intensity = other.Intensity;
            Level = other.Level;
        }

        public object Clone() => new TapeEchoFx(this);
    }
}
