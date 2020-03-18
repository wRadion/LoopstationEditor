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
            FlangerRate = new PropertyMixedViewModel<FxRate>(nameof(FlangerRate), _properties);
            FlangerDepth = new PropertyIntViewModel(nameof(FlangerDepth), _properties);
            FlangerResonance = new PropertyIntViewModel(nameof(FlangerResonance), _properties);
            FlangerStepRate = new PropertyMixedViewModel<FxStepRate>(nameof(FlangerStepRate), _properties);
            FlangerLevel = new PropertyIntViewModel(nameof(FlangerLevel), _properties);
        }
    }
}
