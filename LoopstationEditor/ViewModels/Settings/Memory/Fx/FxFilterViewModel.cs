using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxFilterViewModel : SettingsViewModel
    {
        public PropertyEnumComboViewModel<FxFilterType> FilterType { get; }
        public PropertyMixedViewModel<FxRate> FilterRate { get; }
        public PropertyIntViewModel FilterDepth { get; }
        public PropertyIntViewModel FilterResonance { get; }
        public PropertyIntViewModel FilterCutoff { get; }
        public PropertyMixedViewModel<FxStepRate> FilterStepRate { get; }

        public FxFilterViewModel(SettingsMemoryFxModel model)
            : base(model)
        {
            FilterType = new PropertyEnumComboViewModel<FxFilterType>(nameof(FilterType), _properties);
            FilterRate = new PropertyMixedViewModel<FxRate>(nameof(FilterRate), _properties);
            FilterDepth = new PropertyIntViewModel(nameof(FilterDepth), _properties);
            FilterResonance = new PropertyIntViewModel(nameof(FilterResonance), _properties);
            FilterCutoff = new PropertyIntViewModel(nameof(FilterCutoff), _properties);
            FilterStepRate = new PropertyMixedViewModel<FxStepRate>(nameof(FilterStepRate), _properties);
        }
    }
}
