using System.Windows.Controls;

using LoopstationEditor.ViewModels.Settings.Memory.Fx;

namespace LoopstationEditor.Views.Settings.Memory.Fx
{
    /// <summary>
    /// Interaction logic for FxIsolatorView.xaml
    /// </summary>
    public partial class FxIsolatorView : UserControl
    {
        public FxIsolatorView(FxIsolatorViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
