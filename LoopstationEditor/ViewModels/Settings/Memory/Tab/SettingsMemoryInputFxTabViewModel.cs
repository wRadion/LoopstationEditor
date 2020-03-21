using LoopstationEditor.Models.Settings.Memory;

namespace LoopstationEditor.ViewModels.Settings.Memory.Tab
{
    public class SettingsMemoryInputFxTabViewModel : SettingsContainerViewModel
    {
        public SettingsMemoryInputFxViewModel InputFx { get; }
        public SettingsMemoryFxInputViewModel InputFxA { get; }
        public SettingsMemoryFxInputViewModel InputFxB { get; }
        public SettingsMemoryFxInputViewModel InputFxC { get; }

        public SettingsMemoryInputFxTabViewModel(MemoryModel model)
            : base(model)
        {
            InputFx = new SettingsMemoryInputFxViewModel(model.InputFx);
            InputFxA = new SettingsMemoryFxInputViewModel(model.InputFxA);
            InputFxB = new SettingsMemoryFxInputViewModel(model.InputFxB);
            InputFxC = new SettingsMemoryFxInputViewModel(model.InputFxC);
        }

        public override void ApplyChanges()
        {
            InputFx.ApplyChanges();
            InputFxA.ApplyChanges();
            InputFxB.ApplyChanges();
            InputFxC.ApplyChanges();
        }
    }
}
