using System.Windows.Controls;

using LoopstationEditor.ViewModels.Settings.Memory.Fx;

namespace LoopstationEditor.Views.Settings.Memory.Fx
{
    /// <summary>
    /// Interaction logic for FxDynamicsView.xaml
    /// </summary>
    public partial class FxDynamicsView : UserControl
    {
        public FxDynamicsView(FxDynamicsViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
