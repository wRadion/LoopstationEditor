using LoopstationEditor.Converters.Enum;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxChorusViewModel : FxViewModel
    {
        public PropertyMixedViewModel<FxRate> ChorusRate { get; }
        public PropertyIntViewModel ChorusDepth { get; }
        public PropertyIntViewModel ChorusLevel { get; }

        public FxChorusViewModel(SettingsMemoryFxModel model)
            : base("Chorus", model)
        {
            ChorusRate = new PropertyMixedViewModel<FxRate>(nameof(model.ChorusRate), PropertySet, new EnumNoteConverter<FxRate>());
            ChorusDepth = new PropertyIntViewModel(nameof(model.ChorusDepth), PropertySet);
            ChorusLevel = new PropertyIntViewModel(nameof(model.ChorusLevel), PropertySet);
        }
    }
}
