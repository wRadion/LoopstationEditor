using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxRingModulatorViewModel : FxViewModel
    {
        public PropertyIntViewModel RingModulatorFrequency { get; }
        public PropertyIntViewModel RingModulatorBalance { get; }

        public FxRingModulatorViewModel(SettingsMemoryFxModel model)
            : base("Ring Modulator", model)
        {
            RingModulatorFrequency = new PropertyIntViewModel(nameof(RingModulatorFrequency), _properties);
            RingModulatorBalance = new PropertyIntViewModel(nameof(RingModulatorBalance), _properties);
        }
    }
}
