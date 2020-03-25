using LoopstationEditor.ViewModels.Settings.System;

namespace LoopstationEditor.Views.Settings.System_
{
    /// <summary>
    /// Interaction logic for SystemWindow.xaml
    /// </summary>
    public partial class SystemWindow : XenionDark.Windows.Window
    {
        public SystemWindow(SystemWindowViewModel viewModel)
        {
            InitializeComponent();
            SetViewModel(viewModel);
        }

        public void SetViewModel(SystemWindowViewModel viewModel)
        {
            DataContext = viewModel;
        }
    }
}
