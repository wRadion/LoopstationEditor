using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.ViewModels.PropertyEngine
{
    public class PropertyBoolViewModel : PropertyViewModel<ValueBool>
    {
        public bool Value
        {
            get => _set.GetValue<ValueBool>(_name);
            set => _set.SetValue<ValueBool>(_name, value);
        }

        public PropertyBoolViewModel(string name, PropertySet set) : base(name, set) { }
    }
}
