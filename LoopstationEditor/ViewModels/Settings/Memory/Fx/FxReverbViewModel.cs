using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxReverbViewModel : SettingsViewModel
    {
        public PropertyIntViewModel ReverbTime { get; }
        public PropertyIntViewModel ReverbLevel { get; }
        public PropertyIntViewModel ReverbDryLevel { get; }

        public FxReverbViewModel(SettingsMemoryFxModel model)
            : base(model)
        {
            ReverbTime = new PropertyIntViewModel(FxProperty.ReverbTime, _properties);
            ReverbLevel = new PropertyIntViewModel(FxProperty.ReverbLevel, _properties);
            ReverbDryLevel = new PropertyIntViewModel(FxProperty.ReverbDryLevel, _properties);
        }
    }
}
