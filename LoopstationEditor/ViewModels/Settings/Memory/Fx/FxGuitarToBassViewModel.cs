using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxGuitarToBassViewModel : FxViewModel
    {
        public PropertyIntViewModel GuitarToBassBalance { get; }

        public FxGuitarToBassViewModel(SettingsMemoryFxModel model)
            : base("Guitar To Bass", model)
        {
            GuitarToBassBalance = new PropertyIntViewModel(nameof(model.GuitarToBassBalance), PropertySet);
        }
    }
}
