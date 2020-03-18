using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxSlowGearViewModel : SettingsViewModel
    {
        public PropertyIntViewModel SlowGearSensitivity { get; }
        public PropertyIntViewModel SlowGearRiseTime { get; }
        public PropertyIntViewModel SlowGearLevel { get; }

        public FxSlowGearViewModel(SettingsMemoryFxModel model)
            : base(model)
        {
            SlowGearSensitivity = new PropertyIntViewModel(nameof(SlowGearSensitivity), _properties);
            SlowGearRiseTime = new PropertyIntViewModel(nameof(SlowGearRiseTime), _properties);
            SlowGearLevel = new PropertyIntViewModel(nameof(SlowGearLevel), _properties);
        }
    }
}
