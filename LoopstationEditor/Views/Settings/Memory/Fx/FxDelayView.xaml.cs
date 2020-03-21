using System.Windows.Controls;

using LoopstationEditor.ViewModels.Settings.Memory.Fx;

namespace LoopstationEditor.Views.Settings.Memory.Fx
{
    /// <summary>
    /// Interaction logic for FxDelayView.xaml
    /// </summary>
    public partial class FxDelayView : UserControl
    {
        public FxDelayView(FxDelayViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
