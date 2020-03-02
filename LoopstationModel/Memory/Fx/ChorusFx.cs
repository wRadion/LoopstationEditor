using Loopstation.Xml.Memory;
using Loopstation.Common.Property;

namespace Loopstation.Model.Memory.Fx
{
    public class ChorusFx
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

        public ChorusFx(XmlFxSettings xmlFx)
        {
            #region private Fields initialization
            _xml = xmlFx;

            _rateProperty  = _xml.ChorusRate;
            _depthProperty = _xml.ChorusDepth;
            _levelProperty = _xml.ChorusLevel;

            _rateProperty.PropertyChanged  += (_, e) => _xml.ChorusRate = e.Value;
            _depthProperty.PropertyChanged += (_, e) => _xml.ChorusDepth = e.Value;
            _levelProperty.PropertyChanged += (_, e) => _xml.ChorusLevel = e.Value;
            #endregion private Fields initialization
        }
    }
}
