using System;
using System.Collections.Generic;
using System.Reflection;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings
{
    public abstract class SettingsModel : SettingsContainerModel
    {
        public const BindingFlags PropertyFlags = BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetProperty | BindingFlags.SetProperty;

        public PropertySet PropertySet { get; private set; }

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
                {
                    Property intProperty = new Property(prop.Name + "_int", mixedAttr.IntAttribute);
                    Property enumProperty = new Property(prop.Name + "_enum", mixedAttr.EnumAttribute);
                    Property boolProperty = new Property(prop.Name + "_mixed", mixedAttr.BoolAttribute);

                    propValue = Convert.ToBoolean(boolProperty.Value) ? enumProperty : intProperty;

                    properties.Add(intProperty);
                    properties.Add(enumProperty);
                    properties.Add(boolProperty);
                }
                else
                {
                    propValue = new Property(prop.Name, attr);
                    properties.Add(propValue);
                }

                prop.SetValue(this, propValue.Value);
            }

            PropertySet = new PropertySet(GetType(), properties.ToArray());
        }

        public override void ApplyXmlValues()
        {
            PropertyInfo[] instanceProperties = GetType().GetProperties(PropertyFlags);
            foreach (PropertyInfo prop in instanceProperties)
            {
                if (prop.GetCustomAttribute<PropertyAttribute>() == null) continue;

                object value = prop.GetValue(this);

                if (value is ValueInt intValue)
                    PropertySet.SetValue(prop.Name, intValue);
                else if (value is ValueBool boolValue)
                    PropertySet.SetValue(prop.Name, boolValue);
                else if (value is ValueChar charValue)
                    PropertySet.SetValue(prop.Name, charValue);
                else
                {
                    Type type = typeof(ValueEnum<>).MakeGenericType(value.GetType());
                    PropertySet.SetValue(prop.Name, (ValueInt)Activator.CreateInstance(type, value));
                }
            }
        }

        public override void ApplyPropertyValues()
        {
            PropertyInfo[] instanceProperties = GetType().GetProperties(PropertyFlags);
            foreach (PropertyInfo prop in instanceProperties)
            {
                if (prop.GetCustomAttribute<PropertyAttribute>() == null) continue;
                prop.SetValue(this, PropertySet.GetValue<ValueInt>(prop.Name));
            }
        }
    }
}
