using System;

namespace LoopstationEditor.Models.PropertyEngine
{
    public class ValueBool : ValueInt
    {
        public ValueBool() : base() { }
        protected ValueBool(int value) : base(value) { }
        protected ValueBool(bool value) : base(Convert.ToInt32(value)) { }

        public static implicit operator bool(ValueBool value) => Convert.ToBoolean(value._value);
        public static implicit operator ValueBool(bool value) => new ValueBool(value);
    }
}
