using System.Windows.Controls;

using LoopstationEditor.ViewModels.Settings.Memory.Fx;

namespace LoopstationEditor.Views.Settings.Memory.Fx
{
    /// <summary>
    /// Interaction logic for FxTapeEchoView.xaml
    /// </summary>
    public partial class FxTapeEchoView : UserControl
    {
        public FxTapeEchoView(FxTapeEchoViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
