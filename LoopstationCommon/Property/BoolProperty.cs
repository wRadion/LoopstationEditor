namespace Loopstation.Common.Property
{
    public class BoolProperty : PropertyBase<bool>
    {
        public BoolProperty(int value) : this(value == 1) { }
        public BoolProperty(bool value) : base(value) { }

        public override int Convert() => Value ? 1 : 0;

        public static implicit operator int(BoolProperty prop) => prop.Convert();
        public static implicit operator bool(BoolProperty prop) => prop.Value;
        public static implicit operator BoolProperty(int value) => new BoolProperty(value);
        public static implicit operator BoolProperty(bool value) => new BoolProperty(value);
    }
}
