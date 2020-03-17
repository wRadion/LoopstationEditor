using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.Settings.Memory.Fx;

namespace LoopstationEditor.ViewModels.Settings.Memory
{
    public class SettingsMemoryFxTrackViewModel : SettingsMemoryFxViewModel
    {
        private SettingsMemoryBeatFxModel _beatFxModel;

        public FxBeatRepeatViewModel BeatRepeat { get; }
        public FxBeatShiftViewModel BeatShift { get; }
        public FxBeatScatterViewModel BeatScatter { get; }
        public FxVinylFlickViewModel VinylFlick { get; }

        public SettingsMemoryFxTrackViewModel(SettingsMemoryFxModel model, SettingsMemoryBeatFxModel beatFxModel)
            : base(model)
        {
            _beatFxModel = beatFxModel;

            BeatRepeat = new FxBeatRepeatViewModel(beatFxModel);
            BeatShift = new FxBeatShiftViewModel(beatFxModel);
            BeatScatter = new FxBeatScatterViewModel(beatFxModel);
            VinylFlick = new FxVinylFlickViewModel(beatFxModel);
        }
    }
}
