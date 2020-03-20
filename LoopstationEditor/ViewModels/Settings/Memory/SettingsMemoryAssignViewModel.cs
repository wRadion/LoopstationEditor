using LoopstationEditor.Converters.Int;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory
{
    public class SettingsMemoryAssignViewModel : SettingsViewModel
    {
        public PropertyBoolViewModel Enabled { get; }
        public PropertyEnumComboViewModel<AssignSource> Source { get; }
        public PropertyEnumRadioViewModel<AssignSourceMode> SourceMode { get; }
        public PropertyEnumComboViewModel<AssignTarget> Target { get; }
        public PropertyIntViewModel TargetMin { get; }
        public PropertyIntViewModel TargetMax { get; }

        public SettingsMemoryAssignViewModel(SettingsMemoryAssignModel model)
            : base(model)
        {
            Enabled = new PropertyBoolViewModel(nameof(Enabled), _properties);
            Source = new PropertyEnumComboViewModel<AssignSource>(nameof(Source), _properties);
            SourceMode = new PropertyEnumRadioViewModel<AssignSourceMode>(nameof(SourceMode), _properties);
            Target = new PropertyEnumComboViewModel<AssignTarget>(nameof(Target), _properties);
            TargetMin = new PropertyIntViewModel(nameof(TargetMin), _properties, new IntTargetConverter());
            TargetMax = new PropertyIntViewModel(nameof(TargetMax), _properties, new IntTargetConverter());
        }
    }
}
