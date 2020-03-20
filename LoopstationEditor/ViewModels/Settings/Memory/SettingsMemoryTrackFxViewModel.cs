using LoopstationEditor.Converters.Bitwise;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory
{
    public class SettingsMemoryTrackFxViewModel : SettingsViewModel
    {
        public PropertyEnumRadioViewModel<FxMode> Mode { get; }
        public PropertyBoolViewModel MultiMode { get; }
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
            Mode = new PropertyEnumRadioViewModel<FxMode>(nameof(Mode), _properties);
            MultiMode = new PropertyBoolViewModel(nameof(MultiMode), _properties);
            SingleEnabledFxSlot = new PropertyEnumRadioViewModel<FxSlotOrNone>(nameof(SingleEnabledFxSlot), _properties);
            SelectedFxSlot = new PropertyEnumRadioViewModel<FxSlot>(nameof(SelectedFxSlot), _properties);
            SelectedSingleFxA = new PropertyEnumComboViewModel<SingleTrackFx>(nameof(SelectedSingleFxA), _properties);
            SelectedSingleFxB = new PropertyEnumComboViewModel<SingleTrackFx>(nameof(SelectedSingleFxB), _properties);
            SelectedSingleFxC = new PropertyEnumComboViewModel<SingleTrackFx>(nameof(SelectedSingleFxC), _properties);
            MultiEnabledFxSlot = new PropertyBitwiseViewModel<FxSlotBitwise>(nameof(MultiEnabledFxSlot), _properties, new FxSlotBitwiseToLetterConverter());
            SelectedMultiFxA = new PropertyEnumComboViewModel<MultiTrackFxA>(nameof(SelectedMultiFxA), _properties);
            SelectedMultiFxB = new PropertyEnumComboViewModel<MultiTrackFxB>(nameof(SelectedMultiFxB), _properties);
            SelectedMultiFxC = new PropertyEnumComboViewModel<MultiTrackFxC>(nameof(SelectedMultiFxC), _properties);
        }
    }
}
