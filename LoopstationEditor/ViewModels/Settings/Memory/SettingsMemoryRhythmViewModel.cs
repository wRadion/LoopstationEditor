using LoopstationEditor.Converters.Enum;
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
            Enabled = new PropertyBoolViewModel(nameof(model.Enabled), _properties);
            Level = new PropertyIntViewModel(nameof(model.Level), _properties, new IntLevelConverter());
            Pattern = new PropertyEnumComboViewModel<RhythmPattern>(nameof(model.Pattern), _properties, new EnumRhythmPatternConverter());
            Beat = new PropertyEnumComboViewModel<RhythmBeat>(nameof(model.Beat), _properties, new EnumTimeSignatureConverter<RhythmBeat>());
            LineOut = new PropertyBoolViewModel(nameof(model.LineOut), _properties);
            RecCount = new PropertyEnumRadioViewModel<RhythmRecCount>(nameof(model.RecCount), _properties);
            PlayCount = new PropertyEnumRadioViewModel<RhythmPlayCount>(nameof(model.PlayCount), _properties);
            StopMode = new PropertyEnumRadioViewModel<RhythmStopMode>(nameof(model.StopMode), _properties);
        }
    }
}
