using System.Windows.Controls;

using LoopstationEditor.ViewModels.Settings.Memory.Fx;

namespace LoopstationEditor.Views.Settings.Memory.Fx
{
    /// <summary>
    /// Interaction logic for FxTransposeView.xaml
    /// </summary>
    public partial class FxTransposeView : UserControl
    {
        public FxTransposeView(FxTransposeViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
