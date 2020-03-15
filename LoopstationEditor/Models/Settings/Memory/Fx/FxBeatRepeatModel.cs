using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory.Fx
{
    public enum FxBeatRepeatType { FORWARD = 0, REWIND = 1, MIX = 2 }
    public enum FxBeatRepeatLength { THRU = 0, WHOLE_NOTE = 1, HALF_NOTE = 2, QUARTER_NOTE = 3, EIGHTH_NOTE = 4, SIXTEENTH_NOTE = 5, THIRTYSECOND_NOTE = 6 }

    public class FxBeatRepeatModel : SettingsModel
    {
        [XmlElement(FxProperty.BeatRepeatType, typeof(int))]
        [Property(FxBeatRepeatType.FORWARD, 0, 2)]
        public ValueEnum<FxBeatRepeatType> BeatRepeatType { get; set; }

        [XmlElement(FxProperty.BeatRepeatLength, typeof(int))]
        [Property(FxBeatRepeatLength.SIXTEENTH_NOTE, 0, 6)]
        public ValueEnum<FxBeatRepeatLength> BeatRepeatLength { get; set; }

        public FxBeatRepeatModel() : base() { }
    }
}
