using LoopstationEditor.Models.Settings.Memory.Fx;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxPitchBendViewModel : SettingsViewModel
    {
        public PropertyIntViewModel PitchBendOctave { get; }
        public PropertyIntViewModel PitchBendBend { get; }

        public FxPitchBendViewModel(FxPitchBendModel model)
            : base(model)
        {
            PitchBendOctave = new PropertyIntViewModel(FxProperty.PitchBendOctave, _properties);
            PitchBendBend = new PropertyIntViewModel(FxProperty.PitchBendBend, _properties);
        }
    }
}
