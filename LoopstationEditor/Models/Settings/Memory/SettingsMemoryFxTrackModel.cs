using LoopstationEditor.Models.Settings.Memory.Fx;

namespace LoopstationEditor.Models.Settings.Memory
{
    public class SettingsMemoryFxTrackModel : SettingsMemoryFxModel
    {
        public FxBeatRepeatModel BeatRepeat { get; set; }
        public FxBeatShiftModel BeatShift { get; set; }
        public FxBeatScatterModel BeatScatter { get; set; }
        public FxVinylFlickModel VinylFlick { get; set; }

        public SettingsMemoryFxTrackModel(FxSlot slot) : base(FxType.TRACK, slot) { }
    }
}
