using System;

using LoopstationEditor.Models.Settings;

namespace LoopstationEditor.ViewModels.Settings
{
    public abstract class SettingsContainerViewModel : ViewModel
    {
        protected readonly SettingsContainerModel _model;

        public event EventHandler TabChanged;

        private int _selectedIndex;
        public int SelectedIndex
        {
            get => _selectedIndex;
            set
            {
                _selectedIndex = value;
                TabChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public abstract SettingsViewModel CurrentViewModel { get; }

        public SettingsContainerViewModel(SettingsContainerModel model)
            : base()
        {
            _model = model;
        }

        public abstract void ApplyChanges();
        public abstract void RevertChanges();
    }
}
