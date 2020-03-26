using System;
using System.Linq;

using LoopstationEditor.Converters;
using LoopstationEditor.Converters.Enum;
using LoopstationEditor.Utils;
using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.ViewModels.PropertyEngine
{
    public class EnumRadioOption : ViewModel
    {
        private readonly Func<string> _getValue;
        private readonly Action<string> _setValue;

        public string Option { get; }
        public string GroupName { get; }
        public bool IsChecked
        {
            get => Option == _getValue();
            set
            {
                if (value)
                    _setValue(Option);
            }
        }

        public EnumRadioOption(string option, string groupName, Func<string> getValue, Action<string> setValue)
        {
            Option = option;
            GroupName = groupName;
            _getValue = getValue;
            _setValue = setValue;
        }
    }

    public static class GroupName
    {
        public static int Id { get; set; } = 0;
    }

    public class PropertyEnumRadioViewModel<TEnum> : PropertyViewModel<TEnum, string> where TEnum : Enum
    {
        public string Value
        {
            get => _converter.Convert((TEnum)_set.GetValue<ValueEnum<TEnum>>(_name));
            set => _set.SetValue(_name, (ValueEnum<TEnum>)_converter.ConvertBack(value));
        }
        public EnumRadioOption[] Options { get; private set; }

        public PropertyEnumRadioViewModel(string name, PropertySet set) : this(name, set, new EnumDefaultConverter<TEnum>()) { }
        public PropertyEnumRadioViewModel(string name, PropertySet set, IValueConverter<TEnum, string> converter)
            : base(name, set, converter)
        {
            string[] options = EnumUtils.GetOptions<TEnum>().Select((option) => _converter.Convert(option)).ToArray();
            string groupName = $"EnumRadio{ GroupName.Id++ }";

            Options = new EnumRadioOption[options.Length];
            for (int i = 0; i < Options.Length; ++i)
                Options[i] = new EnumRadioOption(options[i], groupName, () => Value, (value) => Value = value);
        }

        public override void This_PropertyChanged()
        {
            foreach (EnumRadioOption option in Options)
                option.OnPropertyChanged(nameof(option.IsChecked));
        }
    }
}
