namespace LoopstationEditor.Models.PropertyEngine
{
    public class ValueInt
    {
        protected int _value;

        public ValueInt() { }
        protected ValueInt(int value) => _value = value;

        public static implicit operator int(ValueInt value) => value._value;
        public static implicit operator ValueInt(int value) => new ValueInt(value);
    }
}
