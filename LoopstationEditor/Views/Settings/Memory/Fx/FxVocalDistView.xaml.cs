using System.Windows.Controls;

using LoopstationEditor.ViewModels.Settings.Memory.Fx;

namespace LoopstationEditor.Views.Settings.Memory.Fx
{
    /// <summary>
    /// Interaction logic for FxVocalDistView.xaml
    /// </summary>
    public partial class FxVocalDistView : UserControl
    {
        public FxVocalDistView(FxVocalDistViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
