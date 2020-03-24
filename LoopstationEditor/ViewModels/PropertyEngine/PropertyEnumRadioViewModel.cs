using System;
using System.Linq;

using LoopstationEditor.Converters;
using LoopstationEditor.Converters.Enum;
using LoopstationEditor.Extensions;
using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.ViewModels.PropertyEngine
{
    public class RadioOption : ViewModel
    {
        private readonly Action _updateValue;

        public string Value { get; }

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

        public string GroupName { get; }

        public RadioOption(string value, bool isChecked, string groupName, Action updateValue)
        {
            _updateValue = updateValue;
            Value = value;
            _isChecked = isChecked;
            GroupName = groupName;
        }

        public void UpdateIsChecked(bool value)
        {
            _isChecked = value;
            OnPropertyChanged(nameof(IsChecked));
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
            get => _converter.Convert(_set.GetValue<ValueEnum<TEnum>>(_name));
            set => _set.SetValue<ValueEnum<TEnum>>(_name, _converter.ConvertBack(value));
        }

        public RadioOption[] Options { get; private set; }

        public PropertyEnumRadioViewModel(string name, PropertySet set) : this(name, set, new EnumDefaultConverter<TEnum>()) { }
        public PropertyEnumRadioViewModel(string name, PropertySet set, IValueConverter<TEnum, string> converter)
            : base(name, set, converter)
        {
            string[] optionStr = EnumUtils.GetOptions<TEnum>().Select((option) => _converter.Convert(option)).ToArray();
            string enumValue = Value;

            string groupName = $"EnumRadio{ GroupName.Id++ }";
            Options = new RadioOption[optionStr.Length];

            for (int i = 0; i < Options.Length; ++i)
                Options[i] = new RadioOption(optionStr[i], optionStr[i] == enumValue, groupName, UpdateValue);
        }

        private void UpdateValue()
        {
            foreach (RadioOption option in Options)
            {
                if (option.IsChecked)
                {
                    Value = option.Value;
                    break;
                }
            }
        }

        protected override void This_PropertyChanged()
        {
            string enumValue = Value;

            for (int i = 0; i < Options.Length; ++i)
                Options[i].UpdateIsChecked(Options[i].Value == enumValue);

            OnPropertyChanged(nameof(Options));
        }
    }
}
