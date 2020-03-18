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
            Mode = new PropertyEnumViewModel<FxMode>(nameof(Mode), _properties);
            MultiMode = new PropertyBoolViewModel(nameof(MultiMode), _properties);
            SingleEnabledFxSlot = new PropertyEnumViewModel<FxSlotOrNone>(nameof(SingleEnabledFxSlot), _properties);
            SelectedFxSlot = new PropertyEnumViewModel<FxSlot>(nameof(SelectedFxSlot), _properties);
            SelectedSingleFxA = new PropertyEnumViewModel<SingleInputFx>(nameof(SelectedSingleFxA), _properties);
            SelectedSingleFxB = new PropertyEnumViewModel<SingleInputFx>(nameof(SelectedSingleFxB), _properties);
            SelectedSingleFxC = new PropertyEnumViewModel<SingleInputFx>(nameof(SelectedSingleFxC), _properties);
            MultiEnabledFxSlot = new PropertyEnumViewModel<FxSlotBitwise>(nameof(MultiEnabledFxSlot), _properties);
            SelectedMultiFxA = new PropertyEnumViewModel<MultiInputFxA>(nameof(SelectedMultiFxA), _properties);
            SelectedMultiFxB = new PropertyEnumViewModel<MultiInputFxB>(nameof(SelectedMultiFxB), _properties);
            SelectedMultiFxC = new PropertyEnumViewModel<MultiInputFxC>(nameof(SelectedMultiFxC), _properties);
        }
    }
}
