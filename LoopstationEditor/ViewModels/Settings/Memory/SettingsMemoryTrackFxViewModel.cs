using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory
{
    public class SettingsMemoryTrackFxViewModel : SettingsViewModel
    {
        public PropertyEnumViewModel<FxMode> Mode { get; }
        public PropertyBoolViewModel MultiMode { get; }
        public PropertyEnumViewModel<FxSlotOrNone> SingleEnabledFxSlot { get; }
        public PropertyEnumViewModel<FxSlot> SelectedFxSlot { get; }
        public PropertyEnumViewModel<SingleTrackFx> SelectedSingleFxA { get; }
        public PropertyEnumViewModel<SingleTrackFx> SelectedSingleFxB { get; }
        public PropertyEnumViewModel<SingleTrackFx> SelectedSingleFxC { get; }
        public PropertyEnumViewModel<FxSlotBitwise> MultiEnabledFxSlot { get; }
        public PropertyEnumViewModel<MultiTrackFxA> SelectedMultiFxA { get; }
        public PropertyEnumViewModel<MultiTrackFxB> SelectedMultiFxB { get; }
        public PropertyEnumViewModel<MultiTrackFxC> SelectedMultiFxC { get; }

        public SettingsMemoryTrackFxViewModel(SettingsMemoryTrackFxModel model)
            : base(model)
        {
            Mode = new PropertyEnumViewModel<FxMode>(nameof(Mode), _properties);
            MultiMode = new PropertyBoolViewModel(nameof(MultiMode), _properties);
            SingleEnabledFxSlot = new PropertyEnumViewModel<FxSlotOrNone>(nameof(SingleEnabledFxSlot), _properties);
            SelectedFxSlot = new PropertyEnumViewModel<FxSlot>(nameof(SelectedFxSlot), _properties);
            SelectedSingleFxA = new PropertyEnumViewModel<SingleTrackFx>(nameof(SelectedSingleFxA), _properties);
            SelectedSingleFxB = new PropertyEnumViewModel<SingleTrackFx>(nameof(SelectedSingleFxB), _properties);
            SelectedSingleFxC = new PropertyEnumViewModel<SingleTrackFx>(nameof(SelectedSingleFxC), _properties);
            MultiEnabledFxSlot = new PropertyEnumViewModel<FxSlotBitwise>(nameof(MultiEnabledFxSlot), _properties);
            SelectedMultiFxA = new PropertyEnumViewModel<MultiTrackFxA>(nameof(SelectedMultiFxA), _properties);
            SelectedMultiFxB = new PropertyEnumViewModel<MultiTrackFxB>(nameof(SelectedMultiFxB), _properties);
            SelectedMultiFxC = new PropertyEnumViewModel<MultiTrackFxC>(nameof(SelectedMultiFxC), _properties);
        }
    }
}
