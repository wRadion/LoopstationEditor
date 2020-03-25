using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.ViewModels.PropertyEngine
{
    public class PropertyBoolViewModel : PropertyViewModel<bool, bool>
    {
        public bool Value
        {
            get => (bool)_set.GetValue<ValueBool>(_name);
            set => _set.SetValue(_name, (ValueBool)value);
        }

        public PropertyBoolViewModel(string name, PropertySet set) : base(name, set, null) { }

        public override void This_PropertyChanged() => OnPropertyChanged(nameof(Value));
    }
}
