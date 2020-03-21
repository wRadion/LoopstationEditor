using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory
{
    public enum FxBeatRepeatType { FORWARD = 0, REWIND = 1, MIX = 2 }
    public enum FxBeatRepeatLength { THRU = 0, WHOLE_NOTE = 1, HALF_NOTE = 2, QUARTER_NOTE = 3, EIGHTH_NOTE = 4, SIXTEENTH_NOTE = 5, THIRTYSECOND_NOTE = 6 }
    public enum FxBeatShiftType { FUTURE = 0, PAST = 1 }
    public enum FxBeatShiftShift { THRU = 0, SIXTEENTH_NOTE = 1, EIGHTH_NOTE = 2, QUARTER_NOTE = 3, HALF_NOTE = 4, WHOLE_NOTE = 5 }
    public enum FxBeatScatterType { P1 = 0, P2 = 1, P3 = 2, P4 = 3 }
    public enum FxBeatScatterLength { THRU = 0, HALF_NOTE = 1, QUARTER_NOTE = 2, EIGHTH_NOTE = 3, SIXTEENTH_NOTE = 4 }

    public static class BeatFxProperty
    {
        public const string BeatRepeatType = "RepTyp";
        public const string BeatRepeatLength = "RepLen";

        public const string BeatShiftType = "ShftTyp";
        public const string BeatShiftShift = "ShftShft";

        public const string BeatScatterType = "ScatTyp";
        public const string BeatScatterLength = "ScatLen";

        public const string VinylFlickFlick = "Flick";
    }

    public class SettingsMemoryBeatFxModel : SettingsModel
    {
        // BEAT REPEAT
        [XmlElement(BeatFxProperty.BeatRepeatType, typeof(int))]
        [Property(FxBeatRepeatType.FORWARD, 0, 2)]
        public ValueEnum<FxBeatRepeatType> BeatRepeatType { get; set; }
        [XmlElement(BeatFxProperty.BeatRepeatLength, typeof(int))]
        [Property(FxBeatRepeatLength.SIXTEENTH_NOTE, 0, 6)]
        public ValueEnum<FxBeatRepeatLength> BeatRepeatLength { get; set; }

        // BEAT SHIFT
        [XmlElement(BeatFxProperty.BeatShiftType, typeof(int))]
        [Property(FxBeatShiftType.FUTURE, 0, 1)]
        public ValueEnum<FxBeatShiftType> BeatShiftType { get; set; }
        [XmlElement(BeatFxProperty.BeatShiftShift, typeof(int))]
        [Property(FxBeatShiftShift.QUARTER_NOTE, 0, 5)]
        public ValueEnum<FxBeatShiftShift> BeatShiftShift { get; set; }

        // BEAT SCATTER
        [XmlElement(BeatFxProperty.BeatScatterType, typeof(int))]
        [Property(FxBeatScatterType.P1, 0, 3)]
        public ValueEnum<FxBeatScatterType> BeatScatterType { get; set; }
        [XmlElement(BeatFxProperty.BeatScatterLength, typeof(int))]
        [Property(FxBeatScatterLength.EIGHTH_NOTE, 0, 4)]
        public ValueEnum<FxBeatScatterLength> BeatScatterLength { get; set; }

        // VINYL FLICK
        [XmlElement(BeatFxProperty.VinylFlickFlick, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt VinylFlickFlick { get; set; }
    }
}
