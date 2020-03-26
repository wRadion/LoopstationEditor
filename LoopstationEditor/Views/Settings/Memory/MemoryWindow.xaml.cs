using System.ComponentModel;

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
            UpdateMemoryName(viewModel);
            viewModel.NameViewModel.PropertyChanged += (sender, e) => UpdateMemoryName(viewModel);
        }

        private void UpdateMemoryName(MemoryWindowViewModel viewModel)
        {
            Title = $"Memory Settings - { viewModel.Id:D2} { viewModel.NameViewModel.Name }";
        }
    }
}
