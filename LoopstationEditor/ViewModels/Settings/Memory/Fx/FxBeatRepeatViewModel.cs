using LoopstationEditor.Converters.Enum;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxBeatRepeatViewModel : FxBeatViewModel
    {
        public PropertyEnumRadioViewModel<FxBeatRepeatType> BeatRepeatType { get; }
        public PropertyEnumComboViewModel<FxBeatRepeatLength> BeatRepeatLength { get; }

        public FxBeatRepeatViewModel(SettingsMemoryBeatFxModel model)
            : base("Beat Repeat", model)
        {
            BeatRepeatType = new PropertyEnumRadioViewModel<FxBeatRepeatType>(nameof(model.BeatRepeatType), _properties);
            BeatRepeatLength = new PropertyEnumComboViewModel<FxBeatRepeatLength>(nameof(model.BeatRepeatLength), _properties, new EnumNoteConverter<FxBeatRepeatLength>());
        }
    }
}
