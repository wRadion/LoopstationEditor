using LoopstationEditor.Converters.Float;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxReverbViewModel : FxViewModel
    {
        public PropertyFloatViewModel ReverbTime { get; }
        public PropertyIntViewModel ReverbLevel { get; }
        public PropertyIntViewModel ReverbDryLevel { get; }

        public FxReverbViewModel(SettingsMemoryFxModel model)
            : base("Reverb", model)
        {
            ReverbTime = new PropertyFloatViewModel(nameof(model.ReverbTime), _properties, new FloatTimeConverter());
            ReverbLevel = new PropertyIntViewModel(nameof(model.ReverbLevel), _properties);
            ReverbDryLevel = new PropertyIntViewModel(nameof(model.ReverbDryLevel), _properties);
        }
    }
}
