using System;
using System.Windows;
using System.Windows.Input;

using LoopstationEditor.ViewModels;

namespace LoopstationEditor.Views.MainWindow
{
    /// <summary>
    /// Interaction logic for MainWindowView.xaml
    /// </summary>
    public partial class MainWindowView : Window
    {
        public MainWindowView()
        {
            InitializeComponent();

            MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = new MainWindowViewModel(this);
        }

        private void Window_StateChanged(object sender, EventArgs e)
        {
            ((MainWindowViewModel)DataContext).SetCurrentMaximizeIcon();

            if (WindowState == WindowState.Maximized)
            {
                TopOffset.Visibility = Visibility.Visible;
                LeftOffset.Visibility = Visibility.Visible;
                RightOffset.Visibility = Visibility.Visible;
            }
            else
            {
                TopOffset.Visibility = Visibility.Collapsed;
                LeftOffset.Visibility = Visibility.Collapsed;
                RightOffset.Visibility = Visibility.Collapsed;
            }
        }

        private void TitleBarControl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
