using System.Windows.Controls;

using LoopstationEditor.ViewModels.Settings.Memory.Fx;

namespace LoopstationEditor.Views.Settings.Memory.Fx
{
    /// <summary>
    /// Interaction logic for FxGuitarToBassView.xaml
    /// </summary>
    public partial class FxGuitarToBassView : UserControl
    {
        public FxGuitarToBassView(FxGuitarToBassViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
