using System;

namespace Loopstation.Common.Property
{
    public class EnumProperty<T> : PropertyBase<T> where T : Enum
    {
        public EnumProperty(int value) : this((T)Enum.ToObject(typeof(T), value)) { }
        public EnumProperty(T value) : base(value) { }

        public override int Convert() => System.Convert.ToInt32(Value);

        public static implicit operator int(EnumProperty<T> prop) => prop.Convert();
        public static implicit operator T(EnumProperty<T> prop) => prop.Value;
        public static implicit operator EnumProperty<T>(int value) => new EnumProperty<T>(value);
        public static implicit operator EnumProperty<T>(T value) => new EnumProperty<T>(value);
    }
}
