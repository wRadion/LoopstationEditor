using System.Windows.Controls;

using LoopstationEditor.ViewModels.Settings.Memory.Fx;

namespace LoopstationEditor.Views.Settings.Memory.Fx
{
    /// <summary>
    /// Interaction logic for FxSynthView.xaml
    /// </summary>
    public partial class FxSynthView : UserControl
    {
        public FxSynthView(FxSynthViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
