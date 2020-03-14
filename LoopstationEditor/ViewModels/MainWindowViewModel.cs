namespace LoopstationEditor.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {
        public LoopstationViewModel LoopstationViewModel { get; }

        public MainWindowViewModel()
        {
            LoopstationViewModel = new LoopstationViewModel();
        }
    }
}
