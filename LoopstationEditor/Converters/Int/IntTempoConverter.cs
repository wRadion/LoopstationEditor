namespace LoopstationEditor.Converters.Int
{
    public class IntTempoConverter : IValueConverter<int, int>
    {
        public int Convert(int value) => value / 10;
        public int ConvertBack(int value) => value * 10;
    }
}
