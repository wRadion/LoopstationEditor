using Loopstation.Xml.Memory;
using Loopstation.Common.Property;

namespace Loopstation.Model.Memory.Fx
{
    public class PitchBendFx
    {
        public int Octave // TODO: PitchBend Octave (0...7) (-3)
        {
            get => _octaveProperty.Value;
            set => _octaveProperty.Value = value;
        }
        public int Bend
        {
            get => _bendProperty.Value;
            set => _bendProperty.Value = value;
        }

        #region private Fields
        private readonly IntProperty _octaveProperty;
        private readonly IntProperty _bendProperty;

        private readonly XmlFxSettings _xml;
        #endregion private Fields

        public PitchBendFx(XmlFxSettings xmlFx)
        {
            #region private Fields initialization
            _xml = xmlFx;

            _octaveProperty = _xml.PitchBendOctave;
            _bendProperty   = _xml.PitchBendBend;

            _octaveProperty.PropertyChanged += (_, e) => _xml.PitchBendOctave = e.Value;
            _bendProperty.PropertyChanged   += (_, e) => _xml.PitchBendBend = e.Value;
            #endregion private Fields initialization
        }
    }
}
