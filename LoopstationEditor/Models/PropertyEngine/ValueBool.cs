using System;

namespace LoopstationEditor.Models.PropertyEngine
{
    public class ValueBool : ValueInt
    {
        public ValueBool() : base() { }
        protected ValueBool(int value) : base(value) { }
        protected ValueBool(bool value) : base(Convert.ToInt32(value)) { }

        public override object ToType(Type conversionType, IFormatProvider provider)
        {
            if (conversionType == typeof(ValueBool))
                return (ValueBool)_value;
            if (conversionType == typeof(bool))
                return (bool)this;

            return base.ToType(conversionType, provider);
        }

        public override string ToString() => ((bool)this).ToString();

        public static explicit operator int(ValueBool value) => value._value;
        public static explicit operator ValueBool(int value) => new ValueBool(value);

        public static explicit operator bool(ValueBool value) => Convert.ToBoolean(value._value);
        public static explicit operator ValueBool(bool value) => new ValueBool(value);
    }
}
