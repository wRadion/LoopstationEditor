using System;

namespace Loopstation.Model.Memory.Fx
{
    public class VocalDistFx : ICloneable
    {
        public int Distortion { get; set; } = 50;
        // TODO: VocalDist Tone (0...100) -50
        public int Tone { get; set; } = 50;
        public int Level { get; set; } = 50;

        public VocalDistFx() { }
        public VocalDistFx(VocalDistFx other)
        {
            Distortion = other.Distortion;
            Tone = other.Tone;
            Level = other.Level;
        }

        public object Clone() => new VocalDistFx(this);
    }
}
