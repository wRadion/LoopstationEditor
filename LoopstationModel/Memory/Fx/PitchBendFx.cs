using System;

namespace Loopstation.Model.Memory.Fx
{
    public class PitchBendFx : ICloneable
    {
        // TODO: PitchBend Octave (0...7) (-3)
        public int Octave { get; set; } = 2;
        public int Bend { get; set; } = 100;

        public PitchBendFx() { }
        public PitchBendFx(PitchBendFx other)
        {
            Octave = other.Octave;
            Bend = other.Bend;
        }

        public object Clone() => new PitchBendFx(this);
    }
}
