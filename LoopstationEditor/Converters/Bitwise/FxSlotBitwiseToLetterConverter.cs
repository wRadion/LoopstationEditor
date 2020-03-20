using LoopstationEditor.Models.Settings.Memory;

namespace LoopstationEditor.Converters.Bitwise
{
    public class FxSlotBitwiseToLetterConverter : IValueConverter<FxSlotBitwise, string>
    {
        public string Convert(FxSlotBitwise value) => value.ToString().ToString();
        public FxSlotBitwise ConvertBack(string value) => (FxSlotBitwise)System.Enum.Parse(typeof(FxSlotBitwise), value);
    }
}
