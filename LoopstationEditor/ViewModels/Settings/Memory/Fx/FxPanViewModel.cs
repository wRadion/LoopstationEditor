using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxPanViewModel : SettingsViewModel
    {
        public PropertyEnumViewModel<FxPanType> PanType { get; }
        public PropertyMixedViewModel<FxRate> PanRate { get; }
        public PropertyIntViewModel PanDepth { get; }
        public PropertyMixedViewModel<FxStepRate> PanStepRate { get; }
        public PropertyIntViewModel PanPosition { get; }

        public FxPanViewModel(SettingsMemoryFxModel model)
            : base(model)
        {
            PanType = new PropertyEnumViewModel<FxPanType>(FxProperty.PanType, _properties);
            PanRate = new PropertyMixedViewModel<FxRate>(FxProperty.PanRate, _properties);
            PanDepth = new PropertyIntViewModel(FxProperty.PanDepth, _properties);
            PanStepRate = new PropertyMixedViewModel<FxStepRate>(FxProperty.PanStepRate, _properties);
            PanPosition = new PropertyIntViewModel(FxProperty.PanPosition, _properties);
        }
    }
}
