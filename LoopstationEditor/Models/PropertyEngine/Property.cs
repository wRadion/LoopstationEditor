using System;

namespace LoopstationEditor.Models.PropertyEngine
{
    public class Property
    {
        private ValueInt _value;

        public string Name { get; }
        public int MinimumValue { get; }
        public int MaximumValue { get; }
        public ValueInt Value
        {
            get => _value;
            set
            {
                if (MinimumValue > value || value > MaximumValue)
                    throw new ArgumentOutOfRangeException($"Value must be between { MinimumValue } and { MaximumValue }.");

                _value = value;
            }
        }

        public Property(string name, PropertyAttribute attr)
            : this(name, attr.MinimumValue, attr.MaximumValue, attr.DefaultValue) { }
        protected Property(string name, int minimumValue, int maximumValue, ValueInt value)
        {
            Name = name;
            MinimumValue = minimumValue;
            MaximumValue = maximumValue;

            if (MinimumValue > MaximumValue)
                throw new ArgumentException("Maximum value must be greater than Minimum value.");

            if (value is ValueInt intValue)
                Value = intValue;
            else if (value is ValueBool boolValue)
                Value = boolValue;
            else if (value is ValueChar charValue)
                Value = charValue;
            else
            {
                Type type = typeof(ValueEnum<>).MakeGenericType(value.GetType());
                Value = (ValueInt)Activator.CreateInstance(type, value);
            }
        }

        public Property Clone() => new Property(Name, MinimumValue, MaximumValue, Value);
    }
}
