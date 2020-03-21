using LoopstationEditor.Models.Settings;

namespace LoopstationEditor.ViewModels.Settings
{
    public abstract class SettingsContainerViewModel : ViewModel
    {
        protected readonly SettingsContainerModel _model;

        public SettingsContainerViewModel(SettingsContainerModel model)
            : base()
        {
            _model = model;
        }

        public abstract void ApplyChanges();
    }
}
