using LoopstationEditor.Converters.Enum;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxDelayViewModel : FxViewModel
    {
        public PropertyMixedViewModel<FxDelayTime> DelayTime { get; }
        public PropertyIntViewModel DelayFeedback { get; }
        public PropertyIntViewModel DelayLevel { get; }

        public FxDelayViewModel(SettingsMemoryFxModel model)
            : base("Delay", model)
        {
            DelayTime = new PropertyMixedViewModel<FxDelayTime>(nameof(model.DelayTime), _properties, new EnumNoteConverter<FxDelayTime>());
            DelayFeedback = new PropertyIntViewModel(nameof(model.DelayFeedback), _properties);
            DelayLevel = new PropertyIntViewModel(nameof(model.DelayLevel), _properties);
        }
    }
}
