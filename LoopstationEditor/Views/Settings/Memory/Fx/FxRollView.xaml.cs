using System.Windows.Controls;

using LoopstationEditor.ViewModels.Settings.Memory.Fx;

namespace LoopstationEditor.Views.Settings.Memory.Fx
{
    /// <summary>
    /// Interaction logic for FxRollView.xaml
    /// </summary>
    public partial class FxRollView : UserControl
    {
        public FxRollView(FxRollViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
