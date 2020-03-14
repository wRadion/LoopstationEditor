using System.Windows.Input;

using LoopstationEditor.Commands;
using LoopstationEditor.Models.Settings.System;
using LoopstationEditor.ViewModels.Settings.System;
using LoopstationEditor.Views.Settings;
using LoopstationEditor.Views.Settings.System_;

namespace LoopstationEditor.ViewModels
{
    public class LoopstationViewModel : ViewModel
    {
        public SettingsSystemModel _system;

        public ICommand OpenInputOutputSettingsWindow { get; }
        public ICommand OpenSetupSettingsWindow { get; }

        public LoopstationViewModel()
        {
            _system = new SettingsSystemModel();

            OpenInputOutputSettingsWindow = new RelayCommand(() =>
            {
                SettingsSystemInputOutputViewModel viewModel = new SettingsSystemInputOutputViewModel(_system.InputOutput);
                new SettingsWindow(viewModel, "Input/Output Settings", new SettingsSystemInputOutputView(viewModel)).Show();
            });

            OpenSetupSettingsWindow = new RelayCommand(() =>
            {
                SettingsSystemSetupViewModel viewModel = new SettingsSystemSetupViewModel(_system.Setup);
                new SettingsWindow(viewModel, "Setup Settings", new SettingsSystemSetupView(viewModel)).Show();
            });
        }
    }
}
