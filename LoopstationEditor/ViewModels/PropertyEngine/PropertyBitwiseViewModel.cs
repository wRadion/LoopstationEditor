using System;
using System.Linq;

using LoopstationEditor.Converters;
using LoopstationEditor.Converters.Enum;
using LoopstationEditor.Extensions;
using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.ViewModels.PropertyEngine
{
    public class BitwiseOption
    {
        private Action _updateValue;

        public string Option { get; }

        private bool _isChecked;
        public bool IsChecked
        {
            get => _isChecked;
            set
            {
                _isChecked = value;
                _updateValue();
            }
        }

        public BitwiseOption(string option, bool isChecked, Action updateValue)
        {
            _updateValue = updateValue;
            Option = option;
            _isChecked = isChecked;
        }
    }

    public class PropertyBitwiseViewModel<TEnum> : PropertyViewModel<TEnum, string> where TEnum : Enum
    {
        private int Value
        {
            get => _set.GetValue<ValueEnum<TEnum>>(_name);
            set => _set.SetValue<ValueEnum<TEnum>>(_name, value);
        }

        public BitwiseOption[] Options { get; }

        public PropertyBitwiseViewModel(string name, PropertySet set) : this(name, set, new EnumDefaultConverter<TEnum>()) { }
        public PropertyBitwiseViewModel(string name, PropertySet set, IValueConverter<TEnum, string> converter)
            : base(name, set, converter)
        {
            string[] options = EnumUtils.GetBitwiseOptions<TEnum>().Select((option) => _converter.Convert(option)).ToArray();
            int bitwiseValue = Value;

            Options = new BitwiseOption[options.Length];

            for (int i = 0; i < Options.Length; ++i)
            {
                int power2 = (int)Math.Pow(2, i);
                Options[i] = new BitwiseOption(options[i], (bitwiseValue & power2) == power2, UpdateValue);
            }
        }

        private void UpdateValue()
        {
            int bitwiseValue = 0;

            for (int i = 0; i < Options.Length; ++i)
            {
                if (!Options[i].IsChecked) continue;
                bitwiseValue += (int)Math.Pow(2, i);
            }

            Value = bitwiseValue;
        }
    }
}
