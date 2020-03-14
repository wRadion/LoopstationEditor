using System.Windows.Controls;

using LoopstationEditor.ViewModels.Settings.System;

namespace LoopstationEditor.Views.Settings.System_
{
    /// <summary>
    /// Interaction logic for InputOutputSettingsView.xaml
    /// </summary>
    public partial class SettingsSystemInputOutputView : UserControl
    {
        public SettingsSystemInputOutputView(SettingsSystemInputOutputViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
