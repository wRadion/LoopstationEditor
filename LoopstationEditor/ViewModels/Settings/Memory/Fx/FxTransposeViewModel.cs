using LoopstationEditor.Converters.Int;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxTransposeViewModel : SettingsViewModel
    {
        public PropertyIntViewModel TransposeSemitones { get; }

        public FxTransposeViewModel(SettingsMemoryFxModel model)
            : base(model)
        {
            TransposeSemitones = new PropertyIntViewModel(nameof(TransposeSemitones), _properties, new IntSemitonesConverter());
        }
    }
}
