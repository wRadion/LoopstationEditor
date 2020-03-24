using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.Settings.Memory.Fx;
using LoopstationEditor.Views.Settings.Memory.Fx;

namespace LoopstationEditor.ViewModels.Settings.Memory
{
    public class SettingsMemoryFxTrackViewModel : SettingsMemoryFxViewModel
    {
        public FxBeatRepeatViewModel BeatRepeat { get; }
        public FxBeatShiftViewModel BeatShift { get; }
        public FxBeatScatterViewModel BeatScatter { get; }
        public FxVinylFlickViewModel VinylFlick { get; }

        public SettingsMemoryFxTrackViewModel(SettingsMemoryFxModel model, SettingsMemoryBeatFxModel beatFxModel)
            : base(model)
        {
            BeatRepeat = new FxBeatRepeatViewModel(beatFxModel);
            BeatShift = new FxBeatShiftViewModel(beatFxModel);
            BeatScatter = new FxBeatScatterViewModel(beatFxModel);
            VinylFlick = new FxVinylFlickViewModel(beatFxModel);

            SetFxList();
        }

        public override void SetFxList()
        {
            base.SetFxList();
            FxList.Add(new FxItem(BeatRepeat.DisplayName, BeatRepeat, typeof(FxBeatRepeatView)));
            FxList.Add(new FxItem(BeatShift.DisplayName, BeatShift, typeof(FxBeatShiftView)));
            FxList.Add(new FxItem(BeatScatter.DisplayName, BeatScatter, typeof(FxBeatScatterView)));
            FxList.Add(new FxItem(VinylFlick.DisplayName, VinylFlick, typeof(FxVinylFlickView)));
        }

        public override void ApplyChanges()
        {
            base.ApplyChanges();
            BeatRepeat.ApplyChanges();
            BeatShift.ApplyChanges();
            BeatScatter.ApplyChanges();
            VinylFlick.ApplyChanges();
        }
    }
}
