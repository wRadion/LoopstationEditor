using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxPhaserViewModel : SettingsViewModel
    {
        public PropertyMixedViewModel<FxRate> PhaserRate { get; }
        public PropertyIntViewModel PhaserDepth { get; }
        public PropertyIntViewModel PhaserResonance { get; }
        public PropertyMixedViewModel<FxStepRate> PhaserStepRate { get; }
        public PropertyIntViewModel PhaserLevel { get; }

        public FxPhaserViewModel(SettingsMemoryFxModel model)
            : base(model)
        {
            PhaserRate = new PropertyMixedViewModel<FxRate>(nameof(PhaserRate), _properties);
            PhaserDepth = new PropertyIntViewModel(nameof(PhaserDepth), _properties);
            PhaserResonance = new PropertyIntViewModel(nameof(PhaserResonance), _properties);
            PhaserStepRate = new PropertyMixedViewModel<FxStepRate>(nameof(PhaserStepRate), _properties);
            PhaserLevel = new PropertyIntViewModel(nameof(PhaserLevel), _properties);
        }
    }
}
