using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory.Fx
{
    public class FxPitchBendModel : SettingsModel
    {
        [XmlElement(FxProperty.PitchBendOctave, typeof(int))]
        [Property(2, 0, 7)]
        public ValueInt PitchBendOctave { get; set; }

        [XmlElement(FxProperty.PitchBendBend, typeof(int))]
        [Property(100, 0, 100)]
        public ValueInt PitchBendBend { get; set; }

        public FxPitchBendModel() : base() { }
    }
}
