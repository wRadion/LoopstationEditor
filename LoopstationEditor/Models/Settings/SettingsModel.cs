using System;
using System.Collections.Generic;
using System.Reflection;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings
{
    public abstract class SettingsModel : SettingsContainerModel
    {
        public const BindingFlags PropertyFlags = BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetProperty | BindingFlags.SetProperty;

        protected readonly PropertySet _properties;

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

            _properties = new PropertySet(GetType(), properties.ToArray());
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

        public override void ApplyXmlValues()
        {
            PropertyInfo[] instanceProperties = GetType().GetProperties(PropertyFlags);
            foreach (PropertyInfo prop in instanceProperties)
            {
                if (prop.GetCustomAttribute<PropertyAttribute>() == null) continue;

                object value = prop.GetValue(this);

                if (value is ValueInt intValue)
                    _properties.SetValue(prop.Name, intValue);
                else if (value is ValueBool boolValue)
                    _properties.SetValue(prop.Name, boolValue);
                else if (value is ValueChar charValue)
                    _properties.SetValue(prop.Name, charValue);
                else
                {
                    Type type = typeof(ValueEnum<>).MakeGenericType(value.GetType());
                    _properties.SetValue(prop.Name, (ValueInt)Activator.CreateInstance(type, value));
                }
            }
        }

        public override void ApplyPropertyValues()
        {
            PropertyInfo[] instanceProperties = GetType().GetProperties(PropertyFlags);
            foreach (PropertyInfo prop in instanceProperties)
            {
                if (prop.GetCustomAttribute<PropertyAttribute>() == null) continue;
                prop.SetValue(this, _properties.GetValue<ValueInt>(prop.Name));
            }
        }
    }
}
