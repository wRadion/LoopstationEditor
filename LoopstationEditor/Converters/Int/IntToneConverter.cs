namespace LoopstationEditor.Converters.Int
{
    public class IntToneConverter : IValueConverter<int, int>
    {
        public int Convert(int value) => value - 50;
        public int ConvertBack(int value) => value + 50;
    }
}
