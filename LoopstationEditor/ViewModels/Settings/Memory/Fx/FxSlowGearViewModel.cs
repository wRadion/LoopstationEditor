using LoopstationEditor.Models.Settings.Memory.Fx;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxSlowGearViewModel : SettingsViewModel
    {
        public PropertyIntViewModel SlowGearSensitivity { get; }
        public PropertyIntViewModel SlowGearRiseTime { get; }
        public PropertyIntViewModel SlowGearLevel { get; }

        public FxSlowGearViewModel(FxSlowGearModel model)
            : base(model)
        {
            SlowGearSensitivity = new PropertyIntViewModel(FxProperty.SlowGearSensitivity, _properties);
            SlowGearRiseTime = new PropertyIntViewModel(FxProperty.SlowGearRiseTime, _properties);
            SlowGearLevel = new PropertyIntViewModel(FxProperty.SlowGearLevel, _properties);
        }
    }
}
