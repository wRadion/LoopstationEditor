using Loopstation.Xml.Memory;
using Loopstation.Common.Property;

namespace Loopstation.Model.Memory.Fx
{
    public class TremoloFx
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
        public int Level
        {
            get => _levelProperty.Value;
            set => _levelProperty.Value = value;
        }

        #region private Fields
        private readonly EnumProperty<Rate> _rateProperty;
        private readonly IntProperty _depthProperty;
        private readonly IntProperty _levelProperty;

        private readonly XmlFxSettings _xml;
        #endregion private Fields

        public TremoloFx(XmlFxSettings xmlFx)
        {
            #region private Fields initialization
            _xml = xmlFx;

            _rateProperty  = _xml.TremoloRate;
            _depthProperty = _xml.TremoloDepth;
            _levelProperty = _xml.TremoloLevel;

            _rateProperty.PropertyChanged  += (_, e) => _xml.TremoloRate = e.Value;
            _depthProperty.PropertyChanged += (_, e) => _xml.TremoloDepth = e.Value;
            _levelProperty.PropertyChanged += (_, e) => _xml.TremoloLevel = e.Value;
            #endregion private Fields initialization
        }
    }
}
