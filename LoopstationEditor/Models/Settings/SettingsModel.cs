using System.Collections.Generic;
using System.Reflection;
using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings
{
    public abstract class SettingsModel : SettingsContainerModel
    {
        public const BindingFlags PropertyFlags = BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetProperty | BindingFlags.SetProperty;

        private readonly PropertySet _properties;

        public SettingsModel() : base()
        {
            List<Property> properties = new List<Property>();

            PropertyInfo[] instanceProperties = GetType().GetProperties(PropertyFlags);
            foreach (PropertyInfo prop in instanceProperties)
            {
                PropertyAttribute attr = prop.GetCustomAttribute<PropertyAttribute>();
                if (attr == null) continue;

                Property propValue;

                if (attr is PropertyMixedAttribute mixedAttr)
                    propValue = new PropertyMixed(prop.Name, mixedAttr);
                else
                    propValue = new Property(prop.Name, attr);

                properties.Add(propValue);

                prop.SetValue(this, propValue.Value);
            }

            _properties = new PropertySet(properties.ToArray());
        }

        public void PastePropertySet(PropertySet set)
        {
            set.ForEachName((name) =>
            {
                try { _properties.SetValue(name, set.GetValue<ValueInt>(name)); }
                catch (KeyNotFoundException) { }
            });
        }

        public PropertySet CopyPropertySet(params string[] names) => _properties.Clone(names);
    }
}
