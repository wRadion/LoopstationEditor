using PropertyChanged;
using System.ComponentModel;

namespace LoopstationEditor.ViewModels.Base
{
    [AddINotifyPropertyChangedInterface]
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };
    }
}
