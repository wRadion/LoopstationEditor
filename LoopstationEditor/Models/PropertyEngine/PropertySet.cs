using System;
using System.Linq;
using System.Collections.Generic;

namespace LoopstationEditor.Models.PropertyEngine
{
    public class PropertySet
    {
        private readonly Dictionary<string, Property> _properties;

        public PropertySet(params Property[] properties)
        {
            _properties = new Dictionary<string, Property>();
            properties.ToList().ForEach((p) =>
            {
                if (p is PropertyMixed mixedp)
                    _properties.Add(p.Name, mixedp);
                else
                    _properties.Add(p.Name, p);
            });
        }

        private void ContainsNameGuard(string name)
        {
            if (!_properties.ContainsKey(name))
                throw new KeyNotFoundException($"Property `{ name }' was not found.");
        }

        public T GetValue<T>(string name) where T : ValueInt
        {
            ContainsNameGuard(name);
            return (T)_properties[name].Value;
        }

        public void SetValue<T>(string name, T value) where T : ValueInt
        {
            ContainsNameGuard(name);
            _properties[name].Value = value;
        }

        public Property GetProperty(string name)
        {
            ContainsNameGuard(name);
            return _properties[name];
        }

        public PropertySet Clone()
        {
            Property[] props = new Property[_properties.Count];
            List<Property> list = _properties.Values.ToList();

            for (int i = 0; i < props.Length; ++i)
            {
                Property prop = list[i];

                if (prop is PropertyMixed mixedProp)
                    props[i] = mixedProp.Clone();
                else
                    props[i] = prop.Clone();
            }

            return new PropertySet(props);
        }

        public void ForEachName(Action<string> action) => _properties.Keys.ToList().ForEach(action);
    }
}
