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
            InputNSThreshold = new PropertyIntViewModel(nameof(InputNSThreshold), _properties);
            LineOutLevel = new PropertyIntViewModel(nameof(LineOutLevel), _properties, new IntLevelConverter());
            InputSource = new PropertyEnumRadioViewModel<IOInputSource>(nameof(InputSource), _properties);
            InputLineOut = new PropertyBoolViewModel(nameof(InputLineOut), _properties);
            OutputLevelSelection = new PropertyEnumRadioViewModel<IOOutputLevelSelection>(nameof(OutputLevelSelection), _properties);
        }
    }
}
