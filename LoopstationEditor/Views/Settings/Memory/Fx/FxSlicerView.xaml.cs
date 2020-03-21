using System.Windows.Controls;

using LoopstationEditor.ViewModels.Settings.Memory.Fx;

namespace LoopstationEditor.Views.Settings.Memory.Fx
{
    /// <summary>
    /// Interaction logic for FxSlicerView.xaml
    /// </summary>
    public partial class FxSlicerView : UserControl
    {
        public FxSlicerView(FxSlicerViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
