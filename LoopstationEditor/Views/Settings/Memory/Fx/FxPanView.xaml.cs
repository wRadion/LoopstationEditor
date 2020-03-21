using System.Windows.Controls;

using LoopstationEditor.ViewModels.Settings.Memory.Fx;

namespace LoopstationEditor.Views.Settings.Memory.Fx
{
    /// <summary>
    /// Interaction logic for FxPanView.xaml
    /// </summary>
    public partial class FxPanView : UserControl
    {
        public FxPanView(FxPanViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
