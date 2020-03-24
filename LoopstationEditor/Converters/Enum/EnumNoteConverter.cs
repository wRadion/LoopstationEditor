using System;

namespace LoopstationEditor.Converters.Enum
{
    public class EnumNoteConverter<TEnum> : IValueConverter<TEnum, string> where TEnum : System.Enum
    {
        public string Convert(TEnum value)
        {
            switch (value.ToString())
            {
                case "WHOLE_NOTE": return "𝅝";
                //case "DOTTED_HALF_NOTE": return "𝅗𝅥.";
                case "HALF_NOTE": return "𝅗𝅥";
                case "DOTTED_QUARTER_NOTE": return "𝅘𝅥.";
                case "HALF_NOTE_TRIPLET": return "𝅗𝅥₃";
                case "QUARTER_NOTE": return "𝅘𝅥";
                case "DOTTED_EIGHTH_NOTE": return "𝅘𝅥𝅮.";
                case "QUARTER_NOTE_TRIPLET": return "𝅘𝅥₃";
                case "EIGHTH_NOTE": return "𝅘𝅥𝅮";
                case "DOTTED_SIXTEENTH_NOTE": return "𝅘𝅥𝅯.";
                case "EIGHTH_NOTE_TRIPLET": return "𝅘𝅥𝅮₃";
                case "SIXTEENTH_NOTE": return "𝅘𝅥𝅯";
                //case "DOTTED_THIRTYSECOND_NOTE": return "𝅘𝅥𝅰.";
                //case "SIXTEENTH_NOTE_TRIPLET": return "𝅘𝅥𝅯₃";
                case "THIRTYSECOND_NOTE": return "𝅘𝅥𝅰";
            }

            return value.ToString();
        }

        public TEnum ConvertBack(string value)
        {
            string enumString = value;

            switch (value)
            {
                case "𝅝": enumString = "WHOLE_NOTE"; break;
                //case "𝅗𝅥.": enumString = "DOTTED_HALF_NOTE"; break;
                case "𝅗𝅥": enumString = "HALF_NOTE"; break;
                case "𝅘𝅥.": enumString = "DOTTED_QUARTER_NOTE"; break;
                case "𝅗𝅥₃": enumString = "HALF_NOTE_TRIPLET"; break;
                case "𝅘𝅥": enumString = "QUARTER_NOTE"; break;
                case "𝅘𝅥𝅮.": enumString = "DOTTED_EIGHTH_NOTE"; break;
                case "𝅘𝅥₃": enumString = "QUARTER_NOTE_TRIPLET"; break;
                case "𝅘𝅥𝅮": enumString = "EIGHTH_NOTE"; break;
                case "𝅘𝅥𝅯.": enumString = "DOTTED_SIXTEENTH_NOTE"; break;
                case "𝅘𝅥𝅮₃": enumString = "EIGHTH_NOTE_TRIPLET"; break;
                case "𝅘𝅥𝅯": enumString = "SIXTEENTH_NOTE"; break;
                //case "𝅘𝅥𝅰.": enumString = "DOTTED_THIRTYSECOND_NOTE"; break;
                //case "𝅘𝅥𝅯₃": enumString = "SIXTEENTH_NOTE_TRIPLET"; break;
                case "𝅘𝅥𝅰": enumString = "THIRTYSECOND_NOTE"; break;
            }

            return (TEnum)System.Enum.Parse(typeof(TEnum), enumString);
        }
    }
}
