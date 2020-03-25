using System;

namespace LoopstationEditor.Models.PropertyEngine
{
    public class PropertyAttribute : Attribute
    {
        public ValueInt DefaultValue { get; }
        public IRange Range { get; }

        public PropertyAttribute(object defaultValue, int minimumValue, int maximumValue, params int[] extendedValues)
        {
            if (extendedValues != null && extendedValues.Length > 0)
                Range = new ExtendedRange(minimumValue, maximumValue, extendedValues);
            else
                Range = new Range(minimumValue, maximumValue);

            if (defaultValue is int intValue)
                DefaultValue = (ValueInt)intValue;
            else if (defaultValue is bool boolValue)
                DefaultValue = (ValueBool)boolValue;
            else if (defaultValue is char charValue)
                DefaultValue = (ValueChar)charValue;
            else
            {
                Type type = typeof(ValueEnum<>).MakeGenericType(defaultValue.GetType());
                DefaultValue = (ValueInt)Activator.CreateInstance(type, defaultValue);
            }
        }
    }
}
