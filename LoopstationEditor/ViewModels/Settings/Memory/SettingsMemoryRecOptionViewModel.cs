using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory
{
    public class SettingsMemoryRecOptionViewModel : SettingsViewModel
    {
        public PropertyEnumRadioViewModel<RecOptionOverdubMode> OverdubMode { get; }
        public PropertyEnumRadioViewModel<RecOptionRecordAction> RecordAction { get; }
        public PropertyIntViewModel RecordQuantize { get; }

        public SettingsMemoryRecOptionViewModel(SettingsMemoryRecOptionModel model)
            : base(model)
        {
            OverdubMode = new PropertyEnumRadioViewModel<RecOptionOverdubMode>(nameof(OverdubMode), _properties);
            RecordAction = new PropertyEnumRadioViewModel<RecOptionRecordAction>(nameof(RecordAction), _properties);
            RecordQuantize = new PropertyIntViewModel(nameof(RecordQuantize), _properties);
        }
    }
}
