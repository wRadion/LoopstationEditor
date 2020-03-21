namespace LoopstationEditor.Converters.Int
{
    public class IntStepRateConverter : IValueConverter<int, int>
    {
        public int Convert(int value) => value - 1;
        public int ConvertBack(int value) => value + 1;
    }
}
