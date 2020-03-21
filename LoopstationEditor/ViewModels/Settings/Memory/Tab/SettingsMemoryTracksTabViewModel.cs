using LoopstationEditor.Models.Settings.Memory;

namespace LoopstationEditor.ViewModels.Settings.Memory.Tab
{
    public class SettingsMemoryTracksTabViewModel : SettingsContainerViewModel
    {
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
