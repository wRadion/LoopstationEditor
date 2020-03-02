namespace Loopstation.Common.Property
{
    public class IntProperty : PropertyBase<int>
    {
        public IntProperty(int value) : base(value) { }

        public override int Convert() => Value;

        public static implicit operator int(IntProperty prop) => prop.Value;
        public static implicit operator IntProperty(int value) => new IntProperty(value);
    }
}
