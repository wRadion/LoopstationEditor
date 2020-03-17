using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxDelayViewModel : SettingsViewModel
    {
        public PropertyMixedViewModel<FxDelayTime> DelayTime { get; }
        public PropertyIntViewModel DelayFeedback { get; }
        public PropertyIntViewModel DelayLevel { get; }

        public FxDelayViewModel(SettingsMemoryFxModel model)
            : base(model)
        {
            DelayTime = new PropertyMixedViewModel<FxDelayTime>(FxProperty.DelayTime, _properties);
            DelayFeedback = new PropertyIntViewModel(FxProperty.DelayFeedback, _properties);
            DelayLevel = new PropertyIntViewModel(FxProperty.DelayLevel, _properties);
        }
    }
}
