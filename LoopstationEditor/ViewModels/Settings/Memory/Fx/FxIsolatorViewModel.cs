using LoopstationEditor.Models.Settings.Memory.Fx;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxIsolatorViewModel : SettingsViewModel
    {
        public PropertyEnumViewModel<FxIsolatorBand> IsolatorBand { get; }
        public PropertyMixedViewModel<FxRate> IsolatorRate { get; }
        public PropertyIntViewModel IsolatorDepth { get; }
        public PropertyMixedViewModel<FxStepRate> IsolatorStepRate { get; }
        public PropertyIntViewModel IsolatorLevel { get; }

        public FxIsolatorViewModel(FxIsolatorModel model)
            : base(model)
        {
            IsolatorBand = new PropertyEnumViewModel<FxIsolatorBand>(FxProperty.IsolatorBand, _properties);
            IsolatorRate = new PropertyMixedViewModel<FxRate>(FxProperty.IsolatorRate, _properties);
            IsolatorDepth = new PropertyIntViewModel(FxProperty.IsolatorDepth, _properties);
            IsolatorStepRate = new PropertyMixedViewModel<FxStepRate>(FxProperty.IsolatorStepRate, _properties);
            IsolatorLevel = new PropertyIntViewModel(FxProperty.IsolatorLevel, _properties);
        }
    }
}
