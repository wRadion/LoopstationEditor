using System;

using LoopstationEditor.Models.Settings.Memory;

namespace LoopstationEditor.ViewModels.Settings.Memory.Tab
{
    public class SettingsMemoryTracksTabViewModel : SettingsContainerViewModel
    {
        public override SettingsViewModel CurrentViewModel
        {
            get
            {
                switch (SelectedIndex)
                {
                    case 0: return Track1;
                    case 1: return Track2;
                    case 2: return Track3;
                    case 3: return Track4;
                    case 4: return Track5;
                }

                throw new ArgumentOutOfRangeException("TracksTab index must be between 0 and 4.");
            }
        }

        public SettingsMemoryTrackViewModel Track1 { get; }
        public SettingsMemoryTrackViewModel Track2 { get; }
        public SettingsMemoryTrackViewModel Track3 { get; }
        public SettingsMemoryTrackViewModel Track4 { get; }
        public SettingsMemoryTrackViewModel Track5 { get; }

        public SettingsMemoryTracksTabViewModel(MemoryModel model)
            : base(model)
        {
            Track1 = new SettingsMemoryTrackViewModel(model.Track1);
            Track2 = new SettingsMemoryTrackViewModel(model.Track2);
            Track3 = new SettingsMemoryTrackViewModel(model.Track3);
            Track4 = new SettingsMemoryTrackViewModel(model.Track4);
            Track5 = new SettingsMemoryTrackViewModel(model.Track5);
        }

        public override void ApplyChanges()
        {
            Track1.ApplyChanges();
            Track2.ApplyChanges();
            Track3.ApplyChanges();
            Track4.ApplyChanges();
            Track5.ApplyChanges();
        }
    }
}
