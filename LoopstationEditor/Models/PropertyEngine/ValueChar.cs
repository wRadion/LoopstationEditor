namespace LoopstationEditor.Models.PropertyEngine
{
    public class ValueChar : ValueInt
    {
        public ValueChar() : base() { }
        protected ValueChar(int value) : base(value) { }

        public static implicit operator int(ValueChar value) => value._value;
        public static implicit operator ValueChar(int value) => new ValueChar(value);

        public static implicit operator char(ValueChar value) => (char)value._value;
        public static implicit operator ValueChar(char value) => new ValueChar(value);
    }
}
