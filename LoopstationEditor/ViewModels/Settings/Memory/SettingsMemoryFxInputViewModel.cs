using System;

using LoopstationEditor.Models.Settings.Memory;

namespace LoopstationEditor.ViewModels.Settings.Memory
{
    public class SettingsMemoryFxInputViewModel : SettingsMemoryFxViewModel
    {
        public SettingsMemoryFxInputViewModel(FxSlot slot, SettingsMemoryFxModel model)
            : base(FxType.INPUT, slot, model)
        {
            SetFxList();
        }
    }
}
