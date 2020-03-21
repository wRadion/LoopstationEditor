using LoopstationEditor.Converters.Int;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxVocalDistViewModel : FxViewModel
    {
        public PropertyIntViewModel VocalDistDistortion { get; }
        public PropertyIntViewModel VocalDistTone { get; }
        public PropertyIntViewModel VocalDistLevel { get; }

        public FxVocalDistViewModel(SettingsMemoryFxModel model)
            : base("Vocal Dist", model)
        {
            VocalDistDistortion = new PropertyIntViewModel(nameof(VocalDistDistortion), _properties);
            VocalDistTone = new PropertyIntViewModel(nameof(VocalDistTone), _properties, new IntToneConverter());
            VocalDistLevel = new PropertyIntViewModel(nameof(VocalDistLevel), _properties);
        }
    }
}
