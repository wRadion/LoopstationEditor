using LoopstationEditor.Converters.Int;
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
            PitchBendOctave = new PropertyIntViewModel(nameof(PitchBendOctave), _properties, new IntOctaveConverter());
            PitchBendBend = new PropertyIntViewModel(nameof(PitchBendBend), _properties);
        }
    }
}
