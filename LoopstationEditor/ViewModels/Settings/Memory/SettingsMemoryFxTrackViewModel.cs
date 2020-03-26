using System;

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

        public SettingsMemoryFxTrackViewModel(FxSlot slot, SettingsMemoryFxModel model, SettingsMemoryBeatFxModel beatFxModel)
            : base(FxType.TRACK, slot, model)
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

        public override void ApplyChanges<T>(T model)
        {
            if (model is MemoryModel memory)
            {
                SettingsMemoryFxModel fx = memory.TrackFxA;
                SettingsMemoryBeatFxModel beatFx = memory.BeatFxA;

                switch (Slot)
                {
                    case FxSlot.A:
                        fx = memory.TrackFxA;
                        beatFx = memory.BeatFxA;
                        break;
                    case FxSlot.B:
                        fx = memory.TrackFxB;
                        beatFx = memory.BeatFxB;
                        break;
                    case FxSlot.C:
                        fx = memory.TrackFxC;
                        beatFx = memory.BeatFxC;
                        break;
                }

                base.ApplyChanges(fx);

                BeatRepeat.ApplyChanges(beatFx);
                BeatShift.ApplyChanges(beatFx);
                BeatScatter.ApplyChanges(beatFx);
                VinylFlick.ApplyChanges(beatFx);
            }
            else
                throw new ArgumentException("Model must be of type MemoryModel.");
        }
    }
}
