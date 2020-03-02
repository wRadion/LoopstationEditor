using Loopstation.Xml.Exceptions;

namespace Loopstation.Xml.Utils
{
    public class Range
    {
        /// <summary>
        /// Ensure that the given value is between the minimum and maximum value provided.
        /// <para>Throws a <c>ValueOutOfRangeException</c> if the value is not in the given range.</para>
        /// <para>Returns the integer value as is if the value is in the given range.</para>
        /// </summary>
        /// <param name="value">The value to test</param>
        /// <param name="min">The lower limit of the range (inclusive)</param>
        /// <param name="max">The upper limit of the range (inclusive)</param>
        /// <returns></returns>
        public static int Guard(int value, int min = 0, int max = 100)
        {
            if (min > value || value > max)
                throw new ValueOutOfRangeException(value, min, max);

            return value;
        }
    }
}