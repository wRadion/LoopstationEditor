using LoopstationEditor.Converters;
using LoopstationEditor.Converters.Int;
using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.ViewModels.PropertyEngine
{
    public class PropertyIntViewModel : PropertyViewModel<int, int>
    {
        public int Value
        {
            get => _converter.Convert((int)_set.GetValue<ValueInt>(_name));
            set => _set.SetValue(_name, (ValueInt)_converter.ConvertBack(value));
        }
        public int MinimumValue { get; }
        public int MaximumValue { get; }

        public PropertyIntViewModel(string name, PropertySet set) : this(name, set, new IntIdentityConverter()) { }
        public PropertyIntViewModel(string name, PropertySet set, IValueConverter<int, int> converter)
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
