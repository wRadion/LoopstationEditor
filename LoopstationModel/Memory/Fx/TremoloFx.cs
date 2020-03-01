using System;

namespace Loopstation.Model.Memory.Fx
{
    public class TremoloFx : ICloneable
    {
        // TODO: Rate Default Value 85
        public Rate Rate { get; set; }
        public int Depth { get; set; } = 50;
        public int Level { get; set; } = 50;

        public TremoloFx() { }
        public TremoloFx(TremoloFx other)
        {
            Rate = other.Rate;
            Depth = other.Depth;
            Level = other.Level;
        }

        public object Clone() => new TremoloFx(this);
    }
}
