using System;

namespace LoopstationEditor.Models.PropertyEngine
{
    public class ValueInt : IConvertible
    {
        protected int _value;

        public ValueInt() { }
        protected ValueInt(int value) => _value = value;

        #region IConvertible OSEF
        public TypeCode GetTypeCode() => throw new NotImplementedException();
        public byte ToByte(IFormatProvider provider) => throw new NotImplementedException();
        public DateTime ToDateTime(IFormatProvider provider) => throw new NotImplementedException();
        public decimal ToDecimal(IFormatProvider provider) => throw new NotImplementedException();
        public double ToDouble(IFormatProvider provider) => throw new NotImplementedException();
        public short ToInt16(IFormatProvider provider) => throw new NotImplementedException();
        public long ToInt64(IFormatProvider provider) => throw new NotImplementedException();
        public sbyte ToSByte(IFormatProvider provider) => throw new NotImplementedException();
        public ushort ToUInt16(IFormatProvider provider) => throw new NotImplementedException();
        public uint ToUInt32(IFormatProvider provider) => throw new NotImplementedException();
        public ulong ToUInt64(IFormatProvider provider) => throw new NotImplementedException();
        #endregion IConvertible OSEF

        public bool ToBoolean(IFormatProvider provider) => _value == 1;
        public char ToChar(IFormatProvider provider) => (char)_value;
        public int ToInt32(IFormatProvider provider) => _value;
        public float ToSingle(IFormatProvider provider) => _value;
        public string ToString(IFormatProvider provider) => ToString();

        public virtual object ToType(Type conversionType, IFormatProvider provider)
        {
            if (conversionType == typeof(ValueInt))
                return (ValueInt)_value;
            if (conversionType == typeof(ValueBool))
                return (ValueBool)_value;
            if (conversionType == typeof(ValueChar))
                return (ValueChar)_value;
            if (conversionType.IsGenericType && conversionType.GetGenericTypeDefinition() == typeof(ValueEnum<>))
            {
                Type type = typeof(ValueEnum<>).MakeGenericType(conversionType.GetGenericArguments()[0]);
                return Activator.CreateInstance(type, _value);
            }
            if (conversionType == typeof(int))
                return (int)this;

            return null;
        }

        public override string ToString() => _value.ToString();

        public static implicit operator int(ValueInt value) => value._value;
        public static implicit operator ValueInt(int value) => new ValueInt(value);
    }
}
