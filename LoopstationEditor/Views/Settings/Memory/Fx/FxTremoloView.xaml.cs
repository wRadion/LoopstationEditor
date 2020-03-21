using System.Windows.Controls;

using LoopstationEditor.ViewModels.Settings.Memory.Fx;

namespace LoopstationEditor.Views.Settings.Memory.Fx
{
    /// <summary>
    /// Interaction logic for FxTremoloView.xaml
    /// </summary>
    public partial class FxTremoloView : UserControl
    {
        public FxTremoloView(FxTremoloViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
