using System.Windows.Controls;

using LoopstationEditor.ViewModels.Settings.Memory.Fx;

namespace LoopstationEditor.Views.Settings.Memory.Fx
{
    /// <summary>
    /// Interaction logic for FxFilterView.xaml
    /// </summary>
    public partial class FxFilterView : UserControl
    {
        public FxFilterView(FxFilterViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
