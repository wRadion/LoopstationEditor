using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxLoFiViewModel : FxViewModel
    {
        public PropertyIntViewModel LoFiDepth { get; }
        public PropertyIntViewModel LoFiSampleRate { get; }
        public PropertyIntViewModel LoFiBalance { get; }

        public FxLoFiViewModel(SettingsMemoryFxModel model)
            : base("Lo-Fi", model)
        {
            LoFiDepth = new PropertyIntViewModel(nameof(model.LoFiDepth), _properties);
            LoFiSampleRate = new PropertyIntViewModel(nameof(model.LoFiSampleRate), _properties);
            LoFiBalance = new PropertyIntViewModel(nameof(model.LoFiBalance), _properties);
        }
    }
}
