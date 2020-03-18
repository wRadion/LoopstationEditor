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
            PanningDelayTime = new PropertyMixedViewModel<FxDelayTime>(nameof(PanningDelayTime), _properties);
            PanningDelayFeedback = new PropertyIntViewModel(nameof(PanningDelayFeedback), _properties);
            PanningDelayLevel = new PropertyIntViewModel(nameof(PanningDelayLevel), _properties);
        }
    }
}
