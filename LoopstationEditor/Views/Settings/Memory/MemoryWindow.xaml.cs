using LoopstationEditor.ViewModels.Settings.Memory;
using System;
using System.ComponentModel;
using System.Windows;

namespace LoopstationEditor.Views.Settings.Memory
{
    /// <summary>
    /// Interaction logic for MemoryWindow.xaml
    /// </summary>
    public partial class MemoryWindow : XenionDark.Windows.Window
    {
        public static DependencyProperty SelectedSubtabIndexProperty = DependencyProperty.Register("SelectedSubtabIndex", typeof(int), typeof(MemoryWindow));

        public int SelectedSubtabIndex
        {
            get => (int)GetValue(SelectedSubtabIndexProperty);
            set => SetValue(SelectedSubtabIndexProperty, value);
        }

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
            Title += $" - { viewModel.Id.ToString("D2") } { viewModel.NameViewModel.Name }";

            viewModel.NameViewModelInitialized += ((nameViewModel) => nameViewModel.PropertyChanged += NameChanged);
        }

        private void NameChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName != "Name") return;

            MemoryWindowViewModel viewModel = (MemoryWindowViewModel)DataContext;
            Title += $" - { viewModel.Id.ToString("D2") } { viewModel.NameViewModel.Name }";
        }

        public void SetSelectedSubtabIndex(int index)
        {
            SelectedSubtabIndex = index;
        }

        private void OK_Click(object sender, RoutedEventArgs e) => Close();
        private void Cancel_Click(object sender, RoutedEventArgs e) => Close();
    }
}
