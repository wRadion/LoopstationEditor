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
            PhaserRate = new PropertyMixedViewModel<FxRate>(nameof(model.PhaserRate), _properties, new EnumNoteConverter<FxRate>());
            PhaserDepth = new PropertyIntViewModel(nameof(model.PhaserDepth), _properties);
            PhaserResonance = new PropertyIntViewModel(nameof(model.PhaserResonance), _properties);
            PhaserStepRate = new PropertyMixedViewModel<FxStepRate>(nameof(model.PhaserStepRate), _properties, new IntStepRateConverter(), new EnumNoteConverter<FxStepRate>());
            PhaserLevel = new PropertyIntViewModel(nameof(model.PhaserLevel), _properties);
        }
    }
}
