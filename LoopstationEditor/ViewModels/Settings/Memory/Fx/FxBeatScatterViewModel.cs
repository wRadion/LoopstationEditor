using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxBeatScatterViewModel : SettingsViewModel
    {
        public PropertyEnumComboViewModel<FxBeatScatterType> BeatScatterType { get; }
        public PropertyEnumComboViewModel<FxBeatScatterLength> BeatScatterLength { get; }

        public FxBeatScatterViewModel(SettingsMemoryBeatFxModel model)
            : base(model)
        {
            BeatScatterType = new PropertyEnumComboViewModel<FxBeatScatterType>(nameof(BeatScatterType), _properties);
            BeatScatterLength = new PropertyEnumComboViewModel<FxBeatScatterLength>(nameof(BeatScatterLength), _properties);
        }
    }
}
