using LoopstationEditor.Models.Settings.System;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.System
{
    public class SettingsSystemInputOutputViewModel : SettingsViewModel
    {
        public PropertyIntViewModel InputNSThreshold { get; }
        public PropertyIntViewModel LineOutLevel { get; }
        public PropertyEnumViewModel<IOInputSource> InputSource { get; }
        public PropertyBoolViewModel InputLineOut { get; }
        public PropertyEnumViewModel<IOOutputLevelSelection> OutputLevelSelection { get; }

        public SettingsSystemInputOutputViewModel(SettingsSystemInputOutputModel model)
            : base(model)
        {
            InputNSThreshold = new PropertyIntViewModel(InputOutputProperty.InputNSThreshold, _properties);
            LineOutLevel = new PropertyIntViewModel(InputOutputProperty.LineOutLevel, _properties);
            InputSource = new PropertyEnumViewModel<IOInputSource>(InputOutputProperty.InputSource, _properties);
            InputLineOut = new PropertyBoolViewModel(InputOutputProperty.InputLineOut, _properties);
            OutputLevelSelection = new PropertyEnumViewModel<IOOutputLevelSelection>(InputOutputProperty.OutputLevelSelection, _properties);
        }
    }
}
