using System.Windows.Controls;

using LoopstationEditor.ViewModels.Settings.Memory.Fx;

namespace LoopstationEditor.Views.Settings.Memory.Fx
{
    /// <summary>
    /// Interaction logic for FxBeatScatterView.xaml
    /// </summary>
    public partial class FxBeatScatterView : UserControl
    {
        public FxBeatScatterView(FxBeatScatterViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
