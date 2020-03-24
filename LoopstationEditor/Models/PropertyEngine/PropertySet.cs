using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;

namespace LoopstationEditor.Models.PropertyEngine
{
    public class PropertySet
    {
        private readonly Type _type;
        private readonly Dictionary<string, Property> _properties;

        public event PropertyChangedEventHandler PropertyChanged;

        public PropertySet(Type type, params Property[] properties)
        {
            _type = type;
            _properties = new Dictionary<string, Property>();

            properties.ToList().ForEach((p) =>
            {
                if (p is PropertyMixed mixedp)
                    _properties.Add(p.Name, mixedp);
                else
                    _properties.Add(p.Name, p);
            });
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void ContainsNameGuard(string propertyName)
        {
            if (!Contains(propertyName))
                throw new KeyNotFoundException($"Property `{ propertyName }' was not found.");
        }

        public int Count => _properties.Count;
        public bool Contains(string propertyName) => _properties.ContainsKey(propertyName);

        public T GetValue<T>(string name) where T : ValueInt
        {
            ContainsNameGuard(name);
            return (T)_properties[name].Value;
        }

        public void SetValue<T>(string name, T value) where T : ValueInt
        {
            ContainsNameGuard(name);
            _properties[name].Value = value;
            OnPropertyChanged(name);
        }

        public Property GetProperty(string name)
        {
            ContainsNameGuard(name);
            return _properties[name];
        }

        public bool CanPaste(PropertySet properties) => properties != null && Count == properties.Count && _type == properties._type;

        public void Paste(PropertySet properties)
        {
            properties.ForEachName((name) =>
            {
                if (Contains(name))
                    SetValue(name, properties.GetValue<ValueInt>(name));
            });
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

            return new PropertySet(_type, props);
        }

        public void ForEachName(Action<string> action) => _properties.Keys.ToList().ForEach(action);
    }
}
