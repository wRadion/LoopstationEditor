using LoopstationEditor.Models.Settings.Memory.Fx;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxSynthViewModel : SettingsViewModel
    {
        public PropertyIntViewModel SynthFrequency { get; }
        public PropertyIntViewModel SynthResonance { get; }
        public PropertyIntViewModel SynthDecay { get; }
        public PropertyIntViewModel SynthBalance { get; }

        public FxSynthViewModel(FxSynthModel model)
            : base(model)
        {
            SynthFrequency = new PropertyIntViewModel(FxProperty.SynthFrequency, _properties);
            SynthResonance = new PropertyIntViewModel(FxProperty.SynthResonance, _properties);
            SynthDecay = new PropertyIntViewModel(FxProperty.SynthDecay, _properties);
            SynthBalance = new PropertyIntViewModel(FxProperty.SynthBalance, _properties);
        }
    }
}
