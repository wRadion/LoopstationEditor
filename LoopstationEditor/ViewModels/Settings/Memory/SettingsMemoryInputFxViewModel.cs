using LoopstationEditor.Converters.Bitwise;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory
{
    public class SettingsMemoryInputFxViewModel : SettingsViewModel
    {
        public PropertyEnumRadioViewModel<FxMode> Mode { get; }
        public PropertyEnumRadioViewModel<FxSlotOrNone> SingleEnabledFxSlot { get; }
        public PropertyEnumRadioViewModel<FxSlot> SelectedFxSlot { get; }
        public PropertyEnumComboViewModel<SingleInputFx> SelectedSingleFxA { get; }
        public PropertyEnumComboViewModel<SingleInputFx> SelectedSingleFxB { get; }
        public PropertyEnumComboViewModel<SingleInputFx> SelectedSingleFxC { get; }
        public PropertyBitwiseViewModel<FxSlotBitwise> MultiEnabledFxSlot { get; }
        public PropertyEnumComboViewModel<MultiInputFxA> SelectedMultiFxA { get; }
        public PropertyEnumComboViewModel<MultiInputFxB> SelectedMultiFxB { get; }
        public PropertyEnumComboViewModel<MultiInputFxC> SelectedMultiFxC { get; }

        public SettingsMemoryInputFxViewModel(SettingsMemoryInputFxModel model)
            : base(model)
        {
            Mode = new PropertyEnumRadioViewModel<FxMode>(nameof(model.Mode), PropertySet);
            SingleEnabledFxSlot = new PropertyEnumRadioViewModel<FxSlotOrNone>(nameof(model.SingleEnabledFxSlot), PropertySet);
            SelectedFxSlot = new PropertyEnumRadioViewModel<FxSlot>(nameof(model.SelectedFxSlot), PropertySet);
            SelectedSingleFxA = new PropertyEnumComboViewModel<SingleInputFx>(nameof(model.SelectedSingleFxA), PropertySet);
            SelectedSingleFxB = new PropertyEnumComboViewModel<SingleInputFx>(nameof(model.SelectedSingleFxB), PropertySet);
            SelectedSingleFxC = new PropertyEnumComboViewModel<SingleInputFx>(nameof(model.SelectedSingleFxC), PropertySet);
            MultiEnabledFxSlot = new PropertyBitwiseViewModel<FxSlotBitwise>(nameof(model.MultiEnabledFxSlot), PropertySet, new FxSlotBitwiseToLetterConverter());
            SelectedMultiFxA = new PropertyEnumComboViewModel<MultiInputFxA>(nameof(model.SelectedMultiFxA), PropertySet);
            SelectedMultiFxB = new PropertyEnumComboViewModel<MultiInputFxB>(nameof(model.SelectedMultiFxB), PropertySet);
            SelectedMultiFxC = new PropertyEnumComboViewModel<MultiInputFxC>(nameof(model.SelectedMultiFxC), PropertySet);
        }
    }
}
