namespace LoopstationModels
{
    public static class PropertyTypes
    {
        public static PropertyType Default = new PropertyType();
    }

    public class PropertyType
    {
        public int DefaultValue { get; }
        public int MinValue { get; }
        public int MaxValue { get; }

        public PropertyType(int defaultValue = 0, int minValue = 0, int maxValue = 100)
        {
            DefaultValue = defaultValue;
            MinValue = minValue;
            MaxValue = maxValue;
        }
    }
}
