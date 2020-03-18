﻿using System.Linq;

using LoopstationEditor.Models.PropertyEngine;
using LoopstationEditor.Models.Settings;

namespace LoopstationEditor.ViewModels.Settings
{
    public abstract class SettingsViewModel : ViewModel
    {
        protected SettingsModel _model;
        protected PropertySet _properties;

        public SettingsViewModel(SettingsModel model)
        {
            _model = model;
            _properties = _model.CopyPropertySet(GetType().GetProperties(SettingsModel.PropertyFlags).Select((prop) => prop.Name).ToArray());
        }

        public void ApplyChanges() => _model.PastePropertySet(_properties);
    }
}