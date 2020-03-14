using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.ViewModels.PropertyEngine
{
    public class PropertyViewModel<T> where T : ValueInt
    {
        private string _name;
        private PropertySet _set;

        public int MinimumValue { get; private set; }
        public int MaximumValue { get; private set; }

        public PropertyViewModel(string name, PropertySet set)
        {
            _name = name;
            _set = set;

            Property prop = _set.GetProperty(_name);

            MinimumValue = prop.MinimumValue;
            MaximumValue = prop.MaximumValue;
        }

        public T GetValue() => _set.GetValue<T>(_name);
        public void SetValue(T value) => _set.SetValue<T>(_name, value);
    }
}
