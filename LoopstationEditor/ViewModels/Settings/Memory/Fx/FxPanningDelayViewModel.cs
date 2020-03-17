using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxPanningDelayViewModel : SettingsViewModel
    {
        public PropertyMixedViewModel<FxDelayTime> PanningDelayTime { get; }
        public PropertyIntViewModel PanningDelayFeedback { get; }
        public PropertyIntViewModel PanningDelayLevel { get; }

        public FxPanningDelayViewModel(SettingsMemoryFxModel model)
            : base(model)
        {
            PanningDelayTime = new PropertyMixedViewModel<FxDelayTime>(FxProperty.PanningDelayTime, _properties);
            PanningDelayFeedback = new PropertyIntViewModel(FxProperty.PanningDelayFeedback, _properties);
            PanningDelayLevel = new PropertyIntViewModel(FxProperty.PanningDelayLevel, _properties);
        }
    }
}
