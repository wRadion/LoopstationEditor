using System.Windows.Controls;

using LoopstationEditor.ViewModels.Settings;

namespace LoopstationEditor.Views.Settings
{
    /// <summary>
    /// Interaction logic for SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : XenionDark.Windows.Window
    {
        public SettingsWindow(SettingsViewModel viewModel, string title, UserControl control)
        {
            InitializeComponent();
            DataContext = viewModel;
            Title = title;
            MainContent.Child = control;
        }

        private void OK_Click(object sender, System.Windows.RoutedEventArgs e) => Close();
        private void Cancel_Click(object sender, System.Windows.RoutedEventArgs e) => Close();
    }
}
