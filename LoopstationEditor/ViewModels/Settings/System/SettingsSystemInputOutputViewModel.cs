using LoopstationEditor.Converters.Int;
using LoopstationEditor.Models.Settings.System;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.System
{
    public class SettingsSystemInputOutputViewModel : SettingsViewModel
    {
        public PropertyIntViewModel InputNSThreshold { get; }
        public PropertyIntViewModel LineOutLevel { get; }
        public PropertyEnumRadioViewModel<IOInputSource> InputSource { get; }
        public PropertyBoolViewModel InputLineOut { get; }
        public PropertyEnumRadioViewModel<IOOutputLevelSelection> OutputLevelSelection { get; }

        public SettingsSystemInputOutputViewModel(SettingsSystemInputOutputModel model)
            : base(model)
        {
            InputNSThreshold = new PropertyIntViewModel(nameof(model.InputNSThreshold), PropertySet);
            LineOutLevel = new PropertyIntViewModel(nameof(model.LineOutLevel), PropertySet, new IntLevelConverter());
            InputSource = new PropertyEnumRadioViewModel<IOInputSource>(nameof(model.InputSource), PropertySet);
            InputLineOut = new PropertyBoolViewModel(nameof(model.InputLineOut), PropertySet);
            OutputLevelSelection = new PropertyEnumRadioViewModel<IOOutputLevelSelection>(nameof(model.OutputLevelSelection), PropertySet);
        }
    }
}
