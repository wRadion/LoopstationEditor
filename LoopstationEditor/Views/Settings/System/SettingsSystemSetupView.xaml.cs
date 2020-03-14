using System.Windows.Controls;

using LoopstationEditor.ViewModels.Settings.System;

namespace LoopstationEditor.Views.Settings.System_
{
    /// <summary>
    /// Interaction logic for SettingsSystemSetupView.xaml
    /// </summary>
    public partial class SettingsSystemSetupView : UserControl
    {
        public SettingsSystemSetupView(SettingsSystemSetupViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
