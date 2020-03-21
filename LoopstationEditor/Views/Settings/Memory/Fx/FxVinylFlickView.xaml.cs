using System.Windows.Controls;

using LoopstationEditor.ViewModels.Settings.Memory.Fx;

namespace LoopstationEditor.Views.Settings.Memory.Fx
{
    /// <summary>
    /// Interaction logic for FxVinylFlickView.xaml
    /// </summary>
    public partial class FxVinylFlickView : UserControl
    {
        public FxVinylFlickView(FxVinylFlickViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
