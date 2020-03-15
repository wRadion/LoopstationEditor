namespace LoopstationEditor.Models.PropertyEngine
{
    public class PropertyMixedAttribute : PropertyAttribute
    {
        public int MinimumIntValue { get; }
        public int MaximumIntValue { get; }

        public PropertyMixedAttribute(object defaultValue, int minimumValue, int maximumValue, int minimumIntValue, int maximumIntValue)
            : base(defaultValue, minimumValue, maximumValue)
        {
            MinimumIntValue = minimumIntValue;
            MaximumIntValue = maximumIntValue;
        }
    }
}
