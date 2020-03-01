using System;

namespace Loopstation.Model.Memory.Fx
{
    public enum DynamicsType
    {
        NATURAL_COMP, MIXER_COMP, LIVE_COMP, NATURAL_LIM, HARD_LIM,
        JINGL_COMP, HARD_COMP, SOFT_COMP, CLEAN_COMP, DANCE_COMP, ORCH_COMP,
        VOCAL_COMP, ACOUSTIC, ROCK_BAND, ORCHESTRA, LOW_BOOST, BRIGHTEN, DJs_VOICE, PHONE_VOX
    }

    public class DynamicsFx : ICloneable
    {
        public DynamicsType Type { get; set; } = DynamicsType.NATURAL_COMP;
        // TODO: Eq/Comp (0...40) -20
        public int Dynamics { get; set; } = 20;

        public DynamicsFx() { }
        public DynamicsFx(DynamicsFx other)
        {
            Type = other.Type;
            Dynamics = other.Dynamics;
        }

        public object Clone() => new DynamicsFx(this);
    }
}
