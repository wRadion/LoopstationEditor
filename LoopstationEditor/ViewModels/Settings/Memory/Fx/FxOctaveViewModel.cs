using LoopstationEditor.Converters.Enum;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxOctaveViewModel : FxViewModel
    {
        public PropertyEnumRadioViewModel<FxOctaveMode> OctaveMode { get; }
        public PropertyIntViewModel OctaveLevel { get; }

        public FxOctaveViewModel(SettingsMemoryFxModel model)
            : base("Octave", model)
        {
            OctaveMode = new PropertyEnumRadioViewModel<FxOctaveMode>(nameof(model.OctaveMode), PropertySet, new EnumOctaveModeConverter());
            OctaveLevel = new PropertyIntViewModel(nameof(model.OctaveLevel), PropertySet);
        }
    }
}
