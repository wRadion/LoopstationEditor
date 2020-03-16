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
            Enabled = new PropertyBoolViewModel(AssignProperty.Enabled, _properties);
            Source = new PropertyEnumViewModel<AssignSource>(AssignProperty.Source, _properties);
            SourceMode = new PropertyEnumViewModel<AssignSourceMode>(AssignProperty.SourceMode, _properties);
            Target = new PropertyEnumViewModel<AssignTarget>(AssignProperty.Target, _properties);
            TargetMin = new PropertyIntViewModel(AssignProperty.TargetMin, _properties);
            TargetMax = new PropertyIntViewModel(AssignProperty.TargetMax, _properties);
        }
    }
}
