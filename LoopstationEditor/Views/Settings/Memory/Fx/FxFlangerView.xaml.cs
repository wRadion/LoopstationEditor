using System.Windows.Controls;

using LoopstationEditor.ViewModels.Settings.Memory.Fx;

namespace LoopstationEditor.Views.Settings.Memory.Fx
{
    /// <summary>
    /// Interaction logic for FxFlangerView.xaml
    /// </summary>
    public partial class FxFlangerView : UserControl
    {
        public FxFlangerView(FxFlangerViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
