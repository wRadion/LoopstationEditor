namespace LoopstationEditor.Converters.Int
{
    public class IntDepthConverter : IValueConverter<int, int>
    {
        public int Convert(int value) => 16 - value;
        public int ConvertBack(int value) => 16 + value;
    }
}
