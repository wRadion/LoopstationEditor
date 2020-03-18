namespace LoopstationEditor.Converters.Int
{
    public class IntTargetConverter : IValueConverter<int, int>
    {
        public int Convert(int value) => value * 2;
        public int ConvertBack(int value) => value / 2;
    }
}
