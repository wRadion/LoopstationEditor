using LoopstationEditor.Models.Settings.Memory.Fx;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxGuitarToBassViewModel : SettingsViewModel
    {
        public PropertyIntViewModel GuitarToBassBalance { get; }

        public FxGuitarToBassViewModel(FxGuitarToBassModel model)
            : base(model)
        {
            GuitarToBassBalance = new PropertyIntViewModel(FxProperty.GuitarToBassBalance, _properties);
        }
    }
}
