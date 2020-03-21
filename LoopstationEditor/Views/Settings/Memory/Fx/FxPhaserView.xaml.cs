using System.Windows.Controls;

using LoopstationEditor.ViewModels.Settings.Memory.Fx;

namespace LoopstationEditor.Views.Settings.Memory.Fx
{
    /// <summary>
    /// Interaction logic for FxPhaserView.xaml
    /// </summary>
    public partial class FxPhaserView : UserControl
    {
        public FxPhaserView(FxPhaserViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
