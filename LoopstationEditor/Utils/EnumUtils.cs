using System;
using System.Linq;

namespace LoopstationEditor.Utils
{
    public static class EnumUtils
    {
        public static TEnum[] GetOptions<TEnum>() => Enum.GetNames(typeof(TEnum)).Select((str) => (TEnum) Enum.Parse(typeof(TEnum), str)).ToArray();
        public static TEnum[] GetBitwiseOptions<TEnum>() => Enum.GetNames(typeof(TEnum)).Where((str) => str != "NONE" && str != "ALL").Select((str) => (TEnum)Enum.Parse(typeof(TEnum), str)).ToArray();
    }
}
