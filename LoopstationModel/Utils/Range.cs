namespace Loopstation.Model.Utils
{
    public class Range
    {
        private int _min;
        private int _max;

        /// <summary>
        /// Initializes a new Range.
        /// <para>Default Range (0 ... 100)</para>
        /// </summary>
        public Range() : this(100) { }

        /// <summary>
        /// Initializes a new Range.
        /// <para>Default minimum value: 0</para>
        /// </summary>
        /// <param name="max">The upper limit of the Range (inclusive)</param>
        public Range(int max) : this(0, max) { }

        /// <summary>
        /// Initializes a new Range.
        /// </summary>
        /// <param name="min">The lower limit of the Range (inclusive)</param>
        /// <param name="max">The upper limit of the Range (inclusive)</param>
        public Range(int min, int max) { _min = min; _max = max; }

        /// <summary>
        /// Check if the given value is inside the bounds of the Range.
        /// </summary>
        /// <param name="value">The value to test</param>
        /// <returns><c>true</c> if the value is in the Range, <c>false</c> otherwise</returns>
        public bool Contains(int value) => _min <= value && value <= _max;
    }
}