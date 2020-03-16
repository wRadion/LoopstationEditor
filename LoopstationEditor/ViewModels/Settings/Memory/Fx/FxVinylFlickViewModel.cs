using LoopstationEditor.Models.Settings.Memory.Fx;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxVinylFlickViewModel : SettingsViewModel
    {
        public PropertyIntViewModel VinylFlick { get; }

        public FxVinylFlickViewModel(FxVinylFlickModel model)
            : base(model)
        {
            VinylFlick = new PropertyIntViewModel(FxProperty.VinylFlick, _properties);
        }
    }
}
