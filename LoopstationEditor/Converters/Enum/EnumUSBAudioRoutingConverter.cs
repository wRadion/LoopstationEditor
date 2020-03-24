using LoopstationEditor.Models.Settings.System;
using System;

namespace LoopstationEditor.Converters.Enum
{
    public class EnumUSBAudioRoutingConverter : IValueConverter<USBAudioRouting, string>
    {
        public string Convert(USBAudioRouting value)
        {
            switch (value)
            {
                case USBAudioRouting.LOOP_IN: return "LOOP-IN";
                case USBAudioRouting.SUB_MIX: return "SUB MIX";
                case USBAudioRouting.LINEOUT: return "LINEOUT";
            }

            return value.ToString();
        }

        public USBAudioRouting ConvertBack(string value)
        {
            switch (value)
            {
                case "LOOP-IN": return USBAudioRouting.LOOP_IN;
                case "SUB MIX": return USBAudioRouting.SUB_MIX;
                case "LINEOUT": return USBAudioRouting.LINEOUT;
            }

            return (USBAudioRouting)System.Enum.Parse(typeof(USBAudioRouting), value);
        }
    }
}
