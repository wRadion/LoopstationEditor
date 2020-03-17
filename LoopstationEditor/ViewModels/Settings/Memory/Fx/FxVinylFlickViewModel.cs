using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxVinylFlickViewModel : SettingsViewModel
    {
        public PropertyIntViewModel VinylFlick { get; }

        public FxVinylFlickViewModel(SettingsMemoryBeatFxModel model)
            : base(model)
        {
            VinylFlick = new PropertyIntViewModel(BeatFxProperty.VinylFlick, _properties);
        }
    }
}
