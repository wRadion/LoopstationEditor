using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.Settings.Memory.Fx;

namespace LoopstationEditor.ViewModels.Settings.Memory
{
    public class SettingsMemoryFxTrackViewModel : SettingsMemoryFxViewModel
    {
        public FxBeatRepeatViewModel BeatRepeat { get; }
        public FxBeatShiftViewModel BeatShift { get; }
        public FxBeatScatterViewModel BeatScatter { get; }
        public FxVinylFlickViewModel VinylFlick { get; }

        public SettingsMemoryFxTrackViewModel(SettingsMemoryFxTrackModel model)
            : base(model)
        {
            BeatRepeat = new FxBeatRepeatViewModel(model.BeatRepeat);
            BeatShift = new FxBeatShiftViewModel(model.BeatShift);
            BeatScatter = new FxBeatScatterViewModel(model.BeatScatter);
            VinylFlick = new FxVinylFlickViewModel(model.VinylFlick);
        }
    }
}
