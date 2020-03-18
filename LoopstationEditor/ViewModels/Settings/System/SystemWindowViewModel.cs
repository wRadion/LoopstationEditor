using System.Windows.Input;

using LoopstationEditor.Commands;
using LoopstationEditor.Models.Settings.System;
using LoopstationEditor.Views.Settings.System_;

namespace LoopstationEditor.ViewModels.Settings.System
{
    public enum SystemTab
    {
        SETUP = 0,
        INPUT_OUTPUT = 1,
        USB = 2,
        MIDI = 3
    }

    public class SystemWindowViewModel : WindowViewModel<SystemWindow>
    {
        public SettingsSystemSetupViewModel SetupViewModel { get; private set; }
        public SettingsSystemInputOutputViewModel InputOutputViewModel { get; private set; }
        public SettingsSystemUSBViewModel USBViewModel { get; private set; }
        public SettingsSystemMIDIViewModel MIDIViewModel { get; private set; }

        public SystemWindowViewModel(SystemModel model)
            : base(model)
        {
            SelectTab(SystemTab.SETUP);

            ApplyChangesCommand = new RelayCommand(() =>
            {
                SetupViewModel.ApplyChanges();
                InputOutputViewModel.ApplyChanges();
                USBViewModel.ApplyChanges();
                MIDIViewModel.ApplyChanges();
            });
        }

        protected override void InitViewModels()
        {
            SystemModel model = (SystemModel)_model;

            SetupViewModel = new SettingsSystemSetupViewModel(model.Setup);
            InputOutputViewModel = new SettingsSystemInputOutputViewModel(model.InputOutput);
            USBViewModel = new SettingsSystemUSBViewModel(model.USB);
            MIDIViewModel = new SettingsSystemMIDIViewModel(model.MIDI);
        }
    }
}
