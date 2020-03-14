using System;

namespace LoopstationEditor.Extensions
{
    public static class EnumUtils
    {
        public static string ToString(object value)
        {
            return value.ToString().Replace('_', ' ').Replace(" PLUS ", "+").Replace(" THEN ", ">");
        }

        public static T FromString<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value.Replace(">", " THEN ").Replace("+", " PLUS ").Replace(' ', '_'));
        }

        public static string[] GetOptions<T>()
        {
            string[] names = Enum.GetNames(typeof(T));
            string[] enums = new string[names.Length];

            for (int i = 0; i < enums.Length; ++i)
                enums[i] = ToString(names[i]);

            return enums;
        }
    }
}
