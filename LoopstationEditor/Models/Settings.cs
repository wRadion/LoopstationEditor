using System.Collections.Generic;
using System.Reflection;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models
{
    public abstract class Settings
    {
        private readonly PropertySet _properties;

        public Settings()
        {
            List<Property> properties = new List<Property>();

            PropertyInfo[] instanceProperties = GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetProperty | BindingFlags.SetProperty);
            foreach (PropertyInfo prop in instanceProperties)
            {
                PropertyAttribute attr = prop.GetCustomAttribute<PropertyAttribute>();
                if (attr == null) continue;

                properties.Add(new Property(attr));
            }

            _properties = new PropertySet(properties.ToArray());
        }
    }
}
