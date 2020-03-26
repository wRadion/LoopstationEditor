using LoopstationEditor.Converters.Int;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxPitchBendViewModel : FxViewModel
    {
        public PropertyIntViewModel PitchBendOctave { get; }
        public PropertyIntViewModel PitchBendBend { get; }

        public FxPitchBendViewModel(SettingsMemoryFxModel model)
            : base("Pitch Bend", model)
        {
            PitchBendOctave = new PropertyIntViewModel(nameof(model.PitchBendOctave), PropertySet, new IntOctaveConverter());
            PitchBendBend = new PropertyIntViewModel(nameof(model.PitchBendBend), PropertySet);
        }
    }
}
