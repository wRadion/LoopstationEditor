using System;

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
        public override SettingsViewModel CurrentViewModel
        {
            get
            {
                switch (GetCurrentTab<SystemTab>())
                {
                    case SystemTab.SETUP: return SetupViewModel;
                    case SystemTab.INPUT_OUTPUT: return InputOutputViewModel;
                    case SystemTab.USB: return USBViewModel;
                    case SystemTab.MIDI: return MIDIViewModel;
                }

                throw new InvalidOperationException("Current system tab is not valid.");
            }
        }

        public SettingsSystemSetupViewModel SetupViewModel { get; private set; }
        public SettingsSystemInputOutputViewModel InputOutputViewModel { get; private set; }
        public SettingsSystemUSBViewModel USBViewModel { get; private set; }
        public SettingsSystemMIDIViewModel MIDIViewModel { get; private set; }

        public SystemWindowViewModel(SystemModel model)
            : base(model)
        {
            SetupViewModel = new SettingsSystemSetupViewModel(model.Setup);
            InputOutputViewModel = new SettingsSystemInputOutputViewModel(model.InputOutput);
            USBViewModel = new SettingsSystemUSBViewModel(model.USB);
            MIDIViewModel = new SettingsSystemMIDIViewModel(model.MIDI);

            SelectTab(SystemTab.SETUP);
        }

        public override void ApplyChanges()
        {
            SetupViewModel.ApplyChanges();
            InputOutputViewModel.ApplyChanges();
            USBViewModel.ApplyChanges();
            MIDIViewModel.ApplyChanges();
        }

        public override void RevertChanges()
        {
            SetupViewModel.RevertChanges();
            InputOutputViewModel.RevertChanges();
            USBViewModel.RevertChanges();
            MIDIViewModel.RevertChanges();
        }
    }
}
