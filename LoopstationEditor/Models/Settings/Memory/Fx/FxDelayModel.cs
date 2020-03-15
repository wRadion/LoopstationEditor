using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory.Fx
{
    public class FxDelayModel : SettingsModel
    {
        [XmlElement(FxProperty.DelayTime, typeof(int))]
        [PropertyMixed(200, 0, 1011, 0, 1000)]
        public ValueInt DelayTime { get; set; }

        [XmlElement(FxProperty.DelayFeedback, typeof(int))]
        [Property(20, 0, 100)]
        public ValueInt DelayFeedback { get; set; }

        [XmlElement(FxProperty.DelayLevel, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt DelayLevel { get; set; }

        public FxDelayModel() : base() { }
    }
}
