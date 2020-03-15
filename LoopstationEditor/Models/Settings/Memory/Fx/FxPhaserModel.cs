using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory.Fx
{
    public class FxPhaserModel : SettingsModel
    {
        [XmlElement(FxProperty.PhaserRate, typeof(int))]
        [PropertyMixed(70, 0, 114, 0, 100)]
        public ValueInt PhaserRate { get; set; }

        [XmlElement(FxProperty.PhaserDepth, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt PhaserDepth { get; set; }

        [XmlElement(FxProperty.PhaserResonance, typeof(int))]
        [Property(0, 0, 100)]
        public ValueInt PhaserResonance { get; set; }

        [XmlElement(FxProperty.PhaserStepRate, typeof(int))]
        [PropertyMixed(FxStepRate.OFF, 0, 115, 1, 101)]
        public ValueInt PhaserStepRate { get; set; }

        [XmlElement(FxProperty.PhaserLevel, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt PhaserLevel { get; set; }

        public FxPhaserModel() : base() { }
    }
}
