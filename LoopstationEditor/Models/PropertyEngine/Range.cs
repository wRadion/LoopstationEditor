using System;
using System.Linq;

namespace LoopstationEditor.Models.PropertyEngine
{
    public interface IRange
    {
        int Minimum { get; }
        int Maximum { get; }

        bool Contains(int value);
        T ContainsGuard<T>(T value) where T : ValueInt;
    }

    public struct Range : IRange
    {
        public int Minimum { get; }
        public int Maximum { get; }

        public Range(int min, int max)
        {
            if (min > max)
                throw new ArgumentException("Maximum must be greater than Minimum.");

            Minimum = min;
            Maximum = max;
        }

        public bool Contains(int value) => Minimum <= value && value <= Maximum;
        public T ContainsGuard<T>(T value) where T : ValueInt
        {
            if (!Contains((int)value))
                throw new ArgumentOutOfRangeException($"Value must be between { Minimum } and { Maximum }.");
            return value;
        }
    }

    public struct ExtendedRange : IRange
    {
        public int Minimum { get; }
        public int Maximum { get; }
        public int[] ExtendedValues { get; }

        public ExtendedRange(int min, int max, params int[] extendedValues)
        {
            if (min > max)
                throw new ArgumentException("Maximum must be greater than Minimum.");

            Minimum = min;
            Maximum = max;
            ExtendedValues = extendedValues;
        }

        public bool Contains(int value) => (Minimum <= value && value <= Maximum) || ExtendedValues.Contains(value);
        public T ContainsGuard<T>(T value) where T : ValueInt
        {
            if (!Contains((int)value))
                throw new ArgumentOutOfRangeException($"Value must be between { Minimum } and { Maximum } or in [{ ExtendedValues.Select((i) => i.ToString()).Aggregate((s1, s2) => s1 + ", " + s2) }]");
            return value;
        }
    }
}
