using LoopstationEditor.Converters.Enum;
using LoopstationEditor.Converters.Int;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxPhaserViewModel : FxViewModel
    {
        public PropertyMixedViewModel<FxRate> PhaserRate { get; }
        public PropertyIntViewModel PhaserDepth { get; }
        public PropertyIntViewModel PhaserResonance { get; }
        public PropertyMixedViewModel<FxStepRate> PhaserStepRate { get; }
        public PropertyIntViewModel PhaserLevel { get; }

        public FxPhaserViewModel(SettingsMemoryFxModel model)
            : base("Phaser", model)
        {
            PhaserRate = new PropertyMixedViewModel<FxRate>(nameof(model.PhaserRate), PropertySet, new EnumNoteConverter<FxRate>());
            PhaserDepth = new PropertyIntViewModel(nameof(model.PhaserDepth), PropertySet);
            PhaserResonance = new PropertyIntViewModel(nameof(model.PhaserResonance), PropertySet);
            PhaserStepRate = new PropertyMixedViewModel<FxStepRate>(nameof(model.PhaserStepRate), PropertySet, new IntStepRateConverter(), new EnumNoteConverter<FxStepRate>());
            PhaserLevel = new PropertyIntViewModel(nameof(model.PhaserLevel), PropertySet);
        }
    }
}
