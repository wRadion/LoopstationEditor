namespace LoopstationEditor.Converters.Int
{
    public class IntSemitonesConverter : IValueConverter<int, int>
    {
        public int Convert(int value) => value - 12;
        public int ConvertBack(int value) => value + 12;
    }
}
