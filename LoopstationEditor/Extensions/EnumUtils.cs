using System;
using System.Linq;

namespace LoopstationEditor.Extensions
{
    public static class EnumUtils
    {
        public static TEnum[] GetOptions<TEnum>() => Enum.GetNames(typeof(TEnum)).Select((str) => (TEnum)Enum.Parse(typeof(TEnum), str)).ToArray();
    }
}
