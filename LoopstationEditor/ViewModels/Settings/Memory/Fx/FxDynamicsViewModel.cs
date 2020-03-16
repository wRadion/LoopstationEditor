using LoopstationEditor.Models.Settings.Memory.Fx;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxDynamicsViewModel : SettingsViewModel
    {
        public PropertyEnumViewModel<FxDynamicsType> DynamicsType { get; }
        public PropertyIntViewModel DynamicsDynamics { get; }

        public FxDynamicsViewModel(FxDynamicsModel model)
            : base(model)
        {
            DynamicsType = new PropertyEnumViewModel<FxDynamicsType>(FxProperty.DynamicsType, _properties);
            DynamicsDynamics = new PropertyIntViewModel(FxProperty.DynamicsDynamics, _properties);
        }
    }
}
