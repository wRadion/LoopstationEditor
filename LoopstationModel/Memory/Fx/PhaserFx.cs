using Loopstation.Xml.Memory;
using Loopstation.Common.Property;

namespace Loopstation.Model.Memory.Fx
{
    public class PhaserFx
    {
        public Rate Rate
        {
            get => _rateProperty.Value;
            set => _rateProperty.Value = value;
        }
        public int Depth
        {
            get => _depthProperty.Value;
            set => _depthProperty.Value = value;
        }
        public int Resonance
        {
            get => _resonanceProperty.Value;
            set => _resonanceProperty.Value = value;
        }
        public StepRate StepRate
        {
            get => _stepRateProperty.Value;
            set => _stepRateProperty.Value = value;
        }
        public int Level
        {
            get => _levelProperty.Value;
            set => _levelProperty.Value = value;
        }

        #region private Fields
        private readonly EnumProperty<Rate> _rateProperty;
        private readonly IntProperty _depthProperty;
        private readonly IntProperty _resonanceProperty;
        private readonly EnumProperty<StepRate> _stepRateProperty;
        private readonly IntProperty _levelProperty;

        private readonly XmlFxSettings _xml;
        #endregion private Fields

        public PhaserFx(XmlFxSettings xmlFx)
        {
            #region private Fields initialization
            _xml = xmlFx;

            _rateProperty      = _xml.PhaserRate;
            _depthProperty     = _xml.PhaserDepth;
            _resonanceProperty = _xml.PhaserResonance;
            _stepRateProperty  = _xml.PhaserStepRate;
            _levelProperty     = _xml.PhaserLevel;

            _rateProperty.PropertyChanged      += (_, e) => _xml.PhaserRate = e.Value;
            _depthProperty.PropertyChanged     += (_, e) => _xml.PhaserDepth = e.Value;
            _resonanceProperty.PropertyChanged += (_, e) => _xml.PhaserResonance = e.Value;
            _stepRateProperty.PropertyChanged  += (_, e) => _xml.PhaserStepRate = e.Value;
            _levelProperty.PropertyChanged     += (_, e) => _xml.PhaserLevel = e.Value;
            #endregion private Fields initialization
        }
    }
}
