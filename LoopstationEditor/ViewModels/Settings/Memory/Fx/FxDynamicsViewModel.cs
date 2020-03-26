using LoopstationEditor.Converters.Int;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxDynamicsViewModel : FxViewModel
    {
        public PropertyEnumComboViewModel<FxDynamicsType> DynamicsType { get; }
        public PropertyIntViewModel DynamicsDynamics { get; }

        public FxDynamicsViewModel(SettingsMemoryFxModel model)
            : base("Dynamics", model)
        {
            DynamicsType = new PropertyEnumComboViewModel<FxDynamicsType>(nameof(model.DynamicsType), PropertySet);
            DynamicsDynamics = new PropertyIntViewModel(nameof(model.DynamicsDynamics), PropertySet, new IntDbConverter());
        }
    }
}
