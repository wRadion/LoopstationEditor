using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory.Fx
{
    public class FxGranularDelayModel : SettingsModel
    {
        [XmlElement(FxProperty.GranularDelayTime, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt GranularDelayTime { get; set; }

        [XmlElement(FxProperty.GranularDelayFeedback, typeof(int))]
        [Property(70, 0, 100)]
        public ValueInt GranularDelayFeedback { get; set; }

        [XmlElement(FxProperty.GranularDelayLevel, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt GranularDelayLevel { get; set; }

        public FxGranularDelayModel() : base() { }
    }
}
