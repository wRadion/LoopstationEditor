using System;

namespace Loopstation.Model.Memory.Fx
{
    public class VocoderFx : ICloneable
    {
        public Track Carrier { get; set; } = Track.TRACK1;
        public int ModSens { get; set; } = 50;
        public int Attack { get; set; } = 50;
        // TODO: Balance (0...100) (50:50)
        public int Balance { get; set; } = 50;

        public VocoderFx() { }
        public VocoderFx(VocoderFx other)
        {
            Carrier = other.Carrier;
            ModSens = other.ModSens;
            Attack = other.Attack;
            Balance = other.Balance;
        }

        public object Clone() => new VocoderFx(this);
    }
}
