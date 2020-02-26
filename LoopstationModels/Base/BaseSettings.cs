using System;
using System.Collections.Generic;

using LoopstationModels.Utils;

namespace LoopstationModels.Base
{
    public class BaseSettings
    {
        private Dictionary<string, Property> _properties;

        public BaseSettings()
        {
            _properties = new Dictionary<string, Property>();
        }

        protected void AddProperty(string propertyName, PropertyType type)
        {
            _properties[propertyName] = new Property(propertyName, type.DefaultValue, type.MinValue, type.MaxValue);
        }

        public int GetProperty(string propertyName)
        {
            if (!_properties.ContainsKey(propertyName))
                throw new KeyNotFoundException();

            return _properties[propertyName].Value;
        }

        public void SetProperty(string propertyName, int value)
        {
            if (!_properties.ContainsKey(propertyName))
                throw new KeyNotFoundException();

            _properties[propertyName].Value = value;
        }
    }
}
