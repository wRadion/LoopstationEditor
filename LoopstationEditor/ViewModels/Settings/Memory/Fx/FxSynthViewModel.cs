using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxSynthViewModel : FxViewModel
    {
        public PropertyIntViewModel SynthFrequency { get; }
        public PropertyIntViewModel SynthResonance { get; }
        public PropertyIntViewModel SynthDecay { get; }
        public PropertyIntViewModel SynthBalance { get; }

        public FxSynthViewModel(SettingsMemoryFxModel model)
            : base("Synth", model)
        {
            SynthFrequency = new PropertyIntViewModel(nameof(model.SynthFrequency), _properties);
            SynthResonance = new PropertyIntViewModel(nameof(model.SynthResonance), _properties);
            SynthDecay = new PropertyIntViewModel(nameof(model.SynthDecay), _properties);
            SynthBalance = new PropertyIntViewModel(nameof(model.SynthBalance), _properties);
        }
    }
}
