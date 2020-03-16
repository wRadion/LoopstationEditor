using LoopstationEditor.Models.Settings;

namespace LoopstationEditor.ViewModels.Settings
{
    // TODO SettingsContainerViewModel
    public class SettingsContainerViewModel : ViewModel
    {
        protected readonly SettingsContainerModel _model;

        public SettingsContainerViewModel(SettingsContainerModel model)
            : base()
        {
            _model = model;
        }
    }
}
