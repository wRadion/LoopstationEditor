using System;

using LoopstationEditor.Extensions;
using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.ViewModels.PropertyEngine
{
    public class PropertyEnumViewModel<TEnum> : PropertyViewModel<ValueEnum<TEnum>> where TEnum : Enum
    {
        public string Value
        {
            get => EnumUtils.ToString((TEnum)_set.GetValue<ValueEnum<TEnum>>(_name));
            set => _set.SetValue<ValueEnum<TEnum>>(_name, EnumUtils.FromString<TEnum>(value));
        }

        public string[] Options { get; }

        public PropertyEnumViewModel(string name, PropertySet set)
            : base(name, set)
        {
            Options = EnumUtils.GetOptions<TEnum>();
        }
    }
}
