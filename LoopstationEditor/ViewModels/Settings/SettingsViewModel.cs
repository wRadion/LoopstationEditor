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

        public SettingsViewModel(SettingsModel model, bool useProperties = true)
        {
            _model = model;
            if (useProperties)
                _properties = _model.CopyPropertySet(GetType().GetProperties(PropertyFlags).Select((prop) => prop.Name).ToArray());
        }

        public virtual void ApplyChanges() => _model.PastePropertySet(_properties);
    }
}
