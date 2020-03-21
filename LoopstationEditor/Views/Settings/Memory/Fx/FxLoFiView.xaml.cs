using System.Windows.Controls;

using LoopstationEditor.ViewModels.Settings.Memory.Fx;

namespace LoopstationEditor.Views.Settings.Memory.Fx
{
    /// <summary>
    /// Interaction logic for FxLoFiView.xaml
    /// </summary>
    public partial class FxLoFiView : UserControl
    {
        public FxLoFiView(FxLoFiViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
