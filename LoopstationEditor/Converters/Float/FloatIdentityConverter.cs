namespace LoopstationEditor.Converters.Float
{
    public class FloatIdentityConverter : IValueConverter<int, float>
    {
        public float Convert(int value) => value;
        public int ConvertBack(float value) => (int)value;
    }
}
