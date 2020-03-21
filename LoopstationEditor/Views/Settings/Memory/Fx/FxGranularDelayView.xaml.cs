using System.Windows.Controls;

using LoopstationEditor.ViewModels.Settings.Memory.Fx;

namespace LoopstationEditor.Views.Settings.Memory.Fx
{
    /// <summary>
    /// Interaction logic for FxGranularDelayView.xaml
    /// </summary>
    public partial class FxGranularDelayView : UserControl
    {
        public FxGranularDelayView(FxGranularDelayViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
