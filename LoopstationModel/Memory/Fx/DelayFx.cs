using Loopstation.Xml.Memory;
using Loopstation.Common.Property;

namespace Loopstation.Model.Memory.Fx
{
    public class DelayFx
    {
        public DelayTime Time
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
        private readonly EnumProperty<DelayTime> _timeProperty;
        private readonly IntProperty _feedbackProperty;
        private readonly IntProperty _levelProperty;

        private readonly XmlFxSettings _xml;
        #endregion private Fields

        public DelayFx(XmlFxSettings xmlFx)
        {
            #region private Fields initialization
            _xml = xmlFx;

            _timeProperty     = _xml.DelayTime;
            _feedbackProperty = _xml.DelayFeedback;
            _levelProperty    = _xml.DelayLevel;

            _timeProperty.PropertyChanged     += (_, e) => _xml.DelayTime = e.Value;
            _feedbackProperty.PropertyChanged += (_, e) => _xml.DelayFeedback = e.Value;
            _levelProperty.PropertyChanged    += (_, e) => _xml.DelayLevel = e.Value;
            #endregion private Fields initialization
        }
    }
}
