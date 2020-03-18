namespace LoopstationEditor.Converters.Int
{
    public class IntIdentityConverter : IValueConverter<int, int>
    {
        public int Convert(int value) => value;
        public int ConvertBack(int value) => value;
    }
}
