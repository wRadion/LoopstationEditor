using LoopstationEditor.Converters.Int;
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
            PanType = new PropertyEnumViewModel<FxPanType>(nameof(PanType), _properties);
            PanRate = new PropertyMixedViewModel<FxRate>(nameof(PanRate), _properties);
            PanDepth = new PropertyIntViewModel(nameof(PanDepth), _properties);
            PanStepRate = new PropertyMixedViewModel<FxStepRate>(nameof(PanStepRate), _properties);
            PanPosition = new PropertyIntViewModel(nameof(PanPosition), _properties, new IntPanConverter());
        }
    }
}
