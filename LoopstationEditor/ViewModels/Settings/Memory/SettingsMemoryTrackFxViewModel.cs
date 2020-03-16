using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory
{
    public class SettingsMemoryTrackFxViewModel : SettingsViewModel
    {
        public PropertyEnumViewModel<FxMode> Mode { get; }
        public PropertyBoolViewModel MultiMode { get; }
        public PropertyEnumViewModel<FxSlotOrNone> SingleEnabledFx { get; }
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
            Mode = new PropertyEnumViewModel<FxMode>(TrackFxProperty.Mode, _properties);
            MultiMode = new PropertyBoolViewModel(TrackFxProperty.MultiMode, _properties);
            SingleEnabledFx = new PropertyEnumViewModel<FxSlotOrNone>(TrackFxProperty.SingleEnabledFxSlot, _properties);
            SelectedFxSlot = new PropertyEnumViewModel<FxSlot>(TrackFxProperty.SelectedFxSlot, _properties);
            SelectedSingleFxA = new PropertyEnumViewModel<SingleTrackFx>(TrackFxProperty.SelectedSingleFxA, _properties);
            SelectedSingleFxB = new PropertyEnumViewModel<SingleTrackFx>(TrackFxProperty.SelectedSingleFxB, _properties);
            SelectedSingleFxC = new PropertyEnumViewModel<SingleTrackFx>(TrackFxProperty.SelectedSingleFxC, _properties);
            MultiEnabledFxSlot = new PropertyEnumViewModel<FxSlotBitwise>(TrackFxProperty.MultiEnabledFxSlot, _properties);
            SelectedMultiFxA = new PropertyEnumViewModel<MultiTrackFxA>(TrackFxProperty.SelectedMultiFxA, _properties);
            SelectedMultiFxB = new PropertyEnumViewModel<MultiTrackFxB>(TrackFxProperty.SelectedMultiFxB, _properties);
            SelectedMultiFxC = new PropertyEnumViewModel<MultiTrackFxC>(TrackFxProperty.SelectedMultiFxC, _properties);
        }
    }
}
