using LoopstationEditor.Models.Settings.Memory.Fx;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxBeatShiftViewModel : SettingsViewModel
    {
        public PropertyEnumViewModel<FxBeatShiftType> BeatShiftType { get; }
        public PropertyEnumViewModel<FxBeatShiftShift> BeatShiftShift { get; }

        public FxBeatShiftViewModel(FxBeatShiftModel model)
            : base(model)
        {
            BeatShiftType = new PropertyEnumViewModel<FxBeatShiftType>(FxProperty.BeatShiftType, _properties);
            BeatShiftShift = new PropertyEnumViewModel<FxBeatShiftShift>(FxProperty.BeatShiftShift, _properties);
        }
    }
}
