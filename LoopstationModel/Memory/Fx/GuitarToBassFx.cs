using System;

namespace Loopstation.Model.Memory.Fx
{
    public class GuitarToBassFx : ICloneable
    {
        // TODO: Balance (0...100) (50:50)
        public int Balance { get; set; } = 50;

        public GuitarToBassFx() { }
        public GuitarToBassFx(GuitarToBassFx other)
        {
            Balance = other.Balance;
        }

        public object Clone() => new GuitarToBassFx(this);
    }
}
