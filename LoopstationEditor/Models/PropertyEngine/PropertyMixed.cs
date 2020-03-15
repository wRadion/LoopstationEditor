namespace LoopstationEditor.Models.PropertyEngine
{
    public class PropertyMixed : Property
    {
        public int MinimumIntValue { get; }
        public int MaximumIntValue { get; }

        public PropertyMixed(string name, PropertyMixedAttribute attr)
            : this(name, attr.MinimumValue, attr.MaximumValue, attr.DefaultValue, attr.MinimumIntValue, attr.MaximumIntValue) { }
        protected PropertyMixed(string name, int minimumValue, int maximumValue, ValueInt value, int minimumIntValue, int maximumIntValue)
            : base(name, minimumValue, maximumValue, value)
        {
            MinimumIntValue = minimumIntValue;
            MaximumIntValue = maximumIntValue;
        }

        public new PropertyMixed Clone() => new PropertyMixed(Name, MinimumValue, MaximumValue, Value, MinimumIntValue, MaximumIntValue);
    }
}
