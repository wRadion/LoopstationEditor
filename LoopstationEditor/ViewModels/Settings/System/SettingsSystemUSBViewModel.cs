using LoopstationEditor.Converters.Int;
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
            Mode = new PropertyEnumViewModel<USBMode>(nameof(Mode), _properties);
            AudioRouting = new PropertyEnumViewModel<USBAudioRouting>(nameof(AudioRouting), _properties);
            InputLevel = new PropertyIntViewModel(nameof(InputLevel), _properties, new IntLevelConverter());
            OutputLevel = new PropertyIntViewModel(nameof(OutputLevel), _properties, new IntLevelConverter());
        }
    }
}
