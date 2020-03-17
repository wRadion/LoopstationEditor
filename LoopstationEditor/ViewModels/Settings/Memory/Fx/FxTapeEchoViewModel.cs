using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxTapeEchoViewModel : SettingsViewModel
    {
        public PropertyIntViewModel TapeEchoRate { get; }
        public PropertyIntViewModel TapeEchoIntensity { get; }
        public PropertyIntViewModel TapeEchoLevel { get; }

        public FxTapeEchoViewModel(SettingsMemoryFxModel model)
            : base(model)
        {
            TapeEchoRate = new PropertyIntViewModel(FxProperty.TapeEchoRate, _properties);
            TapeEchoIntensity = new PropertyIntViewModel(FxProperty.TapeEchoIntensity, _properties);
            TapeEchoLevel = new PropertyIntViewModel(FxProperty.TapeEchoLevel, _properties);
        }
    }
}
