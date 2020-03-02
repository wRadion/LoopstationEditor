using Loopstation.Xml.Memory;
using Loopstation.Common.Property;

namespace Loopstation.Model.Memory.Fx
{
    public enum RollMode { OFF, HALF, QUARTER, EIGHTH, SIXTEENTH }

    public class RollFx
    {
        public DelayTime Time
        {
            get => _timeProperty.Value;
            set => _timeProperty.Value = value;
        }
        public RollMode Mode
        {
            get => _modeProperty.Value;
            set => _modeProperty.Value = value;
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
        private readonly EnumProperty<RollMode> _modeProperty;
        private readonly IntProperty _feedbackProperty;
        private readonly IntProperty _levelProperty;

        private readonly XmlFxSettings _xml;
        #endregion private Fields

        public RollFx(XmlFxSettings xmlFx)
        {
            #region private Fields initialization
            _xml = xmlFx;

            _timeProperty     = _xml.RollTime;
            _modeProperty     = _xml.RollMode;
            _feedbackProperty = _xml.RollFeedback;
            _levelProperty    = _xml.RollLevel;

            _timeProperty.PropertyChanged     += (_, e) => _xml.RollTime = e.Value;
            _modeProperty.PropertyChanged     += (_, e) => _xml.RollMode = e.Value;
            _feedbackProperty.PropertyChanged += (_, e) => _xml.RollFeedback = e.Value;
            _levelProperty.PropertyChanged    += (_, e) => _xml.RollLevel = e.Value;
            #endregion private Fields initialization
        }
    }
}
