using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxOctaveViewModel : SettingsViewModel
    {
        public PropertyEnumComboViewModel<FxOctaveMode> OctaveMod { get; }
        public PropertyIntViewModel OctaveLevel { get; }

        public FxOctaveViewModel(SettingsMemoryFxModel model)
            : base(model)
        {
            OctaveMod = new PropertyEnumComboViewModel<FxOctaveMode>(nameof(OctaveMod), _properties);
            OctaveLevel = new PropertyIntViewModel(nameof(OctaveLevel), _properties);
        }
    }
}
