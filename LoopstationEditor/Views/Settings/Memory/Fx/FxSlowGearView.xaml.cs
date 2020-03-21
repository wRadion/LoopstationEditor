using System.Windows.Controls;

using LoopstationEditor.ViewModels.Settings.Memory.Fx;

namespace LoopstationEditor.Views.Settings.Memory.Fx
{
    /// <summary>
    /// Interaction logic for FxSlowGearView.xaml
    /// </summary>
    public partial class FxSlowGearView : UserControl
    {
        public FxSlowGearView(FxSlowGearViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
