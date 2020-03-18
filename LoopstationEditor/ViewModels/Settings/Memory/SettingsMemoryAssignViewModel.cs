using LoopstationEditor.Converters.Int;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory
{
    public class SettingsMemoryAssignViewModel : SettingsViewModel
    {
        public PropertyBoolViewModel Enabled { get; }
        public PropertyEnumViewModel<AssignSource> Source { get; }
        public PropertyEnumViewModel<AssignSourceMode> SourceMode { get; }
        public PropertyEnumViewModel<AssignTarget> Target { get; }
        public PropertyIntViewModel TargetMin { get; }
        public PropertyIntViewModel TargetMax { get; }

        public SettingsMemoryAssignViewModel(SettingsMemoryAssignModel model)
            : base(model)
        {
            Enabled = new PropertyBoolViewModel(nameof(Enabled), _properties);
            Source = new PropertyEnumViewModel<AssignSource>(nameof(Source), _properties);
            SourceMode = new PropertyEnumViewModel<AssignSourceMode>(nameof(SourceMode), _properties);
            Target = new PropertyEnumViewModel<AssignTarget>(nameof(Target), _properties);
            TargetMin = new PropertyIntViewModel(nameof(TargetMin), _properties, new IntTargetConverter());
            TargetMax = new PropertyIntViewModel(nameof(TargetMax), _properties, new IntTargetConverter());
        }
    }
}
