using LoopstationEditor.Models.Settings.Memory;

namespace LoopstationEditor.ViewModels.Settings.Memory
{
    public class SettingsMemoryFxInputViewModel : SettingsMemoryFxViewModel
    {
        public SettingsMemoryFxInputViewModel(SettingsMemoryFxModel model)
            : base(model)
        {
            SetFxList();
        }
    }
}
