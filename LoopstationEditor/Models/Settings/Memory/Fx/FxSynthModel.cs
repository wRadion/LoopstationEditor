using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory.Fx
{
    public class FxSynthModel : SettingsModel
    {
        [XmlElement(FxProperty.SynthFrequency, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt SynthFrequency { get; set; }

        [XmlElement(FxProperty.SynthResonance, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt SynthResonance { get; set; }

        [XmlElement(FxProperty.SynthDecay, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt SynthDecay { get; set; }

        [XmlElement(FxProperty.SynthBalance, typeof(int))]
        [Property(90, 0, 100)]
        public ValueInt SynthBalance { get; set; }

        public FxSynthModel() : base() { }
    }
}
