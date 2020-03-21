using System.Windows.Controls;

using LoopstationEditor.ViewModels.Settings.Memory.Fx;

namespace LoopstationEditor.Views.Settings.Memory.Fx
{
    /// <summary>
    /// Interaction logic for FxChorusView.xaml
    /// </summary>
    public partial class FxChorusView : UserControl
    {
        public FxChorusView(FxChorusViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
