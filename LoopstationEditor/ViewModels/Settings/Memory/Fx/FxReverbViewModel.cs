using LoopstationEditor.Converters.Int;
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
            ReverbTime = new PropertyIntViewModel(nameof(ReverbTime), _properties, new IntTimeConverter());
            ReverbLevel = new PropertyIntViewModel(nameof(ReverbLevel), _properties);
            ReverbDryLevel = new PropertyIntViewModel(nameof(ReverbDryLevel), _properties);
        }
    }
}
