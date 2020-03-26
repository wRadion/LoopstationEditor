using LoopstationEditor.Converters.Int;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory
{
    public class SettingsMemoryAssignViewModel : SettingsViewModel
    {
        public readonly int AssignNumber;

        public PropertyBoolViewModel Enabled { get; }
        public PropertyEnumComboViewModel<AssignSource> Source { get; }
        public PropertyEnumRadioViewModel<AssignSourceMode> SourceMode { get; }
        public PropertyEnumComboViewModel<AssignTarget> Target { get; }
        public PropertyIntViewModel TargetMin { get; }
        public PropertyIntViewModel TargetMax { get; }

        public SettingsMemoryAssignViewModel(int assignNumber, SettingsMemoryAssignModel model)
            : base(model)
        {
            AssignNumber = assignNumber;

            Enabled = new PropertyBoolViewModel(nameof(model.Enabled), PropertySet);
            Source = new PropertyEnumComboViewModel<AssignSource>(nameof(model.Source), PropertySet);
            SourceMode = new PropertyEnumRadioViewModel<AssignSourceMode>(nameof(model.SourceMode), PropertySet);
            Target = new PropertyEnumComboViewModel<AssignTarget>(nameof(model.Target), PropertySet);
            TargetMin = new PropertyIntViewModel(nameof(model.TargetMin), PropertySet, new IntTargetConverter());
            TargetMax = new PropertyIntViewModel(nameof(model.TargetMax), PropertySet, new IntTargetConverter());
        }
    }
}
