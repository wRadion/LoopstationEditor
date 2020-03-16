using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory
{
    public class SettingsMemoryRecOptionViewModel : SettingsViewModel
    {
        public PropertyEnumViewModel<RecOptionOverdubMode> OverdubMode { get; }
        public PropertyEnumViewModel<RecOptionRecordAction> RecordAction { get; }

        public SettingsMemoryRecOptionViewModel(SettingsMemoryRecOptionModel model)
            : base(model)
        {
            OverdubMode = new PropertyEnumViewModel<RecOptionOverdubMode>(RecOptionProperty.OverdubMode, _properties);
            RecordAction = new PropertyEnumViewModel<RecOptionRecordAction>(RecOptionProperty.RecordAction, _properties);
        }
    }
}
