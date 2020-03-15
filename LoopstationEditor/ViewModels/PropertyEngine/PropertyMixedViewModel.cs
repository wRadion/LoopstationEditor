using System;

using LoopstationEditor.Extensions;
using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.ViewModels.PropertyEngine
{
    public class PropertyMixedViewModel<TEnum> : PropertyViewModel where TEnum : Enum
    {
        // Int
        public int IntValue
        {
            get => IsInt ? (int)_set.GetValue<ValueInt>(_name) : MinimumIntValue;
            set
            {
                IsInt = true;
                IsEnum = false;
                _set.SetValue<ValueInt>(_name, value);
            }
        }
        public int MinimumIntValue { get; }
        public int MaximumIntValue { get; }
        public bool IsInt { get; set; }

        // Enum
        public string EnumValue
        {
            get => IsEnum ? EnumUtils.ToString((TEnum)_set.GetValue<ValueEnum<TEnum>>(_name)) : string.Empty;
            set
            {
                IsInt = false;
                IsEnum = true;
                _set.SetValue<ValueEnum<TEnum>>(_name, EnumUtils.FromString<TEnum>(value));
            }
        }
        public string[] EnumOptions { get; }
        public bool IsEnum { get; set; }

        public PropertyMixedViewModel(string name, PropertySet set) : base(name, set)
        {
            PropertyMixed prop = (PropertyMixed)set.GetProperty(name);

            MinimumIntValue = prop.MinimumIntValue;
            MaximumIntValue = prop.MaximumIntValue;

            EnumOptions = EnumUtils.GetOptions<TEnum>();

            if (MinimumIntValue <= prop.Value && prop.Value <= MaximumIntValue)
                IntValue = prop.Value;
            else
                EnumValue = EnumUtils.ToString((TEnum)Enum.ToObject(typeof(TEnum), prop.Value));
        }
    }
}
