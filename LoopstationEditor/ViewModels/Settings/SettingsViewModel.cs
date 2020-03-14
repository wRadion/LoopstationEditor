using LoopstationEditor.Commands;
using LoopstationEditor.Models.PropertyEngine;
using LoopstationEditor.Models.Settings;
using System.Windows.Input;

namespace LoopstationEditor.ViewModels.Settings
{
    public class SettingsViewModel : ViewModel
    {
        protected SettingsModel _model;
        protected PropertySet _properties;

        public ICommand ApplyChangesCommand { get; }
        public ICommand CancelChangesCommand { get; }

        public SettingsViewModel(SettingsModel model)
        {
            _model = model;
            _properties = model.CopyPropertySet();

            ApplyChangesCommand = new RelayCommand(() => _model.PastePropertySet(_properties));
            CancelChangesCommand = new RelayCommand(() => { });
        }
    }
}
