using System;

namespace Loopstation.Model.Memory.Fx
{
    public class VinylFlickFx : ICloneable
    {
        public int Flick { get; set; } = 50;

        public VinylFlickFx() { }
        public VinylFlickFx(VinylFlickFx other)
        {
            Flick = other.Flick;
        }

        public object Clone() => new VinylFlickFx(this);
    }
}
