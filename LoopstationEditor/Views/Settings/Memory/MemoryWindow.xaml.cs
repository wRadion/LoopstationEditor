using System.ComponentModel;
using System.Windows;

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
            MemoryWindowViewModel oldViewModel = null;
            if (DataContext != null)
                oldViewModel = (MemoryWindowViewModel)DataContext;

            DataContext = viewModel;
            Title += $" - { viewModel.Id:D2} { viewModel.NameViewModel.Name }";

            viewModel.NameViewModelInitialized += (nameViewModel) => nameViewModel.PropertyChanged += NameChanged;
        }

        private void NameChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName != "Name") return;

            MemoryWindowViewModel viewModel = (MemoryWindowViewModel)DataContext;
            Title += $" - { viewModel.Id:D2} { viewModel.NameViewModel.Name }";
        }

        private void OK_Click(object sender, RoutedEventArgs e) => Close();
        private void Cancel_Click(object sender, RoutedEventArgs e) => Close();
    }
}
