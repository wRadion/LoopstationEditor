using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxRollViewModel : SettingsViewModel
    {
        public PropertyMixedViewModel<FxDelayTime> RollTime { get; }
        public PropertyEnumViewModel<FxRollMode> RollMode { get; }
        public PropertyIntViewModel RollFeedback { get; }
        public PropertyIntViewModel RollLevel { get; }

        public FxRollViewModel(SettingsMemoryFxModel model)
            : base(model)
        {
            RollTime = new PropertyMixedViewModel<FxDelayTime>(FxProperty.RollTime, _properties);
            RollMode = new PropertyEnumViewModel<FxRollMode>(FxProperty.RollMode, _properties);
            RollFeedback = new PropertyIntViewModel(FxProperty.RollFeedback, _properties);
            RollLevel = new PropertyIntViewModel(FxProperty.RollLevel, _properties);
        }
    }
}
