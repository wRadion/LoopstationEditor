using System;

using Loopstation.Common.Property;

namespace Loopstation.Common
{
    public class InvalidMixedPropertyValueTypeException : Exception
    {
        public InvalidMixedPropertyValueTypeException(MixedPropertyValueType actualType, Type expectedType)
            : base($"MixedProperty value is { actualType.ToString() } but expected [{ expectedType.Name }]")
        {
        }
    }
}
