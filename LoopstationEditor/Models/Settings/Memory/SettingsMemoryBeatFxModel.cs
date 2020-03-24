using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory
{
    public enum FxBeatRepeatType { FORWARD = 0, REWIND = 1, MIX = 2 }
    public enum FxBeatRepeatLength { THRU = 0, WHOLE_NOTE = 1, HALF_NOTE = 3, QUARTER_NOTE = 5, EIGHTH_NOTE = 6, SIXTEENTH_NOTE = 7, THIRTYSECOND_NOTE = 8 }
    public enum FxBeatShiftType { FUTURE = 0, PAST = 1 }
    public enum FxBeatShiftShift { THRU = 0, SIXTEENTH_NOTE = 1, EIGHTH_NOTE = 2, QUARTER_NOTE = 3, HALF_NOTE = 5, WHOLE_NOTE = 7 }
    public enum FxBeatScatterType { P1 = 0, P2 = 1, P3 = 2, P4 = 3 }
    public enum FxBeatScatterLength { THRU = 0, HALF_NOTE = 1, QUARTER_NOTE = 3, EIGHTH_NOTE = 4, SIXTEENTH_NOTE = 5 }

    public class SettingsMemoryBeatFxModel : SettingsModel
    {
        // BEAT REPEAT
        [XmlElement("RepTyp", typeof(int))]
        [Property(FxBeatRepeatType.FORWARD, 0, 2)]
        public ValueEnum<FxBeatRepeatType> BeatRepeatType { get; set; }
        [XmlElement("RepLen", typeof(int))]
        [Property(FxBeatRepeatLength.QUARTER_NOTE, 0, 8)]
        public ValueEnum<FxBeatRepeatLength> BeatRepeatLength { get; set; }

        // BEAT SHIFT
        [XmlElement("ShftTyp", typeof(int))]
        [Property(FxBeatShiftType.FUTURE, 0, 1)]
        public ValueEnum<FxBeatShiftType> BeatShiftType { get; set; }
        [XmlElement("ShftShft", typeof(int))]
        [Property(FxBeatShiftShift.QUARTER_NOTE, 0, 7)]
        public ValueEnum<FxBeatShiftShift> BeatShiftShift { get; set; }

        // BEAT SCATTER
        [XmlElement("ScatTyp", typeof(int))]
        [Property(FxBeatScatterType.P1, 0, 3)]
        public ValueEnum<FxBeatScatterType> BeatScatterType { get; set; }
        [XmlElement("ScatLen", typeof(int))]
        [Property(FxBeatScatterLength.QUARTER_NOTE, 0, 5)]
        public ValueEnum<FxBeatScatterLength> BeatScatterLength { get; set; }

        // VINYL FLICK
        [XmlElement("Flick", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt VinylFlickFlick { get; set; }

        public SettingsMemoryBeatFxModel() : base() { }
    }
}
