using LoopstationEditor.Converters.Int;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxTransposeViewModel : FxViewModel
    {
        public PropertyIntViewModel TransposeSemitones { get; }

        public FxTransposeViewModel(SettingsMemoryFxModel model)
            : base("Transpose", model)
        {
            TransposeSemitones = new PropertyIntViewModel(nameof(model.TransposeSemitones), PropertySet, new IntSemitonesConverter());
        }
    }
}
