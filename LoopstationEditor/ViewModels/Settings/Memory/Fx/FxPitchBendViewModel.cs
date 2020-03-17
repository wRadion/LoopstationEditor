using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxPitchBendViewModel : SettingsViewModel
    {
        public PropertyIntViewModel PitchBendOctave { get; }
        public PropertyIntViewModel PitchBendBend { get; }

        public FxPitchBendViewModel(SettingsMemoryFxModel model)
            : base(model)
        {
            PitchBendOctave = new PropertyIntViewModel(FxProperty.PitchBendOctave, _properties);
            PitchBendBend = new PropertyIntViewModel(FxProperty.PitchBendBend, _properties);
        }
    }
}
