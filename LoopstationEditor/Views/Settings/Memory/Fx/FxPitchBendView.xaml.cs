using System.Windows.Controls;

using LoopstationEditor.ViewModels.Settings.Memory.Fx;

namespace LoopstationEditor.Views.Settings.Memory.Fx
{
    /// <summary>
    /// Interaction logic for FxPitchBendView.xaml
    /// </summary>
    public partial class FxPitchBendView : UserControl
    {
        public FxPitchBendView(FxPitchBendViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
