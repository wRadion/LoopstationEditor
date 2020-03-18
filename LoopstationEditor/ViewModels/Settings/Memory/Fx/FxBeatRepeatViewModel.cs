using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxBeatRepeatViewModel : SettingsViewModel
    {
        public PropertyEnumViewModel<FxBeatRepeatType> BeatRepeatType { get; }
        public PropertyEnumViewModel<FxBeatRepeatLength> BeatRepeatLength { get; }

        public FxBeatRepeatViewModel(SettingsMemoryBeatFxModel model)
            : base(model)
        {
            BeatRepeatType = new PropertyEnumViewModel<FxBeatRepeatType>(nameof(BeatRepeatType), _properties);
            BeatRepeatLength = new PropertyEnumViewModel<FxBeatRepeatLength>(nameof(BeatRepeatLength), _properties);
        }
    }
}
