using LoopstationEditor.Converters.Enum;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxBeatShiftViewModel : FxBeatViewModel
    {
        public PropertyEnumRadioViewModel<FxBeatShiftType> BeatShiftType { get; }
        public PropertyEnumComboViewModel<FxBeatShiftShift> BeatShiftShift { get; }

        public FxBeatShiftViewModel(SettingsMemoryBeatFxModel model)
            : base("Beat Shift", model)
        {
            BeatShiftType = new PropertyEnumRadioViewModel<FxBeatShiftType>(nameof(model.BeatShiftType), PropertySet);
            BeatShiftShift = new PropertyEnumComboViewModel<FxBeatShiftShift>(nameof(model.BeatShiftShift), PropertySet, new EnumNoteConverter<FxBeatShiftShift>());
        }
    }
}
