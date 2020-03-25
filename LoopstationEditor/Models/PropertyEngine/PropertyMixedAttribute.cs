using System;
using System.Linq;

namespace LoopstationEditor.Models.PropertyEngine
{
    public class PropertyMixedAttribute : PropertyAttribute
    {
        public PropertyAttribute IntAttribute;
        public PropertyAttribute EnumAttribute;
        public PropertyAttribute BoolAttribute;

        public PropertyMixedAttribute(object defaultValue, int minimumValue, int maximumValue, int minimumIntValue, int maximumIntValue, object minimumEnumValue, object maximumEnumValue, params object[] enumExtendedValues)
            : base(defaultValue, minimumValue, maximumValue)
        {
            int intDefaultValue = minimumIntValue;
            object enumDefaultValue = minimumEnumValue;
            bool mixed;

            if (defaultValue is int intValue)
            {
                intDefaultValue = intValue;
                mixed = false;
            }
            else
            {
                enumDefaultValue = defaultValue;
                mixed = true;
            }

            IntAttribute = new PropertyAttribute(intDefaultValue, minimumIntValue, maximumIntValue);
            EnumAttribute = new PropertyAttribute(enumDefaultValue, Convert.ToInt32(minimumEnumValue), Convert.ToInt32(maximumEnumValue), enumExtendedValues.Select((v) => Convert.ToInt32(v)).ToArray());
            BoolAttribute = new PropertyAttribute(mixed, 0, 1);
        }
    }
}
