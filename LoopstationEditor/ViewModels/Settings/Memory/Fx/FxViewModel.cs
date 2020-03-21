using LoopstationEditor.Models.Settings;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public abstract class FxViewModel : SettingsViewModel
    {
        public string DisplayName { get; }

        public FxViewModel(string displayName, SettingsModel model)
            : base(model)
        {
            DisplayName = displayName;
        }
    }
}
