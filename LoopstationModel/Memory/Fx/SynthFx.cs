using System;

namespace Loopstation.Model.Memory.Fx
{
    public class SynthFx : ICloneable
    {
        public int Frequency { get; set; } = 50;
        public int Resonance { get; set; } = 50;
        public int Decay { get; set; } = 50;
        // TODO: Balance (0...100) (50:50)
        public int Balance { get; set; } = 90;

        public SynthFx() { }
        public SynthFx(SynthFx other)
        {
            Frequency = other.Frequency;
            Resonance = other.Resonance;
            Decay = other.Decay;
            Balance = other.Balance;
        }

        public object Clone() => new SynthFx(this);
    }
}
