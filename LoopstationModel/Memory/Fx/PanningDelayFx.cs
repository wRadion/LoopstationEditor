using Loopstation.Xml.Memory;
using Loopstation.Common.Property;

namespace Loopstation.Model.Memory.Fx
{
    public class PanningDelayFx
    {
        public DelayTime Time { get; set; }
        public int Feedback { get; set; }
        public int Level { get; set; }

        #region private Fields
        private readonly EnumProperty<DelayTime> _timeProperty;
        private readonly IntProperty _feedbackProperty;
        private readonly IntProperty _levelProperty;

        private readonly XmlFxSettings _xml;
        #endregion private Fields

        public PanningDelayFx(XmlFxSettings xmlFx)
        {
            #region private Fields initialization
            _xml = xmlFx;

            _timeProperty     = _xml.PanningDelayTime;
            _feedbackProperty = _xml.PanningDelayFeedback;
            _levelProperty    = _xml.PanningDelayLevel;

            _timeProperty.PropertyChanged     += (_, e) => _xml.PanningDelayTime = e.Value;
            _feedbackProperty.PropertyChanged += (_, e) => _xml.PanningDelayFeedback = e.Value;
            _levelProperty.PropertyChanged    += (_, e) => _xml.PanningDelayLevel = e.Value;
            #endregion private Fields initialization
        }
    }
}
