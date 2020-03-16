using LoopstationEditor.Models.Settings.Memory.Fx;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxBeatScatterViewModel : SettingsViewModel
    {
        public PropertyEnumViewModel<FxBeatScatterType> BeatScatterType { get; }
        public PropertyEnumViewModel<FxBeatScatterLength> BeatScatterLength { get; }

        public FxBeatScatterViewModel(FxBeatScatterModel model)
            : base(model)
        {
            BeatScatterType = new PropertyEnumViewModel<FxBeatScatterType>(FxProperty.BeatScatterType, _properties);
            BeatScatterLength = new PropertyEnumViewModel<FxBeatScatterLength>(FxProperty.BeatScatterLength, _properties);
        }
    }
}
