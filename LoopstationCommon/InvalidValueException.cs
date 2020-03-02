using System;
using System.Linq;

namespace Loopstation.Common
{
    public class InvalidValueException : Exception
    {
        public InvalidValueException(object value, params Type[] allowedTypes)
            : base($"Value `{ value }' should be one of these types: { allowedTypes.Select((t) => $"[{ t.Name }]").Aggregate(string.Concat) }")
        {
        }
    }
}
