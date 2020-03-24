using System;

using LoopstationEditor.Models.Settings.Memory;

namespace LoopstationEditor.ViewModels.Settings.Memory.Tab
{
    public class SettingsMemoryTrackFxTabViewModel : SettingsContainerViewModel
    {
        public override SettingsViewModel CurrentViewModel
        {
            get
            {
                switch (SelectedIndex)
                {
                    case 0: return TrackFx;
                    case 1: return TrackFxA.CurrentViewModel;
                    case 2: return TrackFxB.CurrentViewModel;
                    case 3: return TrackFxC.CurrentViewModel;
                }

                throw new ArgumentOutOfRangeException("TrackFxTab index must be between 0 and 3.");
            }
        }

        public SettingsMemoryTrackFxViewModel TrackFx { get; }
        public SettingsMemoryFxTrackViewModel TrackFxA { get; }
        public SettingsMemoryFxTrackViewModel TrackFxB { get; }
        public SettingsMemoryFxTrackViewModel TrackFxC { get; }

        public SettingsMemoryTrackFxTabViewModel(MemoryModel model)
            : base(model)
        {
            TrackFx = new SettingsMemoryTrackFxViewModel(model.TrackFx);
            TrackFxA = new SettingsMemoryFxTrackViewModel(model.TrackFxA, model.BeatFxA);
            TrackFxB = new SettingsMemoryFxTrackViewModel(model.TrackFxB, model.BeatFxB);
            TrackFxC = new SettingsMemoryFxTrackViewModel(model.TrackFxC, model.BeatFxC);
        }

        public override void ApplyChanges()
        {
            TrackFx.ApplyChanges();
            TrackFxA.ApplyChanges();
            TrackFxB.ApplyChanges();
            TrackFxC.ApplyChanges();
        }
    }
}
