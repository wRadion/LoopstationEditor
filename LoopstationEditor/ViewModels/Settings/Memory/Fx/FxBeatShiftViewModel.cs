using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxBeatShiftViewModel : FxBeatViewModel
    {
        public PropertyEnumComboViewModel<FxBeatShiftType> BeatShiftType { get; }
        public PropertyEnumComboViewModel<FxBeatShiftShift> BeatShiftShift { get; }

        public FxBeatShiftViewModel(SettingsMemoryBeatFxModel model)
            : base("Beat Shift", model)
        {
            BeatShiftType = new PropertyEnumComboViewModel<FxBeatShiftType>(nameof(BeatShiftType), _properties);
            BeatShiftShift = new PropertyEnumComboViewModel<FxBeatShiftShift>(nameof(BeatShiftShift), _properties);
        }
    }
}
