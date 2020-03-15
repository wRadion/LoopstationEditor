using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.ViewModels.PropertyEngine
{
    public class PropertyIntViewModel : PropertyViewModel
    {
        public int Value
        {
            get => _set.GetValue<ValueInt>(_name);
            set => _set.SetValue<ValueInt>(_name, value);
        }
        public int MinimumValue { get; }
        public int MaximumValue { get; }

        public PropertyIntViewModel(string name, PropertySet set) : base(name, set)
        {
            Property prop = set.GetProperty(name);

            MinimumValue = prop.MinimumValue;
            MaximumValue = prop.MaximumValue;
        }
    }
}
