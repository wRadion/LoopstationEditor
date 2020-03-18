using System;
using System.Linq;

using LoopstationEditor.Converters;
using LoopstationEditor.Converters.Enum;
using LoopstationEditor.Extensions;
using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.ViewModels.PropertyEngine
{
    public class PropertyEnumViewModel<TEnum> : PropertyViewModel<TEnum, string> where TEnum : Enum
    {
        public string Value
        {
            get => _converter.Convert(_set.GetValue<ValueEnum<TEnum>>(_name));
            set => _set.SetValue<ValueEnum<TEnum>>(_name, _converter.ConvertBack(value));
        }

        public string[] Options { get; }

        public PropertyEnumViewModel(string name, PropertySet set) : this(name, set, new EnumDefaultConverter<TEnum>()) { }
        public PropertyEnumViewModel(string name, PropertySet set, IValueConverter<TEnum, string> converter)
            : base(name, set, converter)
        {
            Options = EnumUtils.GetOptions<TEnum>().Select((option) => _converter.Convert(option)).ToArray();
        }
    }
}
