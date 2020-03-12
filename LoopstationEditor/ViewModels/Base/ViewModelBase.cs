using PropertyChanged;
using System.ComponentModel;

namespace LoopstationEditor.ViewModels.Base
{
    [AddINotifyPropertyChangedInterface]
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };
    }
}
