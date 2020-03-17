using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxFlangerViewModel : SettingsViewModel
    {
        public PropertyMixedViewModel<FxRate> FlangerRate { get; }
        public PropertyIntViewModel FlangerDepth { get; }
        public PropertyIntViewModel FlangerResonance { get; }
        public PropertyMixedViewModel<FxStepRate> FlangerStepRate { get; }
        public PropertyIntViewModel FlangerLevel { get; }

        public FxFlangerViewModel(SettingsMemoryFxModel model)
            : base(model)
        {
            FlangerRate = new PropertyMixedViewModel<FxRate>(FxProperty.FlangerRate, _properties);
            FlangerDepth = new PropertyIntViewModel(FxProperty.FlangerDepth, _properties);
            FlangerResonance = new PropertyIntViewModel(FxProperty.FlangerResonance, _properties);
            FlangerStepRate = new PropertyMixedViewModel<FxStepRate>(FxProperty.FlangerStepRate, _properties);
            FlangerLevel = new PropertyIntViewModel(FxProperty.FlangerLevel, _properties);
        }
    }
}
