using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory.Fx
{
    public enum FxBeatShiftType { FUTURE = 0, PAST = 1 }
    public enum FxBeatShiftShift { THRU = 0, SIXTEENTH_NOTE = 1, EIGHTH_NOTE = 2, QUARTER_NOTE = 3, HALF_NOTE = 4, WHOLE_NOTE = 5 }

    public class FxBeatShiftModel : SettingsModel
    {
        [XmlElement(FxProperty.BeatShiftType, typeof(int))]
        [Property(FxBeatShiftType.FUTURE, 0, 1)]
        public ValueEnum<FxBeatShiftType> BeatShiftType { get; set; }

        [XmlElement(FxProperty.BeatShiftShift, typeof(int))]
        [Property(FxBeatShiftShift.QUARTER_NOTE, 0, 5)]
        public ValueEnum<FxBeatShiftShift> BeatShiftShift { get; set; }

        public FxBeatShiftModel() : base() { }
    }
}
