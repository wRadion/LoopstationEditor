using LoopstationEditor.Models.Settings.Memory;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public abstract class FxBeatViewModel : FxViewModel
    {
        public FxBeatViewModel(string displayName, SettingsMemoryBeatFxModel model)
            : base(displayName, model)
        {
        }
    }
}
