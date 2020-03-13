using System;

namespace LoopstationEditor.Models.Properties
{
    public abstract class Property<T> where T : struct
    {
        protected T _value;
        protected int _intValue;

        public T DefaultValue { get; }
        public int MinimumValue { get; }
        public int MaximumValue { get; }

        public Property(T defaultValue, int minimumValue, int maximumValue)
        {
            DefaultValue = defaultValue;
            MinimumValue = minimumValue;
            MaximumValue = maximumValue;

            SetValue(DefaultValue);
        }

        public int GetIntValue() => _intValue;
        public void SetIntValue(int intValue)
        {
            if (MinimumValue > intValue || intValue > MaximumValue)
                throw new ArgumentOutOfRangeException($"value must be between { MinimumValue } and { MaximumValue }.");

            _intValue = intValue;
            UpdateValue();
        }

        public T GetValue() => _value;
        public void SetValue(T value)
        {
            _value = value;
            UpdateIntValue();
        }

        protected virtual void UpdateIntValue() => _intValue = Convert.ToInt32(_value);
        protected abstract void UpdateValue();
    }
}
