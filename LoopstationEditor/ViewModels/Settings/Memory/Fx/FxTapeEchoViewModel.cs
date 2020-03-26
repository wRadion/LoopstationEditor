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
            TapeEchoRate = new PropertyIntViewModel(nameof(model.TapeEchoRate), PropertySet);
            TapeEchoIntensity = new PropertyIntViewModel(nameof(model.TapeEchoIntensity), PropertySet);
            TapeEchoLevel = new PropertyIntViewModel(nameof(model.TapeEchoLevel), PropertySet);
        }
    }
}
