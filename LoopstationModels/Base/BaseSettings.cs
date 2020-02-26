using System.Collections.Generic;

namespace LoopstationModels.Base
{
    public class BaseSettings
    {
        private Dictionary<string, Property> _properties;

        /// <summary>
        /// Initializes _properties if it's null.
        /// </summary>
        private void InitializeIfNull()
        {
            if (_properties == null)
                _properties = new Dictionary<string, Property>();
        }

        /// <summary>
        /// Initializes _properties and check for given key in _properties.
        /// </summary>
        /// <param name="key">The key to check</param>
        private void InitializeAndCheckKey(string key)
        {
            InitializeIfNull();
            if (!_properties.ContainsKey(key))
                throw new KeyNotFoundException();
        }

        /// <summary>
        /// Adds a property for this settings.
        /// </summary>
        /// <param name="name">The name of the property</param>
        /// <param name="def">The default value of the property</param>
        /// <param name="min">The lower limit of the property (inclusive)</param>
        /// <param name="max">The upper limit of the property (inclusive)</param>
        protected void AddProperty(string name, int def = 0, int min = 0, int max = 100)
        {
            InitializeIfNull();
            _properties[name] = new Property(name, def, min, max);
        }

        /// <summary>
        /// Gets the value of the given property name.
        /// <para>Throw a <c>KeyNotFoundException</c> if the name doesn't exist</para>
        /// </summary>
        /// <param name="name">The name of the property to retrieve</param>
        /// <returns>The current value helds by the property</returns>
        public int GetProperty(string name)
        {
            InitializeAndCheckKey(name);
            return _properties[name].Value;
        }

        /// <summary>
        /// Sets the value of the given property name.
        /// <para>Throws <c>KeyNotFoundException</c> if the name doesn't exist</para>
        /// <para>Throws <c>ArgumentOutOfRangeException</c> if the given value is not valid for the property</para>
        /// </summary>
        /// <param name="name">The name of the property to set</param>
        /// <param name="value">The new value of the property</param>
        public void SetProperty(string name, int value)
        {
            InitializeAndCheckKey(name);
            _properties[name].Value = value;
        }
    }
}
