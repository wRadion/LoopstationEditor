using System;

namespace LoopstationEditor.Models.Properties
{
    public enum MixedValueType
    {
        INT,
        ENUM
    }

    public class PropertyMixed<TEnum> : PropertyInt where TEnum : struct, IComparable, IFormattable, IConvertible
    {
        public MixedValueType ValueType { get; private set; }
        public int MinimumIntValue { get; private set; }
        public int MaximumIntValue { get; private set; }

        private TEnum _enumValue;

        public PropertyMixed(int def, int min, int max) : base(def, min, max) { }
        public PropertyMixed(TEnum def, int min, int max) : base(min, min, max) => SetValue(def);

        public PropertyMixed<TEnum> SetIntRange(int min, int max)
        {
            MinimumIntValue = min;
            MaximumIntValue = max;
            return this;
        }

        public new void SetValue(int value)
        {
            if (MinimumIntValue > value || value > MaximumIntValue)
                throw new ArgumentOutOfRangeException($"value must be between { MinimumIntValue } and { MaximumIntValue }.");

            _value = value;
            ValueType = MixedValueType.INT;
            UpdateIntValue();
        }
        public void SetValue(TEnum enumValue)
        {
            _enumValue = enumValue;
            ValueType = MixedValueType.ENUM;
            UpdateIntValue();
        }
        public new object GetValue() => ValueType == MixedValueType.INT ? (object)_value : (object)_enumValue;

        protected override void UpdateIntValue() => _intValue = (ValueType == MixedValueType.INT ? _value : Convert.ToInt32(_enumValue));
        protected override void UpdateValue()
        {
            if (MinimumIntValue <= _intValue && _intValue <= MaximumIntValue)
            {
                _value = _intValue;
                ValueType = MixedValueType.INT;
            }
            else if (Enum.IsDefined(typeof(TEnum), _intValue))
            {
                _enumValue = (TEnum)Enum.ToObject(typeof(TEnum), _intValue);
                ValueType = MixedValueType.ENUM;
            }
            else
                throw new ArgumentOutOfRangeException($"value `{ _intValue }' is not defined in enum { typeof(TEnum).Name }.");
        }
    }
}
