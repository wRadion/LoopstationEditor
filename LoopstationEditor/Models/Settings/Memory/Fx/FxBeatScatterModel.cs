using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory.Fx
{
    public enum FxBeatScatterType { P1 = 0, P2 = 1, P3 = 2, P4 = 3 }
    public enum FxBeatScatterLength { THRU = 0, HALF_NOTE = 1, QUARTER_NOTE = 2, EIGHTH_NOTE = 3, SIXTEENTH_NOTE = 4 }

    public class FxBeatScatterModel : SettingsModel
    {
        [XmlElement(FxProperty.BeatScatterType, typeof(int))]
        [Property(FxBeatScatterType.P1, 0, 3)]
        public ValueEnum<FxBeatScatterType> BeatScatterType { get; set; }

        [XmlElement(FxProperty.BeatScatterLength, typeof(int))]
        [Property(FxBeatScatterLength.EIGHTH_NOTE, 0, 4)]
        public ValueEnum<FxBeatScatterLength> BeatScatterLength { get; set; }

        public FxBeatScatterModel() : base() { }
    }
}
