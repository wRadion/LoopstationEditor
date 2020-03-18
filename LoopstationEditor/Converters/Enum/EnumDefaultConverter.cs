namespace LoopstationEditor.Converters.Enum
{
    public class EnumDefaultConverter<TEnum> : IValueConverter<TEnum, string> where TEnum : System.Enum
    {
        public string Convert(TEnum value)
        {
            return value.ToString().Replace('_', ' ').Replace(" PLUS ", "+").Replace(" THEN ", ">");
        }

        public TEnum ConvertBack(string value)
        {
            return (TEnum)System.Enum.Parse(typeof(TEnum), value.Replace(">", " THEN ").Replace("+", " PLUS ").Replace(' ', '_'));
        }
    }
}
