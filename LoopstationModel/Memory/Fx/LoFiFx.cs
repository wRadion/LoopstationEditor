using System;

namespace Loopstation.Model.Memory.Fx
{
    public class LoFiFx : ICloneable
    {
        // TODO: LoFi Depth [MIX] (OFF...15) (16 - i)
        public int Depth { get; set; } = 8;
        // TODO: LoFi SampleRate [MIX] (OFF...31) ("1/{i+1}")
        public int SampleRate { get; set; } = 15;
        // TODO: Balance (0...100) (50:50)
        public int Balance { get; set; } = 50;

        public LoFiFx() { }
        public LoFiFx(LoFiFx other)
        {
            Depth = other.Depth;
            SampleRate = other.SampleRate;
            Balance = other.Balance;
        }

        public object Clone() => new LoFiFx(this);
    }
}
