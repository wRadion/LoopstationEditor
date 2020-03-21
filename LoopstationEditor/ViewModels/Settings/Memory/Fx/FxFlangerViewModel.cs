using LoopstationEditor.Converters.Int;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxFlangerViewModel : FxViewModel
    {
        public PropertyMixedViewModel<FxRate> FlangerRate { get; }
        public PropertyIntViewModel FlangerDepth { get; }
        public PropertyIntViewModel FlangerResonance { get; }
        public PropertyMixedViewModel<FxStepRate> FlangerStepRate { get; }
        public PropertyIntViewModel FlangerLevel { get; }

        public FxFlangerViewModel(SettingsMemoryFxModel model)
            : base("Flanger", model)
        {
            FlangerRate = new PropertyMixedViewModel<FxRate>(nameof(FlangerRate), _properties);
            FlangerDepth = new PropertyIntViewModel(nameof(FlangerDepth), _properties);
            FlangerResonance = new PropertyIntViewModel(nameof(FlangerResonance), _properties);
            FlangerStepRate = new PropertyMixedViewModel<FxStepRate>(nameof(FlangerStepRate), _properties, new IntStepRateConverter());
            FlangerLevel = new PropertyIntViewModel(nameof(FlangerLevel), _properties);
        }
    }
}
