namespace LoopstationModels.Utils
{
    public class Range
    {
        private int _minValue;
        private int _maxValue;

        /// <summary>
        /// Initializes a new Range.
        /// <para>Default Range (0 ... 100)</para>
        /// </summary>
        public Range() : this(100) { }

        /// <summary>
        /// Initializes a new Range.
        /// <para>Default minimum value: 0</para>
        /// </summary>
        /// <param name="maxValue">The upper limit of the Range (inclusive)</param>
        public Range(int maxValue) : this(0, maxValue) { }

        /// <summary>
        /// Initializes a new Range.
        /// </summary>
        /// <param name="minValue">The lower limit of the Range (inclusive)</param>
        /// <param name="maxValue">The upper limit of the Range (inclusive)</param>
        public Range(int minValue, int maxValue) { _minValue = minValue; _maxValue = maxValue; }

        /// <summary>
        /// Check if the given value is inside the bounds of the Range.
        /// </summary>
        /// <param name="value">The value to test</param>
        /// <returns><c>true</c> if the value is in the Range, <c>false</c> otherwise</returns>
        public bool Contains(int value) => _minValue <= value && value <= _maxValue;
    }
}
