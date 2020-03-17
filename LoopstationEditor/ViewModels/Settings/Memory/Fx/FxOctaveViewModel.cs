using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxOctaveViewModel : SettingsViewModel
    {
        public PropertyEnumViewModel<FxOctaveMode> OctaveMod { get; }
        public PropertyIntViewModel OctaveLevel { get; }

        public FxOctaveViewModel(SettingsMemoryFxModel model)
            : base(model)
        {
            OctaveMod = new PropertyEnumViewModel<FxOctaveMode>(FxProperty.OctaveMod, _properties);
            OctaveLevel = new PropertyIntViewModel(FxProperty.OctaveLevel, _properties);
        }
    }
}
