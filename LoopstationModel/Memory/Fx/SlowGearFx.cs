using Loopstation.Xml.Memory;
using Loopstation.Common.Property;

namespace Loopstation.Model.Memory.Fx
{
    public class SlowGearFx
    {
        public int Sensitivity
        {
            get => _sensitivityProperty.Value;
            set => _sensitivityProperty.Value = value;
        }
        public int RiseTime
        {
            get => _riseTimeProperty.Value;
            set => _riseTimeProperty.Value = value;
        }
        public int Level
        {
            get => _levelProperty.Value;
            set => _levelProperty.Value = value;
        }

        #region private Fields
        private readonly IntProperty _sensitivityProperty;
        private readonly IntProperty _riseTimeProperty;
        private readonly IntProperty _levelProperty;

        private readonly XmlFxSettings _xml;
        #endregion private Fields

        public SlowGearFx(XmlFxSettings xmlFx)
        {
            #region private Fields initialization
            _xml = xmlFx;

            _sensitivityProperty = _xml.SlowGearSensitivity;
            _riseTimeProperty    = _xml.SlowGearRiseTime;
            _levelProperty       = _xml.SlowGearLevel;

            _sensitivityProperty.PropertyChanged += (_, e) => _xml.SlowGearSensitivity = e.Value;
            _riseTimeProperty.PropertyChanged    += (_, e) => _xml.SlowGearRiseTime = e.Value;
            _levelProperty.PropertyChanged       += (_, e) => _xml.SlowGearLevel = e.Value;
            #endregion private Fields initialization
        }
    }
}
