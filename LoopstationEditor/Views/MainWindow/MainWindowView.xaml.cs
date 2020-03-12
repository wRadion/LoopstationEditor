using LoopstationEditor.ViewModels;

namespace LoopstationEditor.Views.MainWindow
{
    /// <summary>
    /// Interaction logic for MainWindowView.xaml
    /// </summary>
    public partial class MainWindowView : XenionDark.Windows.Window
    {
        public MainWindowView()
        {
            InitializeComponent();

            this.DataContext = new MainWindowViewModel();
        }
    }
}
