using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxGranularDelayViewModel : SettingsViewModel
    {
        public PropertyIntViewModel GranularDelayTime { get; }
        public PropertyIntViewModel GranularDelayFeedback { get; }
        public PropertyIntViewModel GranularDelayLevel { get; }

        public FxGranularDelayViewModel(SettingsMemoryFxModel model)
            : base(model)
        {
            GranularDelayTime = new PropertyIntViewModel(nameof(GranularDelayTime), _properties);
            GranularDelayFeedback = new PropertyIntViewModel(nameof(GranularDelayFeedback), _properties);
            GranularDelayLevel = new PropertyIntViewModel(nameof(GranularDelayLevel), _properties);
        }
    }
}
