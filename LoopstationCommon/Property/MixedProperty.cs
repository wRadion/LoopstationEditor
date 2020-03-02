using System;

namespace Loopstation.Common.Property
{
    public enum MixedPropertyValueType { INT, ENUM }

    public class MixedProperty<T> : IConvertible<int> where T : Enum
    {
        public event EventHandler<PropertyChangedArgs> PropertyChanged;

        public object Value
        {
            get => ValueType == MixedPropertyValueType.INT ? _intValue : (object)_enumValue;
            set
            {
                if (value.GetType() == typeof(int))
                    SetValue((int)value);
                else if (value.GetType() == typeof(T))
                    SetValue((T)value);
                else
                    throw new InvalidValueException(value, typeof(int), typeof(T));
            }
        }

        public MixedPropertyValueType ValueType { get; private set; }

        private int _intValue;
        private T _enumValue;

        // TODO: Handle when value is outside of int value range
        public MixedProperty(int value) => SetValue(value);
        public MixedProperty(T value) => SetValue(value);

        protected void OnPropertyChanged() => PropertyChanged.Invoke(this, new PropertyChangedArgs(Convert()));

        public void SetValue(int value)
        {
            _intValue = value;
            ValueType = MixedPropertyValueType.INT;
            OnPropertyChanged();
        }
        public void SetValue(T value)
        {
            _enumValue = value;
            ValueType = MixedPropertyValueType.ENUM;
            OnPropertyChanged();
        }

        public int Convert() => ValueType == MixedPropertyValueType.INT ? _intValue : System.Convert.ToInt32(_enumValue);

        public static implicit operator int(MixedProperty<T> prop)
        {
            if (prop.ValueType == MixedPropertyValueType.INT)
                return (int)prop.Value;
            throw new InvalidMixedPropertyValueTypeException(prop.ValueType, typeof(int));
        }
        public static implicit operator T(MixedProperty<T> prop)
        {
            if (prop.ValueType == MixedPropertyValueType.ENUM)
                return (T)prop.Value;
            throw new InvalidMixedPropertyValueTypeException(prop.ValueType, typeof(int));
        }
        public static implicit operator MixedProperty<T>(int value) => new MixedProperty<T>(value);
        public static implicit operator MixedProperty<T>(T value) => new MixedProperty<T>(value);
    }
}
