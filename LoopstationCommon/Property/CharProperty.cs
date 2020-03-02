namespace Loopstation.Common.Property
{
    public class CharProperty : PropertyBase<char>
    {
        public CharProperty(int value) : base(value) { }
        public CharProperty(char value) : base(value) { }

        public override int Convert() => Value;

        public static implicit operator int(CharProperty prop) => prop.Value;
        public static implicit operator char(CharProperty prop) => prop.Value;
        public static implicit operator CharProperty(int value) => new CharProperty(value);
        public static implicit operator CharProperty(char value) => new CharProperty(value);
    }
}
