using System;

namespace LoopstationEditor.Models.Properties
{
    public class PropertyEnum<TEnum> : Property<TEnum> where TEnum : struct, IComparable, IFormattable, IConvertible

    {
        public PropertyEnum(TEnum def, int min, int max) : base(def, min, max) { }

        protected override void UpdateValue() => _value = (TEnum)Enum.ToObject(typeof(TEnum), _intValue);
    }
}
