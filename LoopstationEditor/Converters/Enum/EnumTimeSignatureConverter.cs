using System.Text.RegularExpressions;

namespace LoopstationEditor.Converters.Enum
{
    public class EnumTimeSignatureConverter<TEnum> : IValueConverter<TEnum, string> where TEnum : System.Enum
    {
        public string Convert(TEnum value)
        {
            string enumString = value.ToString();

            if (Regex.IsMatch(enumString, "_\\d+_\\d+"))
                return enumString.Substring(1).Replace('_', '/');
            else
                return enumString;
        }

        public TEnum ConvertBack(string value)
        {
            string enumString = value;

            if (Regex.IsMatch(value, "\\d+/\\d+"))
                enumString = value.Replace('/', '_').Insert(0, "_");

            return (TEnum)System.Enum.Parse(typeof(TEnum), enumString);
        }
    }
}
