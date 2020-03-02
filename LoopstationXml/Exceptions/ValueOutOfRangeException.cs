using System;

namespace Loopstation.Xml.Exceptions
{
    public class ValueOutOfRangeException : Exception
    {
        public ValueOutOfRangeException(int value, int min, int max)
            : base($"Integer value `{ value }' should be between `{ min }' and `{ max }'.") { }
    }
}
