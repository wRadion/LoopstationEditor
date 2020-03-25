using LoopstationEditor.Converters;
using LoopstationEditor.Converters.Float;
using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.ViewModels.PropertyEngine
{
    public class PropertyFloatViewModel : PropertyViewModel<int, float>
    {
        public float Value
        {
            get => _converter.Convert((int)_set.GetValue<ValueInt>(_name));
            set => _set.SetValue(_name, (ValueInt)_converter.ConvertBack(value));
        }
        public float MinimumValue { get; }
        public float MaximumValue { get; }

        public PropertyFloatViewModel(string name, PropertySet set) : this(name, set, new FloatIdentityConverter()) { }
        public PropertyFloatViewModel(string name, PropertySet set, IValueConverter<int, float> converter)
            : base(name, set, converter)
        {
            Property prop = set.GetProperty(name);

            MinimumValue = _converter.Convert(prop.Range.Minimum);
            MaximumValue = _converter.Convert(prop.Range.Maximum);
        }

        public override void This_PropertyChanged() => OnPropertyChanged(nameof(Value));

        public override string ToString() => Value.ToString();
    }
}
