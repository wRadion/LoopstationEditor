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
            OverdubMode = new PropertyEnumRadioViewModel<RecOptionOverdubMode>(nameof(model.OverdubMode), PropertySet);
            RecordAction = new PropertyEnumRadioViewModel<RecOptionRecordAction>(nameof(model.RecordAction), PropertySet);
            RecordQuantize = new PropertyIntViewModel(nameof(model.RecordQuantize), PropertySet);
        }
    }
}
