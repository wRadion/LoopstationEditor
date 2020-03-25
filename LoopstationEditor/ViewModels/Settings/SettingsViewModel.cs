using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using LoopstationEditor.Models.PropertyEngine;
using LoopstationEditor.Models.Settings;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings
{
    public abstract class SettingsViewModel : ViewModel
    {
        public const BindingFlags PropertyFlags = BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetProperty | BindingFlags.DeclaredOnly;

        protected SettingsModel _model;
        protected string[] _propertyNames;
        protected PropertySet _properties;

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
                _properties = _model.CopyPropertySet(_propertyNames);
            else
                _properties = null;
        }

        public void CopyToClipboard()
        {
            if (_properties == null) return;
            Clipboard.Instance.PropertySet = _properties.Clone();
        }
        public bool CanPasteFromClipboard() => _properties == null ? false : _properties.CanPaste(Clipboard.Instance.PropertySet);
        public void PasteFromClipboard()
        {
            if (_properties == null) return;
            _properties.Paste(Clipboard.Instance.PropertySet);
        }

        public virtual void ApplyChanges()
        {
            if (_properties != null)
                _model.PastePropertySet(_properties);
            AppliedChanges?.Invoke(this, EventArgs.Empty);
        }

        public virtual void RevertChanges()
        {
            if (_properties != null)
                _properties.Paste(_model.CopyPropertySet(_propertyNames));
        }
    }
}
