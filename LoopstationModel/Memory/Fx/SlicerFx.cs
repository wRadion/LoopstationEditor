using Loopstation.Xml.Memory;
using Loopstation.Common.Property;

namespace Loopstation.Model.Memory.Fx
{
    public enum SlicerPattern { P01, P02, P03, P04, P05, P06, P07, P08, P09, P10, P11, P12, P13, P14, P15, P16, P17, P18, P19, P20 }

    public class SlicerFx
    {
        public SlicerPattern Pattern
        {
            get => _patternProperty.Value;
            set => _patternProperty.Value = value;
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

        #region private Fields
        private readonly EnumProperty<SlicerPattern> _patternProperty;
        private readonly EnumProperty<Rate> _rateProperty;
        private readonly IntProperty _depthProperty;

        private readonly XmlFxSettings _xml;
        #endregion private Fields

        public SlicerFx(XmlFxSettings xmlFx)
        {
            #region private Fields initialization
            _xml = xmlFx;

            _patternProperty = _xml.SlicerPattern;
            _rateProperty    = _xml.SlicerRate;
            _depthProperty   = _xml.SlicerDepth;

            _patternProperty.PropertyChanged += (_, e) => _xml.SlicerPattern = e.Value;
            _rateProperty.PropertyChanged    += (_, e) => _xml.SlicerRate = e.Value;
            _depthProperty.PropertyChanged   += (_, e) => _xml.SlicerDepth = e.Value;
            #endregion private Fields initialization
        }
    }
}
