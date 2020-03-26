using LoopstationEditor.Converters.Enum;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxRollViewModel : FxViewModel
    {
        public PropertyMixedViewModel<FxDelayTime> RollTime { get; }
        public PropertyEnumComboViewModel<FxRollMode> RollMode { get; }
        public PropertyIntViewModel RollFeedback { get; }
        public PropertyIntViewModel RollLevel { get; }

        public FxRollViewModel(SettingsMemoryFxModel model)
            : base("Roll", model)
        {
            RollTime = new PropertyMixedViewModel<FxDelayTime>(nameof(model.RollTime), PropertySet, new EnumNoteConverter<FxDelayTime>());
            RollMode = new PropertyEnumComboViewModel<FxRollMode>(nameof(model.RollMode), PropertySet, new EnumTimeSignatureConverter<FxRollMode>());
            RollFeedback = new PropertyIntViewModel(nameof(model.RollFeedback), PropertySet);
            RollLevel = new PropertyIntViewModel(nameof(model.RollLevel), PropertySet);
        }
    }
}
