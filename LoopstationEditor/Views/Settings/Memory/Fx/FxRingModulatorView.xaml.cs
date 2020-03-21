using LoopstationEditor.ViewModels.Settings.Memory.Fx;
using System.Windows.Controls;

namespace LoopstationEditor.Views.Settings.Memory.Fx
{
    /// <summary>
    /// Interaction logic for FxRingModulatorView.xaml
    /// </summary>
    public partial class FxRingModulatorView : UserControl
    {
        public FxRingModulatorView(FxRingModulatorViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
