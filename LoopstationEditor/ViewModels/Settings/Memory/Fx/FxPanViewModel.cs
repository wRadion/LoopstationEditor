using LoopstationEditor.Converters.Int;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxPanViewModel : FxViewModel
    {
        public PropertyEnumRadioViewModel<FxPanType> PanType { get; }
        public PropertyMixedViewModel<FxRate> PanRate { get; }
        public PropertyIntViewModel PanDepth { get; }
        public PropertyMixedViewModel<FxStepRate> PanStepRate { get; }
        public PropertyIntViewModel PanPosition { get; }

        public FxPanViewModel(SettingsMemoryFxModel model)
            : base("Pan", model)
        {
            PanType = new PropertyEnumRadioViewModel<FxPanType>(nameof(PanType), _properties);
            PanRate = new PropertyMixedViewModel<FxRate>(nameof(PanRate), _properties);
            PanDepth = new PropertyIntViewModel(nameof(PanDepth), _properties);
            PanStepRate = new PropertyMixedViewModel<FxStepRate>(nameof(PanStepRate), _properties, new IntStepRateConverter());
            PanPosition = new PropertyIntViewModel(nameof(PanPosition), _properties, new IntPanConverter());
        }
    }
}
