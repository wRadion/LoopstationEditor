using LoopstationEditor.Models.Settings.Memory.Fx;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxFilterViewModel : SettingsViewModel
    {
        public PropertyEnumViewModel<FxFilterType> FilterType { get; }
        public PropertyMixedViewModel<FxRate> FilterRate { get; }
        public PropertyIntViewModel FilterDepth { get; }
        public PropertyIntViewModel FilterResonance { get; }
        public PropertyIntViewModel FilterCutoff { get; }
        public PropertyMixedViewModel<FxStepRate> FilterStepRate { get; }

        public FxFilterViewModel(FxFilterModel model)
            : base(model)
        {
            FilterType = new PropertyEnumViewModel<FxFilterType>(FxProperty.FilterType, _properties);
            FilterRate = new PropertyMixedViewModel<FxRate>(FxProperty.FilterRate, _properties);
            FilterDepth = new PropertyIntViewModel(FxProperty.FilterDepth, _properties);
            FilterResonance = new PropertyIntViewModel(FxProperty.FilterResonance, _properties);
            FilterCutoff = new PropertyIntViewModel(FxProperty.FilterCutoff, _properties);
            FilterStepRate = new PropertyMixedViewModel<FxStepRate>(FxProperty.FilterStepRate, _properties);
        }
    }
}
