using LoopstationEditor.Converters.Bitwise;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory
{
    public class SettingsMemoryTrackFxViewModel : SettingsViewModel
    {
        public PropertyEnumRadioViewModel<FxMode> Mode { get; }
        public PropertyEnumRadioViewModel<FxSlotOrNone> SingleEnabledFxSlot { get; }
        public PropertyEnumRadioViewModel<FxSlot> SelectedFxSlot { get; }
        public PropertyEnumComboViewModel<SingleTrackFx> SelectedSingleFxA { get; }
        public PropertyEnumComboViewModel<SingleTrackFx> SelectedSingleFxB { get; }
        public PropertyEnumComboViewModel<SingleTrackFx> SelectedSingleFxC { get; }
        public PropertyBitwiseViewModel<FxSlotBitwise> MultiEnabledFxSlot { get; }
        public PropertyEnumComboViewModel<MultiTrackFxA> SelectedMultiFxA { get; }
        public PropertyEnumComboViewModel<MultiTrackFxB> SelectedMultiFxB { get; }
        public PropertyEnumComboViewModel<MultiTrackFxC> SelectedMultiFxC { get; }

        public SettingsMemoryTrackFxViewModel(SettingsMemoryTrackFxModel model)
            : base(model)
        {
            Mode = new PropertyEnumRadioViewModel<FxMode>(nameof(model.Mode), PropertySet);
            SingleEnabledFxSlot = new PropertyEnumRadioViewModel<FxSlotOrNone>(nameof(model.SingleEnabledFxSlot), PropertySet);
            SelectedFxSlot = new PropertyEnumRadioViewModel<FxSlot>(nameof(model.SelectedFxSlot), PropertySet);
            SelectedSingleFxA = new PropertyEnumComboViewModel<SingleTrackFx>(nameof(model.SelectedSingleFxA), PropertySet);
            SelectedSingleFxB = new PropertyEnumComboViewModel<SingleTrackFx>(nameof(model.SelectedSingleFxB), PropertySet);
            SelectedSingleFxC = new PropertyEnumComboViewModel<SingleTrackFx>(nameof(model.SelectedSingleFxC), PropertySet);
            MultiEnabledFxSlot = new PropertyBitwiseViewModel<FxSlotBitwise>(nameof(model.MultiEnabledFxSlot), PropertySet, new FxSlotBitwiseToLetterConverter());
            SelectedMultiFxA = new PropertyEnumComboViewModel<MultiTrackFxA>(nameof(model.SelectedMultiFxA), PropertySet);
            SelectedMultiFxB = new PropertyEnumComboViewModel<MultiTrackFxB>(nameof(model.SelectedMultiFxB), PropertySet);
            SelectedMultiFxC = new PropertyEnumComboViewModel<MultiTrackFxC>(nameof(model.SelectedMultiFxC), PropertySet);
        }
    }
}
