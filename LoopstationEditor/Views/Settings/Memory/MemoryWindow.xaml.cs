using LoopstationEditor.ViewModels.Settings.Memory;

namespace LoopstationEditor.Views.Settings.Memory
{
    /// <summary>
    /// Interaction logic for MemoryWindow.xaml
    /// </summary>
    public partial class MemoryWindow : XenionDark.Windows.Window
    {
        public MemoryWindow(MemoryWindowViewModel viewModel)
        {
            InitializeComponent();
            SetViewModel(viewModel);
        }

        public void SetViewModel(MemoryWindowViewModel viewModel)
        {
            DataContext = viewModel;
            Title += $" - { viewModel.Id.ToString("D2") }";
        }

        private void OK_Click(object sender, System.Windows.RoutedEventArgs e) => Close();
        private void Cancel_Click(object sender, System.Windows.RoutedEventArgs e) => Close();
    }
}
