using System;

namespace Loopstation.Model.Memory.Fx
{
    public class FlangerFx : ICloneable
    {
        // TODO: Rate Default Value 25
        public Rate Rate { get; set; }
        public int Depth { get; set; } = 50;
        public int Resonance { get; set; } = 70;
        // TODO: StepRate Default Value 0
        public StepRate StepRate { get; set; }
        public int Level { get; set; } = 50;

        public FlangerFx() { }
        public FlangerFx(FlangerFx other)
        {
            Rate = other.Rate;
            Depth = other.Depth;
            Resonance = other.Resonance;
            StepRate = other.StepRate;
            Level = other.Level;
        }

        public object Clone() => new FlangerFx(this);
    }
}
