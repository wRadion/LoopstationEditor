using System.Linq;
using System.Collections.Generic;

namespace LoopstationEditor.Models.PropertyEngine
{
    public class PropertySet
    {
        private Dictionary<string, Property> _properties;

        public PropertySet(params Property[] properties)
        {
            _properties = new Dictionary<string, Property>();
            properties.ToList().ForEach((p) => _properties.Add(p.Name, p));
        }

        private void ContainsNameGuard(string name)
        {
            if (!_properties.ContainsKey(name))
                throw new KeyNotFoundException($"Property `{ name }' was not found.");
        }

        public T GetProperty<T>(string name) where T : ValueInt
        {
            ContainsNameGuard(name);
            return (T)_properties[name].Value;
        }

        public void SetProperty<T>(string name, T value) where T : ValueInt
        {
            ContainsNameGuard(name);
            _properties[name].Value = value;
        }
    }
}
