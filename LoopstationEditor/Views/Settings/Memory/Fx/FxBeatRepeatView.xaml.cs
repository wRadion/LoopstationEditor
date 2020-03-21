using System.Windows.Controls;

using LoopstationEditor.ViewModels.Settings.Memory.Fx;

namespace LoopstationEditor.Views.Settings.Memory.Fx
{
    /// <summary>
    /// Interaction logic for FxBeatRepeatView.xaml
    /// </summary>
    public partial class FxBeatRepeatView : UserControl
    {
        public FxBeatRepeatView(FxBeatRepeatViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
