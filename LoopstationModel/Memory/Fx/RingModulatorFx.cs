using System;

namespace Loopstation.Model.Memory.Fx
{
    public class RingModulatorFx : ICloneable
    {
        public int Frequency { get; set; } = 50;
        // TODO: Balance (0...100) (50:50)
        public int Balance { get; set; } = 100;

        public RingModulatorFx() { }
        public RingModulatorFx(RingModulatorFx other)
        {
            Frequency = other.Frequency;
            Balance = other.Balance;
        }

        public object Clone() => new RingModulatorFx(this);
    }
}
