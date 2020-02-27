using System;
using System.Windows;
using System.Windows.Input;

using LoopstationEditor.Commands;
using LoopstationEditor.ViewModels.Base;

namespace LoopstationEditor.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private Window _window;

        public ICommand MinimizeCommand { get; }
        public ICommand MaximizeCommand { get; }
        public ICommand CloseCommand { get; }

        private string _icon;
        public object CurrentMaximizeIcon
        {
            get
            {
                if (String.IsNullOrWhiteSpace(_icon))
                    return DependencyProperty.UnsetValue;

                return _icon;
            }
            private set
            {
                _icon = value.ToString();
            }
        }

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
