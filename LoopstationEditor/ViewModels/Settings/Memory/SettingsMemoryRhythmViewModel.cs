using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory
{
    public class SettingsMemoryRhythmViewModel : SettingsViewModel
    {
        public PropertyBoolViewModel Switch { get; }
        public PropertyIntViewModel Level { get; }
        public PropertyEnumViewModel<RhythmPattern> Pattern { get; }
        public PropertyEnumViewModel<RhythmBeat> Beat { get; }
        public PropertyBoolViewModel LineOut { get; }
        public PropertyEnumViewModel<RhythmRecCount> RecCount { get; }
        public PropertyEnumViewModel<RhythmPlayCount> PlayCount { get; }
        public PropertyEnumViewModel<RhythmStopMode> StopMode { get; }

        public SettingsMemoryRhythmViewModel(SettingsMemoryRhythmModel model)
            : base(model)
        {
            Switch = new PropertyBoolViewModel(RhythmProperty.Switch, _properties);
            Level = new PropertyIntViewModel(RhythmProperty.Level, _properties);
            Pattern = new PropertyEnumViewModel<RhythmPattern>(RhythmProperty.Pattern, _properties);
            Beat = new PropertyEnumViewModel<RhythmBeat>(RhythmProperty.Beat, _properties);
            LineOut = new PropertyBoolViewModel(RhythmProperty.LineOut, _properties);
            RecCount = new PropertyEnumViewModel<RhythmRecCount>(RhythmProperty.RecCount, _properties);
            PlayCount = new PropertyEnumViewModel<RhythmPlayCount>(RhythmProperty.PlayCount, _properties);
            StopMode = new PropertyEnumViewModel<RhythmStopMode>(RhythmProperty.StopMode, _properties);
        }
    }
}
