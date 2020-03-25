using System;

namespace LoopstationEditor.Models.PropertyEngine
{
    public class Property
    {
        private ValueInt _value;

        public string Name { get; }
        public IRange Range { get; }
        public ValueInt Value
        {
            get => _value;
            set => _value = Range.ContainsGuard(value);
        }

        public Property(string name, PropertyAttribute attr)
            : this(name, attr.DefaultValue, attr.Range) { }
        public Property(string name, ValueInt value, IRange range)
        {
            Name = name;
            Range = range;

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

        public Property Clone() => new Property(Name, Value, Range);
    }
}
