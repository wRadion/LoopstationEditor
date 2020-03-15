using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory.Fx
{
    public class FxFlangerModel : SettingsModel
    {
        [XmlElement(FxProperty.FlangerRate, typeof(int))]
        [PropertyMixed(25, 0, 114, 0, 100)]
        public ValueInt FlangerRate { get; set; }

        [XmlElement(FxProperty.FlangerDepth, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt FlangerDepth { get; set; }

        [XmlElement(FxProperty.FlangerResonance, typeof(int))]
        [Property(70, 0, 100)]
        public ValueInt FlangerResonance { get; set; }

        [XmlElement(FxProperty.FlangerStepRate, typeof(int))]
        [PropertyMixed(FxStepRate.OFF, 0, 115, 1, 101)]
        public ValueInt FlangerStepRate { get; set; }

        [XmlElement(FxProperty.FlangerLevel, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt FlangerLevel { get; set; }

        public FxFlangerModel() : base() { }
    }
}
