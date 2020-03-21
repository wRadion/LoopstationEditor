using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxVinylFlickViewModel : FxBeatViewModel
    {
        public PropertyIntViewModel VinylFlickFlick { get; }

        public FxVinylFlickViewModel(SettingsMemoryBeatFxModel model)
            : base("Vinyl Flick", model)
        {
            VinylFlickFlick = new PropertyIntViewModel(nameof(VinylFlickFlick), _properties);
        }
    }
}
