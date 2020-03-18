using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxGuitarToBassViewModel : SettingsViewModel
    {
        public PropertyIntViewModel GuitarToBassBalance { get; }

        public FxGuitarToBassViewModel(SettingsMemoryFxModel model)
            : base(model)
        {
            GuitarToBassBalance = new PropertyIntViewModel(nameof(GuitarToBassBalance), _properties);
        }
    }
}
