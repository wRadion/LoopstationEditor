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
            Mode = new PropertyEnumRadioViewModel<USBMode>(nameof(model.Mode), PropertySet);
            AudioRouting = new PropertyEnumComboViewModel<USBAudioRouting>(nameof(model.AudioRouting), PropertySet, new EnumUSBAudioRoutingConverter());
            InputLevel = new PropertyIntViewModel(nameof(model.InputLevel), PropertySet, new IntLevelConverter());
            OutputLevel = new PropertyIntViewModel(nameof(model.OutputLevel), PropertySet, new IntLevelConverter());
        }
    }
}
