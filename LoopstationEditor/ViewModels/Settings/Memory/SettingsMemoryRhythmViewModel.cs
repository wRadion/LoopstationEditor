using LoopstationEditor.Converters.Int;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory
{
    public class SettingsMemoryRhythmViewModel : SettingsViewModel
    {
        public PropertyBoolViewModel Enabled { get; }
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
            Enabled = new PropertyBoolViewModel(nameof(Enabled), _properties);
            Level = new PropertyIntViewModel(nameof(Level), _properties, new IntLevelConverter());
            Pattern = new PropertyEnumViewModel<RhythmPattern>(nameof(Pattern), _properties);
            Beat = new PropertyEnumViewModel<RhythmBeat>(nameof(Beat), _properties);
            LineOut = new PropertyBoolViewModel(nameof(LineOut), _properties);
            RecCount = new PropertyEnumViewModel<RhythmRecCount>(nameof(RecCount), _properties);
            PlayCount = new PropertyEnumViewModel<RhythmPlayCount>(nameof(PlayCount), _properties);
            StopMode = new PropertyEnumViewModel<RhythmStopMode>(nameof(StopMode), _properties);
        }
    }
}
