using System.Windows.Controls;

using LoopstationEditor.ViewModels.Settings.Memory.Fx;

namespace LoopstationEditor.Views.Settings.Memory.Fx
{
    /// <summary>
    /// Interaction logic for FxOctaveView.xaml
    /// </summary>
    public partial class FxOctaveView : UserControl
    {
        public FxOctaveView(FxOctaveViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
