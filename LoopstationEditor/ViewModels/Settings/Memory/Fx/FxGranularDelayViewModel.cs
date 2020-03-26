using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxGranularDelayViewModel : FxViewModel
    {
        public PropertyIntViewModel GranularDelayTime { get; }
        public PropertyIntViewModel GranularDelayFeedback { get; }
        public PropertyIntViewModel GranularDelayLevel { get; }

        public FxGranularDelayViewModel(SettingsMemoryFxModel model)
            : base("Granular Delay", model)
        {
            GranularDelayTime = new PropertyIntViewModel(nameof(model.GranularDelayTime), PropertySet);
            GranularDelayFeedback = new PropertyIntViewModel(nameof(model.GranularDelayFeedback), PropertySet);
            GranularDelayLevel = new PropertyIntViewModel(nameof(model.GranularDelayLevel), PropertySet);
        }
    }
}
