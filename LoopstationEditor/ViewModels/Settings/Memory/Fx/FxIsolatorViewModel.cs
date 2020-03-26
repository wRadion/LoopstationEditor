using LoopstationEditor.Converters.Enum;
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
            IsolatorBand = new PropertyEnumRadioViewModel<FxIsolatorBand>(nameof(model.IsolatorBand), PropertySet);
            IsolatorRate = new PropertyMixedViewModel<FxRate>(nameof(model.IsolatorRate), PropertySet, new EnumNoteConverter<FxRate>());
            IsolatorDepth = new PropertyIntViewModel(nameof(model.IsolatorDepth), PropertySet);
            IsolatorStepRate = new PropertyMixedViewModel<FxStepRate>(nameof(model.IsolatorStepRate), PropertySet, new IntStepRateConverter(), new EnumNoteConverter<FxStepRate>());
            IsolatorLevel = new PropertyIntViewModel(nameof(model.IsolatorLevel), PropertySet);
        }
    }
}
