using System.Windows.Controls;

using LoopstationEditor.ViewModels.Settings.Memory.Fx;

namespace LoopstationEditor.Views.Settings.Memory.Fx
{
    /// <summary>
    /// Interaction logic for FxEqView.xaml
    /// </summary>
    public partial class FxEqView : UserControl
    {
        public FxEqView(FxEqViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
