using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxTapeEchoViewModel : FxViewModel
    {
        public PropertyIntViewModel TapeEchoRate { get; }
        public PropertyIntViewModel TapeEchoIntensity { get; }
        public PropertyIntViewModel TapeEchoLevel { get; }

        public FxTapeEchoViewModel(SettingsMemoryFxModel model)
            : base("Tape Echo", model)
        {
            TapeEchoRate = new PropertyIntViewModel(nameof(TapeEchoRate), _properties);
            TapeEchoIntensity = new PropertyIntViewModel(nameof(TapeEchoIntensity), _properties);
            TapeEchoLevel = new PropertyIntViewModel(nameof(TapeEchoLevel), _properties);
        }
    }
}
