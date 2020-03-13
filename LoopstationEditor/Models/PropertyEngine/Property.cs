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

        public Property(PropertyAttribute attr)
        {
            Name = attr.Name;
            MinimumValue = attr.MinimumValue;
            MaximumValue = attr.MaximumValue;
            Value = attr.DefaultValue;
        }
    }
}
