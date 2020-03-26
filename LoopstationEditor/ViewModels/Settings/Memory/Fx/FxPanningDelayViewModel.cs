using LoopstationEditor.Converters.Enum;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxPanningDelayViewModel : FxViewModel
    {
        public PropertyMixedViewModel<FxDelayTime> PanningDelayTime { get; }
        public PropertyIntViewModel PanningDelayFeedback { get; }
        public PropertyIntViewModel PanningDelayLevel { get; }

        public FxPanningDelayViewModel(SettingsMemoryFxModel model)
            : base("Panning Delay", model)
        {
            PanningDelayTime = new PropertyMixedViewModel<FxDelayTime>(nameof(model.PanningDelayTime), PropertySet, new EnumNoteConverter<FxDelayTime>());
            PanningDelayFeedback = new PropertyIntViewModel(nameof(model.PanningDelayFeedback), PropertySet);
            PanningDelayLevel = new PropertyIntViewModel(nameof(model.PanningDelayLevel), PropertySet);
        }
    }
}
