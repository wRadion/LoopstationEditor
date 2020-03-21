using System.Windows.Controls;

using LoopstationEditor.ViewModels.Settings.Memory.Fx;

namespace LoopstationEditor.Views.Settings.Memory.Fx
{
    /// <summary>
    /// Interaction logic for FxVocoderView.xaml
    /// </summary>
    public partial class FxVocoderView : UserControl
    {
        public FxVocoderView(FxVocoderViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
