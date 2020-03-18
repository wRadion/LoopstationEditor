namespace LoopstationEditor.Converters.Int
{
    public class IntLevelConverter : IValueConverter<int, int>
    {
        public int Convert(int value) => value * 2;
        public int ConvertBack(int value) => value / 2;
    }
}
