using System;

namespace Loopstation.Model.Memory.Fx
{
    public class TransposeFx : ICloneable
    {
        // TODO: Transpose Semitones (0...24) (-12)
        public int Semitones { get; set; } = 12;

        public TransposeFx() { }
        public TransposeFx(TransposeFx other)
        {
            Semitones = other.Semitones;
        }

        public object Clone() => new TransposeFx(this);
    }
}
