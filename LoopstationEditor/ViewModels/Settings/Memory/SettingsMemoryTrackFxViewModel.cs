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
            Mode = new PropertyEnumRadioViewModel<FxMode>(nameof(model.Mode), _properties);
            SingleEnabledFxSlot = new PropertyEnumRadioViewModel<FxSlotOrNone>(nameof(model.SingleEnabledFxSlot), _properties);
            SelectedFxSlot = new PropertyEnumRadioViewModel<FxSlot>(nameof(model.SelectedFxSlot), _properties);
            SelectedSingleFxA = new PropertyEnumComboViewModel<SingleTrackFx>(nameof(model.SelectedSingleFxA), _properties);
            SelectedSingleFxB = new PropertyEnumComboViewModel<SingleTrackFx>(nameof(model.SelectedSingleFxB), _properties);
            SelectedSingleFxC = new PropertyEnumComboViewModel<SingleTrackFx>(nameof(model.SelectedSingleFxC), _properties);
            MultiEnabledFxSlot = new PropertyBitwiseViewModel<FxSlotBitwise>(nameof(model.MultiEnabledFxSlot), _properties, new FxSlotBitwiseToLetterConverter());
            SelectedMultiFxA = new PropertyEnumComboViewModel<MultiTrackFxA>(nameof(model.SelectedMultiFxA), _properties);
            SelectedMultiFxB = new PropertyEnumComboViewModel<MultiTrackFxB>(nameof(model.SelectedMultiFxB), _properties);
            SelectedMultiFxC = new PropertyEnumComboViewModel<MultiTrackFxC>(nameof(model.SelectedMultiFxC), _properties);
        }
    }
}
