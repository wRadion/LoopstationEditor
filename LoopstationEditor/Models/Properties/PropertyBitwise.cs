using System;
using System.Linq;
using System.Reflection;

namespace LoopstationEditor.Models.Properties
{
    public class PropertyBitwise<TEnum> : PropertyEnum<TEnum> where TEnum : struct, IComparable, IFormattable, IConvertible
    {
        public PropertyBitwise(TEnum def, int min, int max) : base(def, min, max)
        {
            if (typeof(TEnum).GetCustomAttribute<FlagsAttribute>() == null)
                throw new CustomAttributeFormatException($"Enum { typeof(TEnum).Name } must have a FlagsAttribute.");
        }

        public bool HasFlag(TEnum flag)
        {
            int flagIndex = Enum.GetNames(typeof(TEnum)).ToList().IndexOf(flag.ToString());
            int flagValue = (int)Enum.GetValues(typeof(TEnum)).GetValue(flagIndex);

            return (_intValue & flagValue) == flagValue;
        }
    }
}
