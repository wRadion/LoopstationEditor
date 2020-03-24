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
            get => IsInt ? _converter.Convert(_set.GetValue<ValueInt>(_name)) : MinimumIntValue;
            set => SetIntValue(_converter.ConvertBack(value));
        }
        public int MinimumIntValue { get; }
        public int MaximumIntValue { get; }

        private bool _isInt;
        public bool IsInt
        {
            get => _isInt;
            set
            {
                if (value)
                    SetIntValue(_converter.ConvertBack(MinimumIntValue));
                _isInt = value;
            }
        }

        // Enum
        private readonly IValueConverter<TEnum, string> _enumConverter;

        public string EnumValue
        {
            get => IsEnum ? _enumConverter.Convert(_set.GetValue<ValueEnum<TEnum>>(_name)) : EnumOptions[0];
            set => SetEnumValue(_enumConverter.ConvertBack(value));
        }
        public string[] EnumOptions { get; }

        private bool _isEnum;
        public bool IsEnum
        {
            get => _isEnum;
            set
            {
                if (value)
                    SetEnumValue(_enumConverter.ConvertBack(EnumOptions[0]));
                _isEnum = value;
            }
        }

        public PropertyMixedViewModel(string name, PropertySet set) : this(name, set, new IntIdentityConverter(), new EnumDefaultConverter<TEnum>()) { }
        public PropertyMixedViewModel(string name, PropertySet set, IValueConverter<int, int> intConverter) : this(name, set, intConverter, new EnumDefaultConverter<TEnum>()) { }
        public PropertyMixedViewModel(string name, PropertySet set, IValueConverter<TEnum, string> enumConverter) : this(name, set, new IntIdentityConverter(), enumConverter) { }
        public PropertyMixedViewModel(string name, PropertySet set, IValueConverter<int, int> intConverter, IValueConverter<TEnum, string> enumConverter)
            : base(name, set, intConverter)
        {
            _enumConverter = enumConverter;

            PropertyMixed prop = (PropertyMixed)set.GetProperty(name);

            MinimumIntValue = _converter.Convert(prop.MinimumIntValue);
            MaximumIntValue = _converter.Convert(prop.MaximumIntValue);

            EnumOptions = EnumUtils.GetOptions<TEnum>().Select((option) => _enumConverter.Convert(option)).ToArray();

            int value = prop.Value;

            if (_converter.ConvertBack(MinimumIntValue) <= value && value <= _converter.ConvertBack(MaximumIntValue))
                SetIntValue(value);
            else
                SetEnumValue((TEnum)Enum.ToObject(typeof(TEnum), value));
        }

        private void SetIntValue(int rawValue)
        {
            IsInt = true;
            IsEnum = false;
            _set.SetValue<ValueInt>(_name, rawValue);
            //OnPropertyChanged(nameof(IntValue));
        }

        private void SetEnumValue(TEnum rawValue)
        {
            IsInt = false;
            IsEnum = true;
            _set.SetValue<ValueEnum<TEnum>>(_name, rawValue);
            //OnPropertyChanged(nameof(EnumValue));
        }

        protected override void This_PropertyChanged()
        {
            //OnPropertyChanged(nameof(IntValue));
            //OnPropertyChanged(nameof(EnumValue));
        }
    }
}
