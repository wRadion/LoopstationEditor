using System.Windows.Input;

using LoopstationEditor.Commands;
using LoopstationEditor.Models.Settings;
using LoopstationEditor.ViewModels.Settings;
using LoopstationEditor.Views.Settings;
using LoopstationEditor.Views.Settings.SystemSettings;

namespace LoopstationEditor.ViewModels
{
    public class LoopstationViewModel : ViewModel
    {
        public SettingsSystemModel _system;

        public ICommand OpenInputOutputSettingsWindow { get; }

        public LoopstationViewModel()
        {
            _system = new SettingsSystemModel();

            OpenInputOutputSettingsWindow = new RelayCommand(() =>
            {
                SettingsSystemInputOutputViewModel viewModel = new SettingsSystemInputOutputViewModel(_system.InputOutput);
                new SettingsWindow(viewModel, "Input/Output Settings", new SettingsSystemInputOutputView(viewModel)).Show();
            });
        }
    }
}
