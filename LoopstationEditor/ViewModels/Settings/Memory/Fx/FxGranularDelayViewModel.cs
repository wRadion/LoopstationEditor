using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxGranularDelayViewModel : SettingsViewModel
    {
        public PropertyMixedViewModel<FxDelayTime> GranularDelayTime { get; }
        public PropertyIntViewModel GranularDelayFeedback { get; }
        public PropertyIntViewModel GranularDelayLevel { get; }

        public FxGranularDelayViewModel(SettingsMemoryFxModel model)
            : base(model)
        {
            GranularDelayTime = new PropertyMixedViewModel<FxDelayTime>(FxProperty.GranularDelayTime, _properties);
            GranularDelayFeedback = new PropertyIntViewModel(FxProperty.GranularDelayFeedback, _properties);
            GranularDelayLevel = new PropertyIntViewModel(FxProperty.GranularDelayLevel, _properties);
        }
    }
}
