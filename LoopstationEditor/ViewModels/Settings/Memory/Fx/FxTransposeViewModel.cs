using LoopstationEditor.Models.Settings.Memory.Fx;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxTransposeViewModel : SettingsViewModel
    {
        public PropertyIntViewModel TransposeSemitones { get; }

        public FxTransposeViewModel(FxTransposeModel model)
            : base(model)
        {
            TransposeSemitones = new PropertyIntViewModel(FxProperty.TransposeSemitones, _properties);
        }
    }
}
