using System;
using System.Collections.Generic;
using System.Reflection;

using LoopstationEditor.Models.PropertyEngine;
using LoopstationEditor.Models.Settings;
using LoopstationEditor.Utils;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings
{
    public abstract class SettingsViewModel : ViewModel
    {
        public const BindingFlags PropertyFlags = BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetProperty | BindingFlags.DeclaredOnly;

        protected SettingsModel _model;
        protected string[] _propertyNames;

        public PropertySet PropertySet { get; private set; }

        public event EventHandler AppliedChanges;

        public SettingsViewModel(SettingsModel model, bool useProperties = true)
        {
            _model = model;
            List<string> names = new List<string>();
            Type mixed = typeof(PropertyMixedViewModel<Enum>).GetGenericTypeDefinition();

            foreach (PropertyInfo prop in GetType().GetProperties(PropertyFlags))
            {
                Type propType = prop.PropertyType;

                if (propType.IsGenericType && propType.GetGenericTypeDefinition() == mixed)
                {
                    names.Add(prop.Name + "_mixed");
                    names.Add(prop.Name + "_int");
                    names.Add(prop.Name + "_enum");
                }
                else
                    names.Add(prop.Name);
            }
            _propertyNames = names.ToArray();

            if (useProperties)
                PropertySet = _model.PropertySet.Clone(_propertyNames);
            else
                PropertySet = null;
        }

        public void ApplyChanges() => ApplyChanges(_model);
        public virtual void ApplyChanges<T>(T model) where T : SettingsModel
        {
            if (PropertySet != null)
                PropertySet.CopyTo(model.PropertySet);
            AppliedChanges?.Invoke(this, EventArgs.Empty);
        }

        public virtual void RevertChanges()
        {
            if (PropertySet != null)
                _model.PropertySet.Clone(_propertyNames).CopyTo(PropertySet);
        }
    }
}
