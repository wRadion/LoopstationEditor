using System.Windows.Controls;

using LoopstationEditor.ViewModels.Settings.Memory.Fx;

namespace LoopstationEditor.Views.Settings.Memory.Fx
{
    /// <summary>
    /// Interaction logic for FxReverbView.xaml
    /// </summary>
    public partial class FxReverbView : UserControl
    {
        public FxReverbView(FxReverbViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
