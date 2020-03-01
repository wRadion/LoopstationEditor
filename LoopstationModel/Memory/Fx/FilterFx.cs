using System;

namespace Loopstation.Model.Memory.Fx
{
    public enum FilterType { LPF, BPF, HPF }

    public class FilterFx : ICloneable
    {
        public FilterType Type { get; set; } = FilterType.LPF;
        // TODO: Rate Default Value 50
        public Rate Rate { get; set; }
        public int Depth { get; set; } = 55;
        public int Resonance { get; set; } = 50;
        public int Cutoff { get; set; } = 50;
        // TODO: StepRate Default Value 0
        public StepRate StepRate { get; set; }

        public FilterFx() { }
        public FilterFx(FilterFx other)
        {
            Type = other.Type;
            Rate = other.Rate;
            Depth = other.Depth;
            Resonance = other.Resonance;
            Cutoff = other.Cutoff;
            StepRate = other.StepRate;
        }

        public object Clone() => new FilterFx(this);
    }
}
