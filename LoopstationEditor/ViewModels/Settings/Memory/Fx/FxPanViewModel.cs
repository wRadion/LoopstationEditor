using LoopstationEditor.Converters.Enum;
using LoopstationEditor.Converters.Int;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxPanViewModel : FxViewModel
    {
        public PropertyEnumRadioViewModel<FxPanType> PanType { get; }
        public PropertyMixedViewModel<FxRate> PanRate { get; }
        public PropertyIntViewModel PanDepth { get; }
        public PropertyMixedViewModel<FxStepRate> PanStepRate { get; }
        public PropertyIntViewModel PanPosition { get; }

        public FxPanViewModel(SettingsMemoryFxModel model)
            : base("Pan", model)
        {
            PanType = new PropertyEnumRadioViewModel<FxPanType>(nameof(model.PanType), PropertySet);
            PanRate = new PropertyMixedViewModel<FxRate>(nameof(model.PanRate), PropertySet, new EnumNoteConverter<FxRate>());
            PanDepth = new PropertyIntViewModel(nameof(model.PanDepth), PropertySet);
            PanStepRate = new PropertyMixedViewModel<FxStepRate>(nameof(model.PanStepRate), PropertySet, new IntStepRateConverter(), new EnumNoteConverter<FxStepRate>());
            PanPosition = new PropertyIntViewModel(nameof(model.PanPosition), PropertySet, new IntPanConverter());
        }
    }
}
