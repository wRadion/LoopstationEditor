using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxRollViewModel : SettingsViewModel
    {
        public PropertyMixedViewModel<FxDelayTime> RollTime { get; }
        public PropertyEnumComboViewModel<FxRollMode> RollMode { get; }
        public PropertyIntViewModel RollFeedback { get; }
        public PropertyIntViewModel RollLevel { get; }

        public FxRollViewModel(SettingsMemoryFxModel model)
            : base(model)
        {
            RollTime = new PropertyMixedViewModel<FxDelayTime>(nameof(RollTime), _properties);
            RollMode = new PropertyEnumComboViewModel<FxRollMode>(nameof(RollMode), _properties);
            RollFeedback = new PropertyIntViewModel(nameof(RollFeedback), _properties);
            RollLevel = new PropertyIntViewModel(nameof(RollLevel), _properties);
        }
    }
}
