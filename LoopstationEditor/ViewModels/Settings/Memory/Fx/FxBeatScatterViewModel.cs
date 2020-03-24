using LoopstationEditor.Converters.Enum;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxBeatScatterViewModel : FxBeatViewModel
    {
        public PropertyEnumRadioViewModel<FxBeatScatterType> BeatScatterType { get; }
        public PropertyEnumComboViewModel<FxBeatScatterLength> BeatScatterLength { get; }

        public FxBeatScatterViewModel(SettingsMemoryBeatFxModel model)
            : base("Beat Scatter", model)
        {
            BeatScatterType = new PropertyEnumRadioViewModel<FxBeatScatterType>(nameof(model.BeatScatterType), _properties);
            BeatScatterLength = new PropertyEnumComboViewModel<FxBeatScatterLength>(nameof(model.BeatScatterLength), _properties, new EnumNoteConverter<FxBeatScatterLength>());
        }
    }
}
