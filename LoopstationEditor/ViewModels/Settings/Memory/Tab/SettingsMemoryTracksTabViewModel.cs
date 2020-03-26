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
            Track1 = new SettingsMemoryTrackViewModel(1, model.Track1);
            Track2 = new SettingsMemoryTrackViewModel(2, model.Track2);
            Track3 = new SettingsMemoryTrackViewModel(3, model.Track3);
            Track4 = new SettingsMemoryTrackViewModel(4, model.Track4);
            Track5 = new SettingsMemoryTrackViewModel(5, model.Track5);
        }

        public override void ApplyChanges<T>(T model)
        {
            if (model is MemoryModel memory)
            {
                Track1.ApplyChanges(memory.Track1);
                Track2.ApplyChanges(memory.Track2);
                Track3.ApplyChanges(memory.Track3);
                Track4.ApplyChanges(memory.Track4);
                Track5.ApplyChanges(memory.Track5);
            }
            else
                throw new ArgumentException("Model must be of type MemoryModel.");
        }

        public override void RevertChanges()
        {
            Track1.RevertChanges();
            Track2.RevertChanges();
            Track3.RevertChanges();
            Track4.RevertChanges();
            Track5.RevertChanges();
        }
    }
}
