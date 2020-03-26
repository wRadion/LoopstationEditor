using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxSlowGearViewModel : FxViewModel
    {
        public PropertyIntViewModel SlowGearSensitivity { get; }
        public PropertyIntViewModel SlowGearRiseTime { get; }
        public PropertyIntViewModel SlowGearLevel { get; }

        public FxSlowGearViewModel(SettingsMemoryFxModel model)
            : base("Slow Gear", model)
        {
            SlowGearSensitivity = new PropertyIntViewModel(nameof(model.SlowGearSensitivity), PropertySet);
            SlowGearRiseTime = new PropertyIntViewModel(nameof(model.SlowGearRiseTime), PropertySet);
            SlowGearLevel = new PropertyIntViewModel(nameof(model.SlowGearLevel), PropertySet);
        }
    }
}
