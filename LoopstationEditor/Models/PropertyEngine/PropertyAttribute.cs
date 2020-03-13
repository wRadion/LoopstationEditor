using System;

namespace LoopstationEditor.Models.PropertyEngine
{
    public class PropertyAttribute : Attribute
    {
        public string Name { get; }
        public ValueInt DefaultValue { get; }
        public int MinimumValue { get; }
        public int MaximumValue { get; }

        public PropertyAttribute(string name, object defaultValue, int minimumValue, int maximumValue)
        {
            Name = name;
            MinimumValue = minimumValue;
            MaximumValue = maximumValue;

            if (defaultValue is int intValue)
                DefaultValue = intValue;
            else if (defaultValue is bool boolValue)
                DefaultValue = (ValueBool)boolValue;
            else if (defaultValue is Enum enumValue)
            {
                Type type = typeof(ValueEnum<>).MakeGenericType(enumValue.GetType());
                DefaultValue = (ValueInt)Activator.CreateInstance(type, enumValue);
            }
        }
    }
}
