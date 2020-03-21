using LoopstationEditor.Converters.Int;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxIsolatorViewModel : FxViewModel
    {
        public PropertyEnumRadioViewModel<FxIsolatorBand> IsolatorBand { get; }
        public PropertyMixedViewModel<FxRate> IsolatorRate { get; }
        public PropertyIntViewModel IsolatorDepth { get; }
        public PropertyMixedViewModel<FxStepRate> IsolatorStepRate { get; }
        public PropertyIntViewModel IsolatorLevel { get; }

        public FxIsolatorViewModel(SettingsMemoryFxModel model)
            : base("Isolator", model)
        {
            IsolatorBand = new PropertyEnumRadioViewModel<FxIsolatorBand>(nameof(IsolatorBand), _properties);
            IsolatorRate = new PropertyMixedViewModel<FxRate>(nameof(IsolatorRate), _properties);
            IsolatorDepth = new PropertyIntViewModel(nameof(IsolatorDepth), _properties);
            IsolatorStepRate = new PropertyMixedViewModel<FxStepRate>(nameof(IsolatorStepRate), _properties, new IntStepRateConverter());
            IsolatorLevel = new PropertyIntViewModel(nameof(IsolatorLevel), _properties);
        }
    }
}
