using Loopstation.Xml.Memory;
using Loopstation.Common.Property;

namespace Loopstation.Model.Memory.Fx
{
    public enum FilterType { LPF, BPF, HPF }

    public class FilterFx
    {
        public FilterType Type
        {
            get => _typeProperty.Value;
            set => _typeProperty.Value = value;
        }
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
        public int Cutoff
        {
            get => _cutoffProperty.Value;
            set => _cutoffProperty.Value = value;
        }
        public StepRate StepRate
        {
            get => _stepRateProperty.Value;
            set => _stepRateProperty.Value = value;
        }

        #region private Fields
        private readonly EnumProperty<FilterType> _typeProperty;
        private readonly EnumProperty<Rate> _rateProperty;
        private readonly IntProperty _depthProperty;
        private readonly IntProperty _resonanceProperty;
        private readonly IntProperty _cutoffProperty;
        private readonly EnumProperty<StepRate> _stepRateProperty;

        private readonly XmlFxSettings _xml;
        #endregion private Fields

        public FilterFx(XmlFxSettings xmlFx)
        {
            #region private Fields initialization
            _xml = xmlFx;

            _typeProperty      = _xml.FilterType;
            _rateProperty      = _xml.FilterRate;
            _depthProperty     = _xml.FilterDepth;
            _resonanceProperty = _xml.FilterResonance;
            _cutoffProperty    = _xml.FilterCutoff;
            _stepRateProperty  = _xml.FilterStepRate;

            _typeProperty.PropertyChanged      += (_, e) => _xml.FilterType = e.Value;
            _rateProperty.PropertyChanged      += (_, e) => _xml.FilterRate = e.Value;
            _depthProperty.PropertyChanged     += (_, e) => _xml.FilterDepth = e.Value;
            _resonanceProperty.PropertyChanged += (_, e) => _xml.FilterResonance = e.Value;
            _cutoffProperty.PropertyChanged    += (_, e) => _xml.FilterCutoff = e.Value;
            _stepRateProperty.PropertyChanged  += (_, e) => _xml.FilterStepRate = e.Value;
            #endregion private Fields initialization
        }
    }
}
