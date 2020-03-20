using LoopstationEditor.Converters.Int;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory
{
    public class SettingsMemoryRhythmViewModel : SettingsViewModel
    {
        public PropertyBoolViewModel Enabled { get; }
        public PropertyIntViewModel Level { get; }
        public PropertyEnumComboViewModel<RhythmPattern> Pattern { get; }
        public PropertyEnumComboViewModel<RhythmBeat> Beat { get; }
        public PropertyBoolViewModel LineOut { get; }
        public PropertyEnumRadioViewModel<RhythmRecCount> RecCount { get; }
        public PropertyEnumRadioViewModel<RhythmPlayCount> PlayCount { get; }
        public PropertyEnumRadioViewModel<RhythmStopMode> StopMode { get; }

        public SettingsMemoryRhythmViewModel(SettingsMemoryRhythmModel model)
            : base(model)
        {
            Enabled = new PropertyBoolViewModel(nameof(Enabled), _properties);
            Level = new PropertyIntViewModel(nameof(Level), _properties, new IntLevelConverter());
            Pattern = new PropertyEnumComboViewModel<RhythmPattern>(nameof(Pattern), _properties);
            Beat = new PropertyEnumComboViewModel<RhythmBeat>(nameof(Beat), _properties);
            LineOut = new PropertyBoolViewModel(nameof(LineOut), _properties);
            RecCount = new PropertyEnumRadioViewModel<RhythmRecCount>(nameof(RecCount), _properties);
            PlayCount = new PropertyEnumRadioViewModel<RhythmPlayCount>(nameof(PlayCount), _properties);
            StopMode = new PropertyEnumRadioViewModel<RhythmStopMode>(nameof(StopMode), _properties);
        }
    }
}
