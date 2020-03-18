using System;
using System.Linq;
using LoopstationEditor.Converters;
using LoopstationEditor.Converters.Enum;
using LoopstationEditor.Converters.Int;
using LoopstationEditor.Extensions;
using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.ViewModels.PropertyEngine
{
    public class PropertyMixedViewModel<TEnum> : PropertyViewModel<int, int> where TEnum : Enum
    {
        // Int
        public int IntValue
        {
            get => _converter.Convert(IsInt ? (int)_set.GetValue<ValueInt>(_name) : MinimumIntValue);
            set
            {
                IsInt = true;
                IsEnum = false;
                _set.SetValue<ValueInt>(_name, _converter.ConvertBack(value));
            }
        }
        public int MinimumIntValue { get; }
        public int MaximumIntValue { get; }
        public bool IsInt { get; set; }

        // Enum
        private IValueConverter<TEnum, string> _enumConverter;

        public string EnumValue
        {
            get => IsEnum ? _enumConverter.Convert(_set.GetValue<ValueEnum<TEnum>>(_name)) : string.Empty;
            set
            {
                IsInt = false;
                IsEnum = true;
                _set.SetValue<ValueEnum<TEnum>>(_name, _enumConverter.ConvertBack(value));
            }
        }
        public string[] EnumOptions { get; }
        public bool IsEnum { get; set; }

        public PropertyMixedViewModel(string name, PropertySet set) : this(name, set, new IntIdentityConverter(), new EnumDefaultConverter<TEnum>()) { }
        public PropertyMixedViewModel(string name, PropertySet set, IValueConverter<int, int> converter) : this(name, set, converter, new EnumDefaultConverter<TEnum>()) { }
        public PropertyMixedViewModel(string name, PropertySet set, IValueConverter<int, int> converter, IValueConverter<TEnum, string> enumConverter)
            : base(name, set, converter)
        {
            _enumConverter = enumConverter;

            PropertyMixed prop = (PropertyMixed)set.GetProperty(name);

            MinimumIntValue = _converter.Convert(prop.MinimumIntValue);
            MaximumIntValue = _converter.Convert(prop.MaximumIntValue);

            EnumOptions = EnumUtils.GetOptions<TEnum>().Select((option) => _enumConverter.Convert(option)).ToArray();

            int value = _converter.Convert(prop.Value);

            if (MinimumIntValue <= value && value <= MaximumIntValue)
                IntValue = prop.Value;
            else
                EnumValue = _enumConverter.Convert((TEnum)Enum.ToObject(typeof(TEnum), prop.Value));
        }
    }
}
