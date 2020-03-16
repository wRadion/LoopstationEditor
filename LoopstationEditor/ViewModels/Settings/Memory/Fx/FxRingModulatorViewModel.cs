using LoopstationEditor.Models.Settings.Memory.Fx;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxRingModulatorViewModel : SettingsViewModel
    {
        public PropertyIntViewModel RingModulatorFrequency { get; }
        public PropertyIntViewModel RingModulatorBalance { get; }

        public FxRingModulatorViewModel(FxRingModulatorModel model)
            : base(model)
        {
            RingModulatorFrequency = new PropertyIntViewModel(FxProperty.RingModulatorFrequency, _properties);
            RingModulatorBalance = new PropertyIntViewModel(FxProperty.RingModulatorBalance, _properties);
        }
    }
}
