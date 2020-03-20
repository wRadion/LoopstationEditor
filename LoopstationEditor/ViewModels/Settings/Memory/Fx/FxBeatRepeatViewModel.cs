using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxBeatRepeatViewModel : SettingsViewModel
    {
        public PropertyEnumComboViewModel<FxBeatRepeatType> BeatRepeatType { get; }
        public PropertyEnumComboViewModel<FxBeatRepeatLength> BeatRepeatLength { get; }

        public FxBeatRepeatViewModel(SettingsMemoryBeatFxModel model)
            : base(model)
        {
            BeatRepeatType = new PropertyEnumComboViewModel<FxBeatRepeatType>(nameof(BeatRepeatType), _properties);
            BeatRepeatLength = new PropertyEnumComboViewModel<FxBeatRepeatLength>(nameof(BeatRepeatLength), _properties);
        }
    }
}
