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
            InputNSThreshold = new PropertyIntViewModel(nameof(model.InputNSThreshold), _properties);
            LineOutLevel = new PropertyIntViewModel(nameof(model.LineOutLevel), _properties, new IntLevelConverter());
            InputSource = new PropertyEnumRadioViewModel<IOInputSource>(nameof(model.InputSource), _properties);
            InputLineOut = new PropertyBoolViewModel(nameof(model.InputLineOut), _properties);
            OutputLevelSelection = new PropertyEnumRadioViewModel<IOOutputLevelSelection>(nameof(model.OutputLevelSelection), _properties);
        }
    }
}
