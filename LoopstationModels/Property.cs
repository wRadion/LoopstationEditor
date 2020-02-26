using System;

using LoopstationModels.Utils;

namespace LoopstationModels
{
    public class Property
    {
        private int _value;

        /// <summary>
        /// Gets the name of the property.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the default value of the property.
        /// </summary>
        public int DefaultValue { get; }

        /// <summary>
        /// Gets the range of the property.
        /// </summary>
        public Range Range { get; }

        /// <summary>
        /// Gets or sets the current value helds by the property.
        /// </summary>
        public int Value
        {
            get => _value;
            set
            {
                if (!Range.Contains(value))
                    throw new ArgumentOutOfRangeException();

                _value = value;
            }
        }

        /// <summary>
        /// Initializes a new property.
        /// </summary>
        /// <param name="name">The name of the property</param>
        /// <param name="default">The default value of the property</param>
        /// <param name="min">The lower limit of the property</param>
        /// <param name="max">The upper limit of the property</param>
        public Property(string name, int @default, int min, int max)
        {
            Name = name;
            DefaultValue = @default;
            Range = new Range(min, max);
            Value = DefaultValue;
        }
    }
}