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
            Mode = new PropertyEnumRadioViewModel<FxMode>(nameof(model.Mode), _properties);
            SingleEnabledFxSlot = new PropertyEnumRadioViewModel<FxSlotOrNone>(nameof(model.SingleEnabledFxSlot), _properties);
            SelectedFxSlot = new PropertyEnumRadioViewModel<FxSlot>(nameof(model.SelectedFxSlot), _properties);
            SelectedSingleFxA = new PropertyEnumComboViewModel<SingleInputFx>(nameof(model.SelectedSingleFxA), _properties);
            SelectedSingleFxB = new PropertyEnumComboViewModel<SingleInputFx>(nameof(model.SelectedSingleFxB), _properties);
            SelectedSingleFxC = new PropertyEnumComboViewModel<SingleInputFx>(nameof(model.SelectedSingleFxC), _properties);
            MultiEnabledFxSlot = new PropertyBitwiseViewModel<FxSlotBitwise>(nameof(model.MultiEnabledFxSlot), _properties, new FxSlotBitwiseToLetterConverter());
            SelectedMultiFxA = new PropertyEnumComboViewModel<MultiInputFxA>(nameof(model.SelectedMultiFxA), _properties);
            SelectedMultiFxB = new PropertyEnumComboViewModel<MultiInputFxB>(nameof(model.SelectedMultiFxB), _properties);
            SelectedMultiFxC = new PropertyEnumComboViewModel<MultiInputFxC>(nameof(model.SelectedMultiFxC), _properties);
        }
    }
}
