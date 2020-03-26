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
            SynthFrequency = new PropertyIntViewModel(nameof(model.SynthFrequency), PropertySet);
            SynthResonance = new PropertyIntViewModel(nameof(model.SynthResonance), PropertySet);
            SynthDecay = new PropertyIntViewModel(nameof(model.SynthDecay), PropertySet);
            SynthBalance = new PropertyIntViewModel(nameof(model.SynthBalance), PropertySet);
        }
    }
}
