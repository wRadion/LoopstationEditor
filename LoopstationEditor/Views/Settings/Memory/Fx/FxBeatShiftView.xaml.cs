using System.Windows.Controls;

using LoopstationEditor.ViewModels.Settings.Memory.Fx;

namespace LoopstationEditor.Views.Settings.Memory.Fx
{
    /// <summary>
    /// Interaction logic for FxBeatShiftView.xaml
    /// </summary>
    public partial class FxBeatShiftView : UserControl
    {
        public FxBeatShiftView(FxBeatShiftViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
