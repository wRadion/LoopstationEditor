using LoopstationEditor.Converters.Int;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxDynamicsViewModel : SettingsViewModel
    {
        public PropertyEnumComboViewModel<FxDynamicsType> DynamicsType { get; }
        public PropertyIntViewModel DynamicsDynamics { get; }

        public FxDynamicsViewModel(SettingsMemoryFxModel model)
            : base(model)
        {
            DynamicsType = new PropertyEnumComboViewModel<FxDynamicsType>(nameof(DynamicsType), _properties);
            DynamicsDynamics = new PropertyIntViewModel(nameof(DynamicsDynamics), _properties, new IntDbConverter());
        }
    }
}
