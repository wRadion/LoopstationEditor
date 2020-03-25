using LoopstationEditor.ViewModels;
using System.Windows.Controls;
using System.Windows.Input;

namespace LoopstationEditor.Views.MainWindow
{
    /// <summary>
    /// Interaction logic for MainWindowView.xaml
    /// </summary>
    public partial class MainWindowView : XenionDark.Windows.Window
    {
        private readonly MainWindowViewModel _viewModel;
        private int _oldValidSelectedIndex;

        public MainWindowView()
        {
            InitializeComponent();
            _viewModel = new MainWindowViewModel(this);
            DataContext = _viewModel;
        }

        private void MemoryListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int newIndex = MemoryListBox.SelectedIndex;

            if (newIndex >= 0)
                _oldValidSelectedIndex = newIndex;
            else
                MemoryListBox.SelectedIndex = _oldValidSelectedIndex;

            MemoryListBox.SelectedItem = _viewModel.MemoryNames[MemoryListBox.SelectedIndex];
            MemoryListBox.SelectedValue = MemoryListBox.SelectedItem;
        }

        private void CanExecuteDefault(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;

        private void NewSettings_Executed(object sender, ExecutedRoutedEventArgs e) => _viewModel.NewSettingsCommand.Execute(null);
        private void OpenSettings_Executed(object sender, ExecutedRoutedEventArgs e) => _viewModel.OpenSettingsCommand.Execute(null);
        private void SaveSettings_Executed(object sender, ExecutedRoutedEventArgs e) => _viewModel.SaveSettingsCommand.Execute(null);
        private void SaveSettingsAs_Executed(object sender, ExecutedRoutedEventArgs e) => _viewModel.SaveSettingsAsCommand.Execute(null);
    }
}
