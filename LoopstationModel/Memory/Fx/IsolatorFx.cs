using Loopstation.Xml.Memory;
using Loopstation.Common.Property;

namespace Loopstation.Model.Memory.Fx
{
    public enum IsolatorBand { LOW, MID, HIGH }

    public class IsolatorFx
    {
        public IsolatorBand Band
        {
            get => _bandProperty.Value;
            set => _bandProperty.Value = value;
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
        private readonly EnumProperty<IsolatorBand> _bandProperty;
        private readonly EnumProperty<Rate> _rateProperty;
        private readonly IntProperty _depthProperty;
        private readonly EnumProperty<StepRate> _stepRateProperty;
        private readonly IntProperty _levelProperty;

        private readonly XmlFxSettings _xml;
        #endregion private Fields

        public IsolatorFx(XmlFxSettings xmlFx)
        {
            #region private Fields initialization
            _xml = xmlFx;

            _bandProperty     = _xml.IsolatorBand;
            _rateProperty     = _xml.IsolatorRate;
            _depthProperty    = _xml.IsolatorDepth;
            _stepRateProperty = _xml.IsolatorStepRate;
            _levelProperty    = _xml.IsolatorLevel;

            _bandProperty.PropertyChanged     += (_, e) => _xml.IsolatorBand = e.Value;
            _rateProperty.PropertyChanged     += (_, e) => _xml.IsolatorRate = e.Value;
            _depthProperty.PropertyChanged    += (_, e) => _xml.IsolatorDepth = e.Value;
            _stepRateProperty.PropertyChanged += (_, e) => _xml.IsolatorStepRate = e.Value;
            _levelProperty.PropertyChanged    += (_, e) => _xml.IsolatorLevel = e.Value;
            #endregion private Fields initialization
        }
    }
}
