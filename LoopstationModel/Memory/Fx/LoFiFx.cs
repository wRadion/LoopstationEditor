using Loopstation.Xml.Memory;
using Loopstation.Common.Property;

namespace Loopstation.Model.Memory.Fx
{
    public enum LoFiDepth      { OFF }
    public enum LoFiSampleRate { OFF }

    public class LoFiFx
    {
        public object Depth // TODO: LoFi Depth [MIX] (OFF...15) (16 - i)
        {
            get => _depthProperty.Value;
            set => _depthProperty.Value = value;
        }
        public object SampleRate // TODO: LoFi SampleRate [MIX] (OFF...31) ("1/{i+1}")
        {
            get => _sampleRateProperty.Value;
            set => _sampleRateProperty.Value = value;
        }
        public int Balance // TODO: Balance (0...100) (50:50)
        {
            get => _balanceProperty.Value;
            set => _balanceProperty.Value = value;
        }

        #region private Fields
        private readonly MixedProperty<LoFiDepth> _depthProperty;
        private readonly MixedProperty<LoFiSampleRate> _sampleRateProperty;
        private readonly IntProperty _balanceProperty;

        private readonly XmlFxSettings _xml;
        #endregion private Fields

        public LoFiFx(XmlFxSettings xmlFx)
        {
            #region private Fields initialization
            _xml = xmlFx;

            _depthProperty      = _xml.LoFiDepth;
            _sampleRateProperty = _xml.LoFiSampleRate;
            _balanceProperty    = _xml.LoFiBalance;

            _depthProperty.PropertyChanged      += (_, e) => _xml.LoFiDepth = e.Value;
            _sampleRateProperty.PropertyChanged += (_, e) => _xml.LoFiSampleRate = e.Value;
            _balanceProperty.PropertyChanged    += (_, e) => _xml.LoFiBalance = e.Value;
            #endregion private Fields initialization
        }
    }
}
