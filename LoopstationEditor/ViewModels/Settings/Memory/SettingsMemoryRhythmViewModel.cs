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
            Enabled = new PropertyBoolViewModel(nameof(model.Enabled), PropertySet);
            Level = new PropertyIntViewModel(nameof(model.Level), PropertySet, new IntLevelConverter());
            Pattern = new PropertyEnumComboViewModel<RhythmPattern>(nameof(model.Pattern), PropertySet, new EnumRhythmPatternConverter());
            Beat = new PropertyEnumComboViewModel<RhythmBeat>(nameof(model.Beat), PropertySet, new EnumTimeSignatureConverter<RhythmBeat>());
            LineOut = new PropertyBoolViewModel(nameof(model.LineOut), PropertySet);
            RecCount = new PropertyEnumRadioViewModel<RhythmRecCount>(nameof(model.RecCount), PropertySet);
            PlayCount = new PropertyEnumRadioViewModel<RhythmPlayCount>(nameof(model.PlayCount), PropertySet);
            StopMode = new PropertyEnumRadioViewModel<RhythmStopMode>(nameof(model.StopMode), PropertySet);
        }
    }
}
