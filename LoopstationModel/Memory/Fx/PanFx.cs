using Loopstation.Xml.Memory;
using Loopstation.Common.Property;

namespace Loopstation.Model.Memory.Fx
{
    public enum PanType { AUTO1, AUTO2, MANUAL }

    public class PanFx
    {
        public PanType Type
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
        public StepRate StepRate
        {
            get => _stepRateProperty.Value;
            set => _stepRateProperty.Value = value;
        }
        public int Position // TODO: Pan Position (0...100) -50
        {
            get => _positionProperty.Value;
            set => _positionProperty.Value = value;
        }

        #region private Fields
        private readonly EnumProperty<PanType> _typeProperty;
        private readonly EnumProperty<Rate> _rateProperty;
        private readonly IntProperty _depthProperty;
        private readonly EnumProperty<StepRate> _stepRateProperty;
        private readonly IntProperty _positionProperty;

        private readonly XmlFxSettings _xml;
        #endregion private Fields

        public PanFx(XmlFxSettings xmlFx)
        {
            #region private Fields initialization
            _xml = xmlFx;

            _typeProperty     = _xml.PanType;
            _rateProperty     = _xml.PanRate;
            _depthProperty    = _xml.PanDepth;
            _stepRateProperty = _xml.PanStepRate;
            _positionProperty = _xml.PanPosition;

            _typeProperty.PropertyChanged     += (_, e) => _xml.PanType = e.Value;
            _rateProperty.PropertyChanged     += (_, e) => _xml.PanRate = e.Value;
            _depthProperty.PropertyChanged    += (_, e) => _xml.PanDepth = e.Value;
            _stepRateProperty.PropertyChanged += (_, e) => _xml.PanStepRate = e.Value;
            _positionProperty.PropertyChanged += (_, e) => _xml.PanPosition = e.Value;
            #endregion private Fields initialization
        }
    }
}
