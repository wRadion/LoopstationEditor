using System;

namespace Loopstation.Model.Memory.Fx
{
    public enum IsolatorBand { LOW, MID, HIGH }

    public class IsolatorFx : ICloneable
    {
        public IsolatorBand Band { get; set; } = IsolatorBand.LOW;
        // TODO: Rate Default Value 103
        public Rate Rate { get; set; }
        public int Depth { get; set; } = 100;
        // TODO: StepRate Default Value 0
        public StepRate StepRate { get; set; }
        public int Level { get; set; } = 100;

        public IsolatorFx() { }
        public IsolatorFx(IsolatorFx other)
        {
            Band = other.Band;
            Rate = other.Rate;
            Depth = other.Depth;
            StepRate = other.StepRate;
            Level = other.Level;
        }

        public object Clone() => new IsolatorFx(this);
    }
}
