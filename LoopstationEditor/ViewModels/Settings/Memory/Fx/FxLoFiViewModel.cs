using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxLoFiViewModel : SettingsViewModel
    {
        public PropertyIntViewModel LoFiDepth { get; }
        public PropertyIntViewModel LoFiSampleRate { get; }
        public PropertyIntViewModel LoFiBalance { get; }

        public FxLoFiViewModel(SettingsMemoryFxModel model)
            : base(model)
        {
            LoFiDepth = new PropertyIntViewModel(nameof(LoFiDepth), _properties);
            LoFiSampleRate = new PropertyIntViewModel(nameof(LoFiSampleRate), _properties);
            LoFiBalance = new PropertyIntViewModel(nameof(LoFiBalance), _properties);
        }
    }
}
