using LoopstationEditor.Converters.Enum;
using LoopstationEditor.Converters.Int;
using LoopstationEditor.Models.Settings.System;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.System
{
    public class SettingsSystemUSBViewModel : SettingsViewModel
    {
        public PropertyEnumRadioViewModel<USBMode> Mode { get; }
        public PropertyEnumComboViewModel<USBAudioRouting> AudioRouting { get; }
        public PropertyIntViewModel InputLevel { get; }
        public PropertyIntViewModel OutputLevel { get; }

        public SettingsSystemUSBViewModel(SettingsSystemUSBModel model)
            : base(model)
        {
            Mode = new PropertyEnumRadioViewModel<USBMode>(nameof(model.Mode), _properties);
            AudioRouting = new PropertyEnumComboViewModel<USBAudioRouting>(nameof(model.AudioRouting), _properties, new EnumUSBAudioRoutingConverter());
            InputLevel = new PropertyIntViewModel(nameof(model.InputLevel), _properties, new IntLevelConverter());
            OutputLevel = new PropertyIntViewModel(nameof(model.OutputLevel), _properties, new IntLevelConverter());
        }
    }
}
