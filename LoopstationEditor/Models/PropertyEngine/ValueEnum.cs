using System;

namespace LoopstationEditor.Models.PropertyEngine
{
    public class ValueEnum<TEnum> : ValueInt where TEnum : Enum
    {
        public ValueEnum() : base() { }
        protected ValueEnum(int value) : base(value) { }
        public ValueEnum(TEnum value) : base(Convert.ToInt32(value)) { }

        public static implicit operator int(ValueEnum<TEnum> value) => value._value;
        public static implicit operator ValueEnum<TEnum>(int value) => new ValueEnum<TEnum>(value);

        public static implicit operator TEnum(ValueEnum<TEnum> value) => (TEnum)Enum.ToObject(typeof(TEnum), value._value);
        public static implicit operator ValueEnum<TEnum>(TEnum value) => new ValueEnum<TEnum>(value);
    }
}
