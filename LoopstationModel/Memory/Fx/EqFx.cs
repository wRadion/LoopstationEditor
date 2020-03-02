using Loopstation.Xml.Memory;
using Loopstation.Common.Property;

namespace Loopstation.Model.Memory.Fx
{
    public class EqFx
    {
        public int Low // TODO: Eq/Comp (0...40) -20
        {
            get => _lowProperty.Value;
            set => _lowProperty.Value = value;
        }
        public int LowMid // TODO: Eq/Comp (0...40) -20
        {
            get => _lowMidProperty.Value;
            set => _lowMidProperty.Value = value;
        }
        public int HighMid // TODO: Eq/Comp (0...40) -20
        {
            get => _highMidProperty.Value;
            set => _highMidProperty.Value = value;
        }
        public int High // TODO: Eq/Comp (0...40) -20
        {
            get => _highProperty.Value;
            set => _highProperty.Value = value;
        }
        public int Level // TODO: Eq/Comp (0...40) -20
        {
            get => _levelProperty.Value;
            set => _levelProperty.Value = value;
        }

        #region private Fields
        private readonly IntProperty _lowProperty;
        private readonly IntProperty _lowMidProperty;
        private readonly IntProperty _highMidProperty;
        private readonly IntProperty _highProperty;
        private readonly IntProperty _levelProperty;

        private readonly XmlFxSettings _xml;
        #endregion private Fields

        public EqFx(XmlFxSettings xmlFx)
        {
            #region private Fields initialization
            _xml = xmlFx;

            _lowProperty     = _xml.EqLow;
            _lowMidProperty  = _xml.EqLowMid;
            _highMidProperty = _xml.EqHighMid;
            _highProperty    = _xml.EqHigh;
            _levelProperty   = _xml.EqLevel;

            _lowProperty.PropertyChanged     += (_, e) => _xml.EqLow = e.Value;
            _lowMidProperty.PropertyChanged  += (_, e) => _xml.EqLowMid = e.Value;
            _highMidProperty.PropertyChanged += (_, e) => _xml.EqHighMid = e.Value;
            _highProperty.PropertyChanged    += (_, e) => _xml.EqHigh = e.Value;
            _levelProperty.PropertyChanged   += (_, e) => _xml.EqLevel = e.Value;
            #endregion private Fields initialization
        }
    }
}
