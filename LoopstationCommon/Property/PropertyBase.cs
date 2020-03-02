using System;

namespace Loopstation.Common.Property
{
    public class PropertyChangedArgs
    {
        public int Value;
        public PropertyChangedArgs(int value) => Value = value;
    }

    public abstract class PropertyBase<T> : IConvertible<int>
    {
        public event EventHandler<PropertyChangedArgs> PropertyChanged;

        private T _value;
        public virtual T Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged();
            }
        }

        public PropertyBase(int value) => throw new NotImplementedException();
        public PropertyBase(T value) => Value = value;

        protected void OnPropertyChanged() => PropertyChanged.Invoke(this, new PropertyChangedArgs(Convert()));

        public abstract int Convert();

        public static implicit operator int(PropertyBase<T> prop) => prop.Convert();
    }
}
