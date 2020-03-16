using LoopstationEditor.Models.Settings.Memory.Fx;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxVocalDistViewModel : SettingsViewModel
    {
        public PropertyIntViewModel VocalDistDistortion { get; }
        public PropertyIntViewModel VocalDistTone { get; }
        public PropertyIntViewModel VocalDistLevel { get; }

        public FxVocalDistViewModel(FxVocalDistModel model)
            : base(model)
        {
            VocalDistDistortion = new PropertyIntViewModel(FxProperty.VocalDistDistortion, _properties);
            VocalDistTone = new PropertyIntViewModel(FxProperty.VocalDistTone, _properties);
            VocalDistLevel = new PropertyIntViewModel(FxProperty.VocalDistLevel, _properties);
        }
    }
}
