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
            BeatShiftType = new PropertyEnumViewModel<FxBeatShiftType>(nameof(BeatShiftType), _properties);
            BeatShiftShift = new PropertyEnumViewModel<FxBeatShiftShift>(nameof(BeatShiftShift), _properties);
        }
    }
}
