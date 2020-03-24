using System.Globalization;
using System.Text.RegularExpressions;

using LoopstationEditor.Models.Settings.Memory;

namespace LoopstationEditor.Converters.Enum
{
    public class EnumRhythmPatternConverter : IValueConverter<RhythmPattern, string>
    {
        public string Convert(RhythmPattern value)
        {
            string result = value.ToString();

            if (result[0] == '_')
                result = result.Substring(1);
            result = result.ToString().
                Replace("1_2", "1/2").
                Replace('_', ' ').
                Replace("R AND B", "R&B").
                Replace(" AND ", " & ").
                Replace("HI HAT", "HI-HAT");

            TextInfo info = new CultureInfo("en-US", false).TextInfo;

            return info.ToTitleCase(result.ToLower()).Replace("16Th", "16th");
        }

        public RhythmPattern ConvertBack(string value)
        {
            string enumValue = value.ToUpper();

            enumValue = enumValue.
                Replace("HI-HAT", "HI HAT").
                Replace(" & ", " AND ").
                Replace("R&B", "R AND B").
                Replace('/', ' ').
                Replace(' ', '_');

            if (Regex.IsMatch(enumValue, "^\\d"))
                enumValue = enumValue.Insert(0, "_");

            return (RhythmPattern)System.Enum.Parse(typeof(RhythmPattern), enumValue);
        }
    }
}
