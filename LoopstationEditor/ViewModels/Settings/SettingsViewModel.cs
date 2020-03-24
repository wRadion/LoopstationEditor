using System;
using System.Linq;
using System.Reflection;

using LoopstationEditor.Models.PropertyEngine;
using LoopstationEditor.Models.Settings;

namespace LoopstationEditor.ViewModels.Settings
{
    public abstract class SettingsViewModel : ViewModel
    {
        public const BindingFlags PropertyFlags = BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetProperty | BindingFlags.DeclaredOnly;

        protected SettingsModel _model;
        protected PropertySet _properties;

        public event EventHandler AppliedChanges;

        public SettingsViewModel(SettingsModel model, bool useProperties = true)
        {
            _model = model;
            if (useProperties)
                _properties = _model.CopyPropertySet(GetType().GetProperties(PropertyFlags).Select((prop) => prop.Name).ToArray());
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
    }
}
