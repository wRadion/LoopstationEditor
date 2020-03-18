namespace LoopstationEditor.Converters.Int
{
    public class IntDbConverter : IValueConverter<int, int>
    {
        public int Convert(int value) => value - 20;
        public int ConvertBack(int value) => value + 20;
    }
}
