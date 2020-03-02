using Loopstation.Xml.Memory;
using Loopstation.Common.Property;

namespace Loopstation.Model.Memory.Fx
{
    public enum DynamicsType
    {
        NATURAL_COMP, MIXER_COMP, LIVE_COMP, NATURAL_LIM, HARD_LIM,
        JINGL_COMP, HARD_COMP, SOFT_COMP, CLEAN_COMP, DANCE_COMP, ORCH_COMP,
        VOCAL_COMP, ACOUSTIC, ROCK_BAND, ORCHESTRA, LOW_BOOST, BRIGHTEN, DJs_VOICE, PHONE_VOX
    }

    public class DynamicsFx
    {
        public DynamicsType Type
        {
            get => _typeProperty.Value;
            set => _typeProperty.Value = value;
        }
        public int Dynamics // TODO: Eq/Comp (0...40) -20
        {
            get => _dynamicsProperty.Value;
            set => _dynamicsProperty.Value = value;
        }

        #region private Fields
        private readonly EnumProperty<DynamicsType> _typeProperty;
        private readonly IntProperty _dynamicsProperty;

        private readonly XmlFxSettings _xml;
        #endregion private Fields

        public DynamicsFx(XmlFxSettings xmlFx)
        {
            #region private Fields initialization
            _xml = xmlFx;

            _typeProperty     = _xml.DynamicsType;
            _dynamicsProperty = _xml.DynamicsDynamics;

            _typeProperty.PropertyChanged     += (_, e) => _xml.DynamicsType = e.Value;
            _dynamicsProperty.PropertyChanged += (_, e) => _xml.DynamicsDynamics = e.Value;
            #endregion private Fields initialization
        }
    }
}
