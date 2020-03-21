using System.Windows.Controls;

using LoopstationEditor.ViewModels.Settings.Memory.Fx;

namespace LoopstationEditor.Views.Settings.Memory.Fx
{
    /// <summary>
    /// Interaction logic for FxPanningDelayView.xaml
    /// </summary>
    public partial class FxPanningDelayView : UserControl
    {
        public FxPanningDelayView(FxPanningDelayViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
