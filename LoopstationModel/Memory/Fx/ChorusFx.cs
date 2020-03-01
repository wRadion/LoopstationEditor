using System;

namespace Loopstation.Model.Memory.Fx
{
    public class ChorusFx : ICloneable
    {
        // TODO: Rate Default Value 50
        public Rate Rate { get; set; }
        public int Depth { get; set; } = 50;
        public int Level { get; set; } = 50;

        public ChorusFx() { }
        public ChorusFx(ChorusFx other)
        {
            Rate = other.Rate;
            Depth = other.Depth;
            Level = other.Level;
        }

        public object Clone() => new ChorusFx(this);
    }
}
