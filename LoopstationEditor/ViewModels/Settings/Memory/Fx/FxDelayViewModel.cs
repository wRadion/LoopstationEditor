using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxDelayViewModel : FxViewModel
    {
        public PropertyMixedViewModel<FxDelayTime> DelayTime { get; }
        public PropertyIntViewModel DelayFeedback { get; }
        public PropertyIntViewModel DelayLevel { get; }

        public FxDelayViewModel(SettingsMemoryFxModel model)
            : base("Delay", model)
        {
            DelayTime = new PropertyMixedViewModel<FxDelayTime>(nameof(DelayTime), _properties);
            DelayFeedback = new PropertyIntViewModel(nameof(DelayFeedback), _properties);
            DelayLevel = new PropertyIntViewModel(nameof(DelayLevel), _properties);
        }
    }
}
