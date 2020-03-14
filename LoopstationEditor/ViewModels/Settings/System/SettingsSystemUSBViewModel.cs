using LoopstationEditor.Models.Settings.System;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.System
{
    public class SettingsSystemUSBViewModel : SettingsViewModel
    {
        public PropertyEnumViewModel<USBMode> Mode { get; }
        public PropertyEnumViewModel<USBAudioRouting> AudioRouting { get; }
        public PropertyIntViewModel InputLevel { get; }
        public PropertyIntViewModel OutputLevel { get; }

        public SettingsSystemUSBViewModel(SettingsSystemUSBModel model)
            : base(model)
        {
            Mode = new PropertyEnumViewModel<USBMode>(USBProperty.Mode, _properties);
            AudioRouting = new PropertyEnumViewModel<USBAudioRouting>(USBProperty.AudioRouting, _properties);
            InputLevel = new PropertyIntViewModel(USBProperty.InputLevel, _properties);
            OutputLevel = new PropertyIntViewModel(USBProperty.OutputLevel, _properties);
        }
    }
}
