using System;

namespace LoopstationEditor.Models.PropertyEngine
{
    public class ValueEnum<TEnum> : ValueInt where TEnum : Enum
    {
        public ValueEnum() : base() { }
        public ValueEnum(int value) : base(value) { }
        public ValueEnum(TEnum value) : base(Convert.ToInt32(value)) { }

        public override object ToType(Type conversionType, IFormatProvider provider)
        {
            if (conversionType == typeof(ValueEnum<TEnum>))
                return (ValueEnum<TEnum>)_value;
            if (conversionType == typeof(TEnum))
                return (TEnum)this;

            return base.ToType(conversionType, provider);
        }

        public override string ToString() => ((TEnum)this).ToString();

        public static implicit operator int(ValueEnum<TEnum> value) => value._value;
        public static implicit operator ValueEnum<TEnum>(int value) => new ValueEnum<TEnum>(value);

        public static explicit operator TEnum(ValueEnum<TEnum> value) => (TEnum)Enum.ToObject(typeof(TEnum), value._value);
        public static explicit operator ValueEnum<TEnum>(TEnum value) => new ValueEnum<TEnum>(value);
    }
}
