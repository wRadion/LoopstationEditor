namespace LoopstationEditor.Converters.Int
{
    public class IntOctaveConverter : IValueConverter<int, int>
    {
        public int Convert(int value) => value - 3;
        public int ConvertBack(int value) => value + 3;
    }
}
