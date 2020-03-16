using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory
{
    public class SettingsMemoryInputFxViewModel : SettingsViewModel
    {
        public PropertyEnumViewModel<FxMode> Mode { get; }
        public PropertyBoolViewModel MultiMode { get; }
        public PropertyEnumViewModel<FxSlotOrNone> SingleEnabledFxSlot { get; }
        public PropertyEnumViewModel<FxSlot> SelectedFxSlot { get; }
        public PropertyEnumViewModel<SingleInputFx> SelectedSingleFxA { get; }
        public PropertyEnumViewModel<SingleInputFx> SelectedSingleFxB { get; }
        public PropertyEnumViewModel<SingleInputFx> SelectedSingleFxC { get; }
        public PropertyEnumViewModel<FxSlotBitwise> MultiEnabledFxSlot { get; }
        public PropertyEnumViewModel<MultiInputFxA> SelectedMultiFxA { get; }
        public PropertyEnumViewModel<MultiInputFxB> SelectedMultiFxB { get; }
        public PropertyEnumViewModel<MultiInputFxC> SelectedMultiFxC { get; }

        public SettingsMemoryInputFxViewModel(SettingsMemoryInputFxModel model)
            : base(model)
        {
            Mode = new PropertyEnumViewModel<FxMode>(InputFxProperty.Mode, _properties);
            MultiMode = new PropertyBoolViewModel(InputFxProperty.MultiMode, _properties);
            SingleEnabledFxSlot = new PropertyEnumViewModel<FxSlotOrNone>(InputFxProperty.SingleEnabledFxSlot, _properties);
            SelectedFxSlot = new PropertyEnumViewModel<FxSlot>(InputFxProperty.SelectedFxSlot, _properties);
            SelectedSingleFxA = new PropertyEnumViewModel<SingleInputFx>(InputFxProperty.SelectedSingleFxA, _properties);
            SelectedSingleFxB = new PropertyEnumViewModel<SingleInputFx>(InputFxProperty.SelectedSingleFxB, _properties);
            SelectedSingleFxC = new PropertyEnumViewModel<SingleInputFx>(InputFxProperty.SelectedSingleFxC, _properties);
            MultiEnabledFxSlot = new PropertyEnumViewModel<FxSlotBitwise>(InputFxProperty.MultiEnabledFxSlot, _properties);
            SelectedMultiFxA = new PropertyEnumViewModel<MultiInputFxA>(InputFxProperty.SelectedMultiFxA, _properties);
            SelectedMultiFxB = new PropertyEnumViewModel<MultiInputFxB>(InputFxProperty.SelectedMultiFxB, _properties);
            SelectedMultiFxC = new PropertyEnumViewModel<MultiInputFxC>(InputFxProperty.SelectedMultiFxC, _properties);
        }
    }
}
