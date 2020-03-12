using System.Windows.Controls;

using LoopstationEditor.ViewModels.Settings;

namespace LoopstationEditor.Views.Settings.SystemSettings
{
    /// <summary>
    /// Interaction logic for InputOutputSettingsView.xaml
    /// </summary>
    public partial class InputOutputSettingsView : UserControl
    {
        public InputOutputSettingsView(InputOutputSettingsViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
