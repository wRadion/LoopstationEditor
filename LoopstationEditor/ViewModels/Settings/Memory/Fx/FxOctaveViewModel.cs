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
            OctaveMode = new PropertyEnumRadioViewModel<FxOctaveMode>(nameof(OctaveMode), _properties);
            OctaveLevel = new PropertyIntViewModel(nameof(OctaveLevel), _properties);
        }
    }
}
