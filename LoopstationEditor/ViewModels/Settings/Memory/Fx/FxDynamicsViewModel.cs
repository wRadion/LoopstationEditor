using LoopstationEditor.Converters.Int;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxDynamicsViewModel : SettingsViewModel
    {
        public PropertyEnumViewModel<FxDynamicsType> DynamicsType { get; }
        public PropertyIntViewModel DynamicsDynamics { get; }

        public FxDynamicsViewModel(SettingsMemoryFxModel model)
            : base(model)
        {
            DynamicsType = new PropertyEnumViewModel<FxDynamicsType>(nameof(DynamicsType), _properties);
            DynamicsDynamics = new PropertyIntViewModel(nameof(DynamicsDynamics), _properties, new IntDbConverter());
        }
    }
}
