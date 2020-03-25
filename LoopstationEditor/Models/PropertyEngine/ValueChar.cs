using System;

namespace LoopstationEditor.Models.PropertyEngine
{
    public class ValueChar : ValueInt
    {
        public ValueChar() : base() { }
        protected ValueChar(int value) : base(value) { }

        public override object ToType(Type conversionType, IFormatProvider provider)
        {
            if (conversionType == typeof(ValueChar))
                return (ValueChar)_value;
            if (conversionType == typeof(char))
                return (char)this;

            return base.ToType(conversionType, provider);
        }

        public override string ToString() => ((char)this).ToString();

        public static explicit operator int(ValueChar value) => value._value;
        public static explicit operator ValueChar(int value) => new ValueChar(value);

        public static explicit operator char(ValueChar value) => (char)value._value;
        public static explicit operator ValueChar(char value) => new ValueChar(value);
    }
}
