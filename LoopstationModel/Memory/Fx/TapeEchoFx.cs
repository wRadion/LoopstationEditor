using Loopstation.Xml.Memory;
using Loopstation.Common.Property;

namespace Loopstation.Model.Memory.Fx
{
    public class TapeEchoFx
    {
        public int Rate
        {
            get => _rateProperty.Value;
            set => _rateProperty.Value = value;
        }
        public int Intensity
        {
            get => _intensityProperty.Value;
            set => _intensityProperty.Value = value;
        }
        public int Level
        {
            get => _levelProperty.Value;
            set => _levelProperty.Value = value;
        }

        #region private Fields
        private readonly IntProperty _rateProperty;
        private readonly IntProperty _intensityProperty;
        private readonly IntProperty _levelProperty;

        private readonly XmlFxSettings _xml;
        #endregion private Fields

        public TapeEchoFx(XmlFxSettings xmlFx)
        {
            #region private Fields initialization
            _xml = xmlFx;

            _rateProperty      = _xml.TapeEchoRate;
            _intensityProperty = _xml.TapeEchoIntensity;
            _levelProperty     = _xml.TapeEchoLevel;

            _rateProperty.PropertyChanged      += (_, e) => _xml.TapeEchoRate = e.Value;
            _intensityProperty.PropertyChanged += (_, e) => _xml.TapeEchoIntensity = e.Value;
            _levelProperty.PropertyChanged     += (_, e) => _xml.TapeEchoLevel = e.Value;

            #endregion private Fields initialization
        }
    }
}
