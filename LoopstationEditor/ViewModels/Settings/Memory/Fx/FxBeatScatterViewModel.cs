using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxBeatScatterViewModel : SettingsViewModel
    {
        public PropertyEnumViewModel<FxBeatScatterType> BeatScatterType { get; }
        public PropertyEnumViewModel<FxBeatScatterLength> BeatScatterLength { get; }

        public FxBeatScatterViewModel(SettingsMemoryBeatFxModel model)
            : base(model)
        {
            BeatScatterType = new PropertyEnumViewModel<FxBeatScatterType>(nameof(BeatScatterType), _properties);
            BeatScatterLength = new PropertyEnumViewModel<FxBeatScatterLength>(nameof(BeatScatterLength), _properties);
        }
    }
}