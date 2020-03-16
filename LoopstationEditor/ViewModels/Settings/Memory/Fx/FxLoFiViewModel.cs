using LoopstationEditor.Models.Settings.Memory.Fx;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxLoFiViewModel : SettingsViewModel
    {
        public PropertyIntViewModel LoFiDepth { get; }
        public PropertyIntViewModel LoFiSampleRate { get; }
        public PropertyIntViewModel LoFiBalance { get; }

        public FxLoFiViewModel(FxLoFiModel model)
            : base(model)
        {
            LoFiDepth = new PropertyIntViewModel(FxProperty.LoFiDepth, _properties);
            LoFiSampleRate = new PropertyIntViewModel(FxProperty.LoFiSampleRate, _properties);
            LoFiBalance = new PropertyIntViewModel(FxProperty.LoFiBalance, _properties);
        }
    }
}
