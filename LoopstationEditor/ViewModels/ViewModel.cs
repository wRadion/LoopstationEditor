using PropertyChanged;
using System.ComponentModel;

namespace LoopstationEditor.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public abstract class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };
    }
}
