using Loopstation.Xml.Memory;
using Loopstation.Common.Property;

namespace Loopstation.Model.Memory.Fx
{
    public class GranularDelayFx
    {
        public int Time
        {
            get => _timeProperty.Value;
            set => _timeProperty.Value = value;
        }
        public int Feedback
        {
            get => _feedbackProperty.Value;
            set => _feedbackProperty.Value = value;
        }
        public int Level
        {
            get => _levelProperty.Value;
            set => _levelProperty.Value = value;
        }

        #region private Fields
        private readonly IntProperty _timeProperty;
        private readonly IntProperty _feedbackProperty;
        private readonly IntProperty _levelProperty;

        private readonly XmlFxSettings _xml;
        #endregion private Fields

        public GranularDelayFx(XmlFxSettings xmlFx)
        {
            #region private Fields initialization
            _xml = xmlFx;

            _timeProperty     = _xml.GranularDelayTime;
            _feedbackProperty = _xml.GranularDelayFeedback;
            _levelProperty    = _xml.GranularDelayLevel;

            _timeProperty.PropertyChanged     += (_, e) => _xml.GranularDelayTime = e.Value;
            _feedbackProperty.PropertyChanged += (_, e) => _xml.GranularDelayFeedback = e.Value;
            _levelProperty.PropertyChanged    += (_, e) => _xml.GranularDelayLevel = e.Value;
            #endregion private Fields initialization
        }
    }
}
