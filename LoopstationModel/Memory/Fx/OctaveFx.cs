using System;

namespace Loopstation.Model.Memory.Fx
{
    public enum OctaveMode { MINUS_1_OCT, MINUS_2_OCT, BOTH }

    public class OctaveFx : ICloneable
    {
        public OctaveMode Mode { get; set; } = OctaveMode.MINUS_1_OCT;
        public int Level { get; set; } = 50;

        public OctaveFx() { }
        public OctaveFx(OctaveFx other)
        {
            Mode = other.Mode;
            Level = other.Level;
        }

        public object Clone() => new OctaveFx(this);
    }
}
