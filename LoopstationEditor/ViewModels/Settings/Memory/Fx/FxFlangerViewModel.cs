using LoopstationEditor.Converters.Enum;
using LoopstationEditor.Converters.Int;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxFlangerViewModel : FxViewModel
    {
        public PropertyMixedViewModel<FxRate> FlangerRate { get; }
        public PropertyIntViewModel FlangerDepth { get; }
        public PropertyIntViewModel FlangerResonance { get; }
        public PropertyMixedViewModel<FxStepRate> FlangerStepRate { get; }
        public PropertyIntViewModel FlangerLevel { get; }

        public FxFlangerViewModel(SettingsMemoryFxModel model)
            : base("Flanger", model)
        {
            FlangerRate = new PropertyMixedViewModel<FxRate>(nameof(model.FlangerRate), PropertySet, new EnumNoteConverter<FxRate>());
            FlangerDepth = new PropertyIntViewModel(nameof(model.FlangerDepth), PropertySet);
            FlangerResonance = new PropertyIntViewModel(nameof(model.FlangerResonance), PropertySet);
            FlangerStepRate = new PropertyMixedViewModel<FxStepRate>(nameof(model.FlangerStepRate), PropertySet, new IntStepRateConverter(), new EnumNoteConverter<FxStepRate>());
            FlangerLevel = new PropertyIntViewModel(nameof(model.FlangerLevel), PropertySet);
        }
    }
}
