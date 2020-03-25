using LoopstationEditor.Models.Settings.Memory;

namespace LoopstationEditor.Converters.Enum
{
    public class EnumOctaveModeConverter : IValueConverter<FxOctaveMode, string>
    {
        public string Convert(FxOctaveMode value)
        {
            switch (value)
            {
                case FxOctaveMode.MINUS_1OCT: return "-1OCT";
                case FxOctaveMode.MINUS_2OCT: return "-2OCT";
                case FxOctaveMode.BOTH: return "-1OCT&-2OCT";
            }

            return value.ToString();
        }

        public FxOctaveMode ConvertBack(string value)
        {
            switch (value)
            {
                case "-1OCT": return FxOctaveMode.MINUS_1OCT;
                case "-2OCT": return FxOctaveMode.MINUS_2OCT;
                case "-1OCT&-2OCT": return FxOctaveMode.BOTH;
            }

            return (FxOctaveMode)System.Enum.Parse(typeof(FxOctaveMode), value);
        }
    }
}
