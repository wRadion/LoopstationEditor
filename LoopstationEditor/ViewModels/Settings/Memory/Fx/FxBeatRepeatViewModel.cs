using LoopstationEditor.Models.Settings.Memory.Fx;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxBeatRepeatViewModel : SettingsViewModel
    {
        public PropertyEnumViewModel<FxBeatRepeatType> BeatRepeatType { get; }
        public PropertyEnumViewModel<FxBeatRepeatLength> BeatRepeatLength { get; }

        public FxBeatRepeatViewModel(FxBeatRepeatModel model)
            : base(model)
        {
            BeatRepeatType = new PropertyEnumViewModel<FxBeatRepeatType>(FxProperty.BeatRepeatType, _properties);
            BeatRepeatLength = new PropertyEnumViewModel<FxBeatRepeatLength>(FxProperty.BeatRepeatLength, _properties);
        }
    }
}
