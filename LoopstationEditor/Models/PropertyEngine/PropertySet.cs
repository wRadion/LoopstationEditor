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

        public PropertySet Clone(params string[] names)
        {
            Property[] props = new Property[(names == null || names.Length == 0) ? _properties.Count : names.Length];
            List<Property> list = _properties.Values.ToList();

            int currentIndex = 0;
            for (int i = 0; i < list.Count; ++i)
            {
                Property prop = list[i];

                if (names != null && names.Length > 0 && !names.Contains(prop.Name))
                    continue;

                if (prop is PropertyMixed mixedProp)
                    props[currentIndex++] = mixedProp.Clone();
                else
                    props[currentIndex++] = prop.Clone();
            }

            return new PropertySet(props);
        }

        public void ForEachName(Action<string> action) => _properties.Keys.ToList().ForEach(action);
    }
}
