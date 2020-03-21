using System.Windows.Controls;

using LoopstationEditor.ViewModels.Settings.Memory.Fx;

namespace LoopstationEditor.Views.Settings.Memory.Fx
{
    /// <summary>
    /// Interaction logic for FxRobotView.xaml
    /// </summary>
    public partial class FxRobotView : UserControl
    {
        public FxRobotView(FxRobotViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
