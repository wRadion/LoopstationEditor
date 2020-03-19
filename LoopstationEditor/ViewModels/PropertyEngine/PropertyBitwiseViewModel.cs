using System;
using System.Linq;

using LoopstationEditor.Converters;
using LoopstationEditor.Converters.Enum;
using LoopstationEditor.Extensions;
using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.ViewModels.PropertyEngine
{
    public class BitwiseOptions
    {
        private Action _updateValue;

        public string Option { get; }

        private bool _enabled;
        public bool Enabled
        {
            get => _enabled;
            set
            {
                _enabled = value;
                _updateValue();
            }
        }

        public BitwiseOptions(string option, bool enabled, Action updateValue)
        {
            _updateValue = updateValue;
            Option = option;
            _enabled = enabled;
        }
    }

    public class PropertyBitwiseViewModel<TEnum> : PropertyViewModel<TEnum, string> where TEnum : Enum
    {
        public BitwiseOptions[] Options { get; }

        public PropertyBitwiseViewModel(string name, PropertySet set) : this(name, set, new EnumDefaultConverter<TEnum>()) { }
        public PropertyBitwiseViewModel(string name, PropertySet set, IValueConverter<TEnum, string> converter)
            : base(name, set, converter)
        {
            string[] options = EnumUtils.GetBitwiseOptions<TEnum>().Select((option) => _converter.Convert(option)).ToArray();
            int bitwiseValue = _set.GetValue<ValueEnum<TEnum>>(_name);

            Options = new BitwiseOptions[options.Length];

            for (int i = 0; i < Options.Length; ++i)
            {
                int power2 = (int)Math.Pow(2, i);
                Options[i] = new BitwiseOptions(options[i], (bitwiseValue & power2) == power2, UpdateValue);
            }
        }

        public void UpdateValue()
        {
            int bitwiseValue = 0;

            for (int i = 0; i < Options.Length; ++i)
            {
                if (!Options[i].Enabled) continue;
                bitwiseValue += (int)Math.Pow(2, i);
            }

            _set.SetValue<ValueEnum<TEnum>>(_name, bitwiseValue);
        }
    }
}
