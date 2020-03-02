using Loopstation.Xml.Memory;
using Loopstation.Common.Property;

namespace Loopstation.Model.Memory.Fx
{
    public class VocalDistFx
    {
        public int Distortion
        {
            get => _distortionProperty.Value;
            set => _distortionProperty.Value = value;
        }
        public int Tone // TODO: VocalDist Tone (0...100) -50
        {
            get => _toneProperty.Value;
            set => _toneProperty.Value = value;
        }
        public int Level
        {
            get => _levelProperty.Value;
            set => _levelProperty.Value = value;
        }

        #region private Fields
        private readonly IntProperty _distortionProperty;
        private readonly IntProperty _toneProperty;
        private readonly IntProperty _levelProperty;

        private readonly XmlFxSettings _xml;
        #endregion private Fields

        public VocalDistFx(XmlFxSettings xmlFx)
        {
            #region private Fields initialization
            _xml = xmlFx;

            _distortionProperty = _xml.VocalDistDistortion;
            _toneProperty       = _xml.VocalDistTone;
            _levelProperty      = _xml.VocalDistLevel;

            _distortionProperty.PropertyChanged += (_, e) => _xml.VocalDistDistortion = e.Value;
            _toneProperty.PropertyChanged       += (_, e) => _xml.VocalDistTone = e.Value;
            _levelProperty.PropertyChanged      += (_, e) => _xml.VocalDistLevel = e.Value;
            #endregion private Fields initialization
        }
    }
}
