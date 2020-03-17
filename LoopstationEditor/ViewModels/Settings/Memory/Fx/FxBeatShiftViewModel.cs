using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxBeatShiftViewModel : SettingsViewModel
    {
        public PropertyEnumViewModel<FxBeatShiftType> BeatShiftType { get; }
        public PropertyEnumViewModel<FxBeatShiftShift> BeatShiftShift { get; }

        public FxBeatShiftViewModel(SettingsMemoryBeatFxModel model)
            : base(model)
        {
            BeatShiftType = new PropertyEnumViewModel<FxBeatShiftType>(BeatFxProperty.BeatShiftType, _properties);
            BeatShiftShift = new PropertyEnumViewModel<FxBeatShiftShift>(BeatFxProperty.BeatShiftShift, _properties);
        }
    }
}
