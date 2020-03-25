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
            DataContext = viewModel;
            Title += $" - { viewModel.Id:D2} { viewModel.NameViewModel.Name }";

            viewModel.NameViewModel.PropertyChanged += NameChanged;
        }

        private void NameChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName != "Name") return;

            MemoryWindowViewModel viewModel = (MemoryWindowViewModel)DataContext;
            Title += $" - { viewModel.Id:D2} { viewModel.NameViewModel.Name }";
        }
    }
}
