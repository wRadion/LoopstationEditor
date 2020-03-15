using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory.Fx
{
    public class FxPanningDelayModel : SettingsModel
    {
        [XmlElement(FxProperty.PanningDelayTime, typeof(int))]
        [PropertyMixed(200, 0, 1011, 0, 1000)]
        public ValueInt PanningDelayTime { get; set; }

        [XmlElement(FxProperty.PanningDelayFeedback, typeof(int))]
        [Property(20, 0, 100)]
        public ValueInt PanningDelayFeedback { get; set; }

        [XmlElement(FxProperty.PanningDelayLevel, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt PanningDelayLevel { get; set; }

        public FxPanningDelayModel() : base() { }
    }
}
