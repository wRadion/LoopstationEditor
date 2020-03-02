using System;

using Loopstation.Common.Property;

namespace Loopstation.Common
{
    public class InvalidMixedPropertyValueType : Exception
    {
        public InvalidMixedPropertyValueType(MixedPropertyValueType actualType, Type expectedType)
            : base($"MixedProperty value is { actualType.ToString() } but expected [{ expectedType.Name }]")
        {
        }
    }
}
