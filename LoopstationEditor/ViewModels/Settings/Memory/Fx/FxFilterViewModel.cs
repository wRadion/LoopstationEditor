using LoopstationEditor.Converters.Enum;
using LoopstationEditor.Converters.Int;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxFilterViewModel : FxViewModel
    {
        public PropertyEnumRadioViewModel<FxFilterType> FilterType { get; }
        public PropertyMixedViewModel<FxRate> FilterRate { get; }
        public PropertyIntViewModel FilterDepth { get; }
        public PropertyIntViewModel FilterResonance { get; }
        public PropertyIntViewModel FilterCutoff { get; }
        public PropertyMixedViewModel<FxStepRate> FilterStepRate { get; }

        public FxFilterViewModel(SettingsMemoryFxModel model)
            : base("Filter", model)
        {
            FilterType = new PropertyEnumRadioViewModel<FxFilterType>(nameof(model.FilterType), PropertySet);
            FilterRate = new PropertyMixedViewModel<FxRate>(nameof(model.FilterRate), PropertySet, new EnumNoteConverter<FxRate>());
            FilterDepth = new PropertyIntViewModel(nameof(model.FilterDepth), PropertySet);
            FilterResonance = new PropertyIntViewModel(nameof(model.FilterResonance), PropertySet);
            FilterCutoff = new PropertyIntViewModel(nameof(model.FilterCutoff), PropertySet);
            FilterStepRate = new PropertyMixedViewModel<FxStepRate>(nameof(model.FilterStepRate), PropertySet, new IntStepRateConverter(), new EnumNoteConverter<FxStepRate>());
        }
    }
}
