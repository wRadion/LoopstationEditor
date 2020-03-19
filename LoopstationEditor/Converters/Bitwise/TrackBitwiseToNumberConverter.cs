using LoopstationEditor.Models.Settings.Memory;

namespace LoopstationEditor.Converters.Enum
{
    public class TrackBitwiseToNumberConverter : IValueConverter<TrackBitwise, string>
    {
        public string Convert(TrackBitwise value) => value.ToString()[5].ToString();
        public TrackBitwise ConvertBack(string value) => (TrackBitwise)System.Enum.Parse(typeof(TrackBitwise), "TRACK" + value);
    }
}
