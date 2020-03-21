namespace LoopstationEditor.Converters.Float
{
    public class FloatTimeConverter : IValueConverter<int, float>
    {
        public float Convert(int value) => value / 10f;
        public int ConvertBack(float value) => (int)(value * 10);
    }
}
