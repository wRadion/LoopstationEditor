using System.Windows;
using System.Windows.Input;

using LoopstationEditor.Commands;
using LoopstationEditor.ViewModels.Base;

namespace LoopstationEditor.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private readonly Window _window;

        public ICommand MinimizeCommand { get; }
        public ICommand MaximizeCommand { get; }
        public ICommand CloseCommand { get; }

        public string CurrentMaximizeIcon { get; private set; }

        public MainWindowViewModel(Window window)
        {
            _window = window;

            MinimizeCommand = new RelayCommand(() => _window.WindowState = WindowState.Minimized);
            MaximizeCommand = new RelayCommand(Maximize);
            CloseCommand = new RelayCommand(_window.Close);

            SetCurrentMaximizeIcon();
        }

        private void Maximize()
        {
            if (_window.WindowState == WindowState.Maximized)
                _window.WindowState = WindowState.Normal;
            else
                _window.WindowState = WindowState.Maximized;

            SetCurrentMaximizeIcon();
        }

        public void SetCurrentMaximizeIcon()
        {
            string icon = _window.WindowState == WindowState.Maximized ? "unmaximize" : "maximize";

            CurrentMaximizeIcon = $"/Images/TitleBar/{ icon }_icon.png";
        }
    }
}
